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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            String ho = txtHo.Text;
            String ten = txtTen.Text;


            if (Check())
            {
                setting.suaChuoi(ref ho);
                setting.suaChuoi(ref ten);

                txtInfo.Text = "Họ : " + ho + "   Tên : " + ten + Environment.NewLine +
                                "Địa chỉ : " + txtAdress.Text + Environment.NewLine +
                                "Số điện thoại : " + txtSDT.Text + Environment.NewLine +
                                "Email : " + txtEmail.Text + Environment.NewLine +
                                "Password : " + txtPass.Text;
            }
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        bool Check()
        {
            if (txtHo.Text == "")
            {
                MessageBox.Show("Hãy nhập Họ của bạn", "Thông báo");
                txtHo.Focus();
                return false;
            }

            if (txtTen.Text == "")
            {
                MessageBox.Show("Hãy nhập Tên của bạn", "Thông báo");
                txtHo.Focus();
                return false;
            }

            if (txtAdress.Text == "")
            {
                MessageBox.Show("Hãy nhập Địa chỉ của bạn", "Thông báo");
                txtHo.Focus();
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Hãy nhập Số điện thoại của bạn", "Thông báo");
                txtHo.Focus();
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Hãy nhập Email của bạn", "Thông báo");
                txtHo.Focus();
                return false;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Hãy nhập Mật khẩu của bạn", "Thông báo");
                txtHo.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }
    }
}
