using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTextOff
{
    class UserActivityHook
    {

        #region hook key board
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0002;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr keybd_event(byte vkCode, byte bScan, uint wParam, UIntPtr uIntPtr);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);



        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }


        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                CheckHotKey(vkCode);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        public static void HookKeyboard()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        #endregion

        #region settext
        static string gotat = "";
        static string gotatkey;
        static StreamReader reader;


        static void CheckHotKey(int vkCode)

        {
            if (((Keys)(vkCode) == Keys.Space || (Keys)(vkCode) == Keys.Enter) && gotatkey != null)
            {
                
                if (File.Exists("GoTat.txt"))
                 {
                reader = new StreamReader("GoTat.txt");
                 }
                 //else
                 //{
                 //    reader = new StreamReader("GoTat2.txt");
                 //}*/

                while (true)
                {
                    gotat = reader.ReadLine();
                    if (gotat == null)
                    {
                        reader.Close();
                        break;
                    }

                    string[] str = gotat.Split(':');

                    if (str[0].Equals(gotatkey.ToLower()))
                    {

                        Thread.Sleep(10);

                        Clipboard.SetText(str[1]);

                        for (int i = 0; i < str[0].Length; i++)
                        {
                            keybd_event((byte)Keys.Back, 0, 0, UIntPtr.Zero);
                            keybd_event((byte)Keys.Back, 0, 2, UIntPtr.Zero);
                        }

                        //shift+insert
                        keybd_event(0x10, 0, 0, UIntPtr.Zero);
                        keybd_event(0x2D, 0, 1, UIntPtr.Zero);
                        keybd_event(0x2D, 0, 2, UIntPtr.Zero);
                        keybd_event(0x10, 0, 2, UIntPtr.Zero);

                        Thread.Sleep(50);
                        Clipboard.Clear();
                        reader.Close();
                        break;
                    }
                }
                gotatkey = "";
            }
            if (((char)vkCode >= 'A' && (char)vkCode <= 'Z') || ((char)vkCode >= 'a' && (char)vkCode <= 'z'))
            {
                gotatkey += (char)(vkCode);
            }
            try
            {
                if (gotatkey != null && (Keys)vkCode == Keys.Back)
                {
                    gotatkey = gotatkey.Remove(gotatkey.Length - 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        #endregion
    }
}

