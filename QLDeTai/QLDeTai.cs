using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeTai
{
    public partial class QLDeTai : Form
    {
        public QLDeTai()
        {
            InitializeComponent();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QLDeTai_Load(object sender, EventArgs e)
        {
            menu m = new menu();
            AddForm(m);
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }
        private void qLChudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmChuDe cd = new FmChuDe();
            AddForm(cd);
        }

        private void qLDeTaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDeTai dt = new FmDeTai();
            AddForm(dt);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hethongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            AddForm(m);

        }
    }
}
