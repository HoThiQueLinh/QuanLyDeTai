using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDeTai
{
    public partial class FmDeTai : Form
    {
        
        public FmDeTai()
        {
            InitializeComponent();
        }
        ModifyDT modify;
        DeTai deTai;
        ModifyCD modi;
        public void ShowCombobox()
        {
            modi = new ModifyCD();
            comboBox.DataSource = new ModifyCD().getAllChuDe();
            comboBox.DisplayMember="tencd";
            comboBox.ValueMember = "macd";
        }
        private void FmDeTai_Load(object sender, EventArgs e)
        {
            modify = new ModifyDT();
            try
            {
                dataTableCD.DataSource = modify.getAllDeTai();
                this.ShowCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            if (txttim.Text != null)
            {
                dataTableCD.DataSource = modify.XemDL("select * from DeTai where tendt like '%" + txttim.Text.Trim() + "%' ");
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttim.Text != null)
            {
                dataTableCD.DataSource = modify.XemDL("select * from DeTai where tendt like '%" + txttim.Text.Trim() + "%' ");
            }
        }
        public bool CheckData()
        {
            if (String.IsNullOrEmpty(txtmadt.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmadt.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txttendt.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttendt.Focus();
                return false;
            }
            
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                String madt = this.txtmadt.Text;
                String tendt = this.txttendt.Text;
                DateTime ngaybd = this.dateBD.Value;
                DateTime ngaykt = this.dateKT.Value;
                String macd = this.comboBox.Text;
                deTai = new DeTai(madt, tendt, ngaybd, ngaykt, macd);
                if (modify.insertDeTai(deTai))
                {
                    dataTableCD.DataSource = modify.getAllDeTai();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataTableCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtmadt.Text = dataTableCD.Rows[index].Cells["madt"].Value.ToString();
                txttendt.Text = dataTableCD.Rows[index].Cells["tendt"].Value.ToString();
                dateBD.Text = dataTableCD.Rows[index].Cells["ngaybd"].Value.ToString();
                dateKT.Text = dataTableCD.Rows[index].Cells["ngaykt"].Value.ToString();
                comboBox.Text = dataTableCD.Rows[index].Cells["macd"].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String madt = dataTableCD.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteDeTai(madt))
            {
                dataTableCD.DataSource = modify.getAllDeTai();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            String madt = this.txtmadt.Text;
            String tendt = this.txttendt.Text;
            DateTime ngaybd = this.dateBD.Value;
            DateTime ngaykt = this.dateKT.Value;
            String macd = this.comboBox.Text;
            deTai = new DeTai(madt, tendt, ngaybd, ngaykt, macd);
            if (modify.updateDeTai(deTai))
            {
                dataTableCD.DataSource = modify.getAllDeTai();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
