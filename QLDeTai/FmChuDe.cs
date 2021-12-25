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
    public partial class FmChuDe : Form
    {
       
        public FmChuDe()
        {
            InitializeComponent();
        }
        ModifyCD modify;
        ChuDe chuDe;
        private void FmChuDe_Load(object sender, EventArgs e)
        {
            modify = new ModifyCD();
            try
            {
                dataTableCD.DataSource = modify.getAllChuDe();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool CheckData()
        {
            if (String.IsNullOrEmpty(txtmacd.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacd.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txttencd.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttencd.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData()) { 
            String macd = this.txtmacd.Text;
            String tencd = this.txttencd.Text;
            chuDe = new ChuDe(macd, tencd);
            if (modify.insert(chuDe))
            {
                dataTableCD.DataSource = modify.getAllChuDe();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            String macd = this.txtmacd.Text;
            String tencd = this.txttencd.Text;
            chuDe = new ChuDe(macd, tencd);
            if (modify.update(chuDe))
            {
                dataTableCD.DataSource = modify.getAllChuDe();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String macd = dataTableCD.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteChuDe(macd))
            {
                dataTableCD.DataSource = modify.getAllChuDe();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataTableCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0)
            {
                txtmacd.Text = dataTableCD.Rows[index].Cells["macd"].Value.ToString();
                txttencd.Text = dataTableCD.Rows[index].Cells["tencd"].Value.ToString();
            }    
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttim.Text != null)
            {
                dataTableCD.DataSource = modify.XemDL("select * from ChuDe where tencd like '%" + txttim.Text.Trim() + "%' ");
            }
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            if (txttim.Text != null)
            {
                dataTableCD.DataSource = modify.XemDL("select * from ChuDe where tencd like '%" + txttim.Text.Trim() + "%' ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
