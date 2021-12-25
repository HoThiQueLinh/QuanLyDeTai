
namespace QLDeTai
{
    partial class FmChuDe
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
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dataTableCD = new System.Windows.Forms.DataGridView();
            this.macd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttim = new System.Windows.Forms.TextBox();
            this.txtmacd = new System.Windows.Forms.TextBox();
            this.txttencd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsua.Location = new System.Drawing.Point(639, 273);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(96, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxoa.Location = new System.Drawing.Point(639, 328);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(96, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(639, 218);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthoat.Location = new System.Drawing.Point(639, 386);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dataTableCD
            // 
            this.dataTableCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macd,
            this.tencd});
            this.dataTableCD.Location = new System.Drawing.Point(40, 218);
            this.dataTableCD.Name = "dataTableCD";
            this.dataTableCD.ReadOnly = true;
            this.dataTableCD.RowHeadersWidth = 51;
            this.dataTableCD.RowTemplate.Height = 24;
            this.dataTableCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableCD.Size = new System.Drawing.Size(572, 191);
            this.dataTableCD.TabIndex = 12;
            this.dataTableCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableCD_CellClick);
            // 
            // macd
            // 
            this.macd.DataPropertyName = "macd";
            this.macd.HeaderText = "Mã Chủ Đề";
            this.macd.MinimumWidth = 6;
            this.macd.Name = "macd";
            this.macd.ReadOnly = true;
            // 
            // tencd
            // 
            this.tencd.DataPropertyName = "tencd";
            this.tencd.HeaderText = "Tên Chủ Đề";
            this.tencd.MinimumWidth = 6;
            this.tencd.Name = "tencd";
            this.tencd.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.txttim);
            this.panel1.Controls.Add(this.txtmacd);
            this.panel1.Controls.Add(this.txttencd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Location = new System.Drawing.Point(40, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 160);
            this.panel1.TabIndex = 13;
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(392, 22);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(180, 22);
            this.txttim.TabIndex = 5;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // txtmacd
            // 
            this.txtmacd.Location = new System.Drawing.Point(119, 82);
            this.txtmacd.Name = "txtmacd";
            this.txtmacd.Size = new System.Drawing.Size(166, 22);
            this.txtmacd.TabIndex = 4;
            // 
            // txttencd
            // 
            this.txttencd.Location = new System.Drawing.Point(415, 82);
            this.txttencd.Name = "txttencd";
            this.txttencd.Size = new System.Drawing.Size(157, 22);
            this.txttencd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Chủ Đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Chủ Đề";
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
            this.groupBox1.Size = new System.Drawing.Size(776, 456);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Chủ Đề";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FmChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dataTableCD);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmChuDe";
            this.Text = "ChuDe";
            this.Load += new System.EventHandler(this.FmChuDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dataTableCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.TextBox txtmacd;
        private System.Windows.Forms.TextBox txttencd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridViewTextBoxColumn macd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}