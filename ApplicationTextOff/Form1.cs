using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTextOff
{
    public partial class Form1 : Form
    {
        StreamWriter writer;
        StreamReader reader;
        private string gotat;
        private Boolean check = false;

        public static int lengthGrid = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void createTable()
        {
            reader = new StreamReader("GoTat.txt");
            while (true)
            {
                gotat = reader.ReadLine();
                if (gotat == null)
                {
                    reader.Close();
                    return;
                }
                this.dataGridView1.Rows.Add(gotat.Split(':'));


            }
            return;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void formMain_Load(object sender, EventArgs e)
        {
            createTable();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            object[] objArray;
            if (string.IsNullOrEmpty(txtcvt.Text) || string.IsNullOrEmpty(txtdiengiai.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
                txtcvt.Focus();
                return;
            }
            int i = 0;
            while (i < this.dataGridView1.Rows.Count)
            {
                if (this.dataGridView1[0, i].Value.ToString() == txtcvt.Text.ToString().ToLower())
                {
                    MessageBox.Show("Chữ viết tắt " + txtcvt.Text + " đã tồn tại!", "Thông báo");
                    return;
                }
                i += 1;
            }


            objArray = new object[] { txtcvt.Text.ToLower(), txtdiengiai.Text };
            dataGridView1.Rows.Add(objArray);
            //this.dataGridView1[0, this.dataGridView1.SelectedCells[0].RowIndex].Value = this.txtcvt.Text;
            //this.dataGridView1[1, this.dataGridView1.SelectedCells[0].RowIndex].Value = this.txtdiengiai.Text;
            dataGridView1.Sort(dataGridView1.Columns[0], 0);
            saveFile();
            return;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (this.dataGridView1.Rows.Count > 1 && numrow >= 0)
            {
                txtcvt.Text = dataGridView1[0, numrow].Value.ToString();
                txtdiengiai.Text = dataGridView1[1, numrow].Value.ToString();
            }
            return;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcvt.Text) || string.IsNullOrEmpty(txtdiengiai.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
                txtcvt.Focus();

                return;
            }
            String gotattext = this.dataGridView1[0, this.dataGridView1.SelectedCells[0].RowIndex].Value.ToString();
            this.dataGridView1[0, this.dataGridView1.SelectedCells[0].RowIndex].Value = this.txtcvt.Text;
            this.dataGridView1[1, this.dataGridView1.SelectedCells[0].RowIndex].Value = this.txtdiengiai.Text;
            saveFile();
            return;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count == 1)
            {
                this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedCells[0].RowIndex);
                txtcvt.Text = "";
                txtdiengiai.Text = "";

            }
            saveFile();
            return;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.txtcvt.Text = "";
            this.txtdiengiai.Text = "";
            this.check = false;
            return;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            /*     StreamWriter sw = new StreamWriter("GoTat2.txt", true);
                 int i = 0;
                 while (i < dataGridView1.Rows.Count)
                 {
                     sw.WriteLine(this.dataGridView1[0, i].Value.ToString() + ":" + this.dataGridView1[1, i].Value.ToString());
                     i += 1;
                 }
                 sw.Close();*/
            if (File.Exists("GoTat.txt"))
            {
                File.Delete("GoTat.txt");
            }

            writer = new StreamWriter("GoTat.txt", true);


            int i = 0;
            while (i < dataGridView1.Rows.Count)
            {
                writer.WriteLine(this.dataGridView1[0, i].Value.ToString() + ":" + this.dataGridView1[1, i].Value.ToString());

                i += 1;
            }

            writer.Close();
            /* if (File.Exists("GoTat2.txt"))
             {
                 File.Delete("GoTat2.txt");
             }*/

            return;
        }


        private void setFileText()

        {


            reader = new StreamReader("GoTat.txt");
            while (true)
            {
                gotat = reader.ReadLine();
                if (gotat == null)
                {
                    reader.Close();
                    break;
                }
                this.dataGridView1.Rows.Add(gotat.Split(':'));


            }

            writer = new StreamWriter("GoTat.txt", true);

            int i = 0;
            while (i < dataGridView1.Rows.Count)
            {
                writer.WriteLine(this.dataGridView1[0, i].Value.ToString() + ":" + this.dataGridView1[1, i].Value.ToString());
                i += 1;
            }
            writer.Close();
            this.check = false;
            return;

        }

        private void formMain_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}

