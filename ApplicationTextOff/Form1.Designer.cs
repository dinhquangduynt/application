namespace ApplicationTextOff
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelcvt = new System.Windows.Forms.Label();
            this.txtcvt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diengiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdiengiai = new System.Windows.Forms.TextBox();
            this.labeldiengiai = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcvt
            // 
            this.labelcvt.AutoSize = true;
            this.labelcvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcvt.Location = new System.Drawing.Point(12, 24);
            this.labelcvt.Name = "labelcvt";
            this.labelcvt.Size = new System.Drawing.Size(106, 20);
            this.labelcvt.TabIndex = 0;
            this.labelcvt.Text = "Chữ viết tắt";
            // 
            // txtcvt
            // 
            this.txtcvt.Location = new System.Drawing.Point(12, 49);
            this.txtcvt.Multiline = true;
            this.txtcvt.Name = "txtcvt";
            this.txtcvt.Size = new System.Drawing.Size(108, 33);
            this.txtcvt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cvt,
            this.diengiai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cvt
            // 
            this.cvt.DataPropertyName = "cvt";
            this.cvt.HeaderText = "Chữ Viết tắt";
            this.cvt.MinimumWidth = 6;
            this.cvt.Name = "cvt";
            this.cvt.ReadOnly = true;
            this.cvt.Width = 110;
            // 
            // diengiai
            // 
            this.diengiai.DataPropertyName = "diengiai";
            this.diengiai.HeaderText = "Nghĩa";
            this.diengiai.MinimumWidth = 6;
            this.diengiai.Name = "diengiai";
            this.diengiai.ReadOnly = true;
            this.diengiai.Width = 230;
            // 
            // txtdiengiai
            // 
            this.txtdiengiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiengiai.Location = new System.Drawing.Point(168, 49);
            this.txtdiengiai.Multiline = true;
            this.txtdiengiai.Name = "txtdiengiai";
            this.txtdiengiai.Size = new System.Drawing.Size(231, 33);
            this.txtdiengiai.TabIndex = 4;
            this.txtdiengiai.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labeldiengiai
            // 
            this.labeldiengiai.AutoSize = true;
            this.labeldiengiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiengiai.Location = new System.Drawing.Point(168, 24);
            this.labeldiengiai.Name = "labeldiengiai";
            this.labeldiengiai.Size = new System.Drawing.Size(112, 20);
            this.labeldiengiai.TabIndex = 3;
            this.labeldiengiai.Text = "Thay thế bởi";
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(424, 49);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 28);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(424, 100);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 28);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(424, 151);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 28);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(424, 202);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 28);
            this.btnhuy.TabIndex = 8;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Design by Duy Đinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(524, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdiengiai);
            this.Controls.Add(this.labeldiengiai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcvt);
            this.Controls.Add(this.labelcvt);
            this.Name = "Form1";
            this.Text = "Ứng dụng gõ tắt";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelcvt;
        private System.Windows.Forms.TextBox txtcvt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdiengiai;
        private System.Windows.Forms.Label labeldiengiai;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diengiai;
        private System.Windows.Forms.Label label1;
    }
}




