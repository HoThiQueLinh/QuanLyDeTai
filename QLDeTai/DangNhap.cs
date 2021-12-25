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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndannhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LINHBLACK\SQLEXPRESS;Initial Catalog=QLDeTai;User ID=sa;Password=0905608763");
            try {
                if(txttendn == null || txttendn.Equals(""))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                if (txtmk == null || txtmk.Equals(""))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                connection.Open();
                String tk = txttendn.Text;
                String mk = txtmk.Text;
                string sql = "select * from Admin where username ='"+txttendn.Text.Trim() +"' and pass='"+txtmk.Text.Trim()+"'";
                SqlCommand cmd = new SqlCommand(sql,connection);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    QLDeTai dt = new QLDeTai();
                    dt.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
