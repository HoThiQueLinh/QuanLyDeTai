
namespace QLDeTai
{
    partial class FmDeTai
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
            this.dataTableCD = new System.Windows.Forms.DataGridView();
            this.madt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.txtmadt = new System.Windows.Forms.TextBox();
            this.txttendt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableCD
            // 
            this.dataTableCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madt,
            this.tendt,
            this.ngaybd,
            this.ngaykt});
            this.dataTableCD.Location = new System.Drawing.Point(53, 219);
            this.dataTableCD.Name = "dataTableCD";
            this.dataTableCD.ReadOnly = true;
            this.dataTableCD.RowHeadersWidth = 51;
            this.dataTableCD.RowTemplate.Height = 24;
            this.dataTableCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableCD.Size = new System.Drawing.Size(572, 191);
            this.dataTableCD.TabIndex = 18;
            this.dataTableCD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableCD_CellContentClick);
            // 
            // madt
            // 
            this.madt.DataPropertyName = "madt";
            this.madt.HeaderText = "Mã Đề Tài";
            this.madt.MinimumWidth = 6;
            this.madt.Name = "madt";
            this.madt.ReadOnly = true;
            // 
            // tendt
            // 
            this.tendt.DataPropertyName = "tendt";
            this.tendt.HeaderText = "Tên Đề Tài";
            this.tendt.MinimumWidth = 6;
            this.tendt.Name = "tendt";
            this.tendt.ReadOnly = true;
            // 
            // ngaybd
            // 
            this.ngaybd.DataPropertyName = "ngaybd";
            this.ngaybd.HeaderText = "Ngày BĐ";
            this.ngaybd.MinimumWidth = 6;
            this.ngaybd.Name = "ngaybd";
            this.ngaybd.ReadOnly = true;
            // 
            // ngaykt
            // 
            this.ngaykt.DataPropertyName = "ngaykt";
            this.ngaykt.HeaderText = "Ngày KT";
            this.ngaykt.MinimumWidth = 6;
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.ReadOnly = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthoat.Location = new System.Drawing.Point(652, 387);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 23);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(652, 219);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxoa.Location = new System.Drawing.Point(652, 329);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsua.Location = new System.Drawing.Point(652, 274);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(96, 23);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.dateKT);
            this.panel1.Controls.Add(this.dateBD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttim);
            this.panel1.Controls.Add(this.txtmadt);
            this.panel1.Controls.Add(this.txttendt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Location = new System.Drawing.Point(53, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 160);
            this.panel1.TabIndex = 19;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(548, 91);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 11;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dateKT
            // 
            this.dateKT.CustomFormat = "dd/MM/yyyy";
            this.dateKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT.Location = new System.Drawing.Point(360, 95);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(133, 22);
            this.dateKT.TabIndex = 10;
            this.dateKT.Value = new System.DateTime(2021, 12, 25, 0, 0, 0, 0);
            // 
            // dateBD
            // 
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.Location = new System.Drawing.Point(360, 55);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(133, 22);
            this.dateBD.TabIndex = 9;
            this.dateBD.Value = new System.DateTime(2021, 12, 25, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày KT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày BĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Chủ Đề";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(392, 22);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(180, 22);
            this.txttim.TabIndex = 5;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // txtmadt
            // 
            this.txtmadt.Location = new System.Drawing.Point(101, 55);
            this.txtmadt.Name = "txtmadt";
            this.txtmadt.Size = new System.Drawing.Size(130, 22);
            this.txtmadt.TabIndex = 4;
            // 
            // txttendt
            // 
            this.txttendt.Location = new System.Drawing.Point(101, 95);
            this.txttendt.Name = "txttendt";
            this.txttendt.Size = new System.Drawing.Size(130, 22);
            this.txttendt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đề Tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đề Tài";
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btntim.Location = new System.Drawing.Point(592, 20);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(77, 27);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm Kiếm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Đề Tài";
            // 
            // FmDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTableCD);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmDeTai";
            this.Text = "DeTai";
            this.Load += new System.EventHandler(this.FmDeTai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn madt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykt;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker dateKT;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.TextBox txtmadt;
        private System.Windows.Forms.TextBox txttendt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}