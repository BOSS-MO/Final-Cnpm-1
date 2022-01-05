using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnpm
{
    public partial class product : Form
    {
        

        public product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login p = new login();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuatKho xkho = new PhieuXuatKho();
            xkho.Show();

        }

        private void taToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhapKho kho = new PhieuNhapKho();
            kho.Show();

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login t = new login();
            t.Show();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 kh = new Form1();
            kh.Show();

        }
    }
}
