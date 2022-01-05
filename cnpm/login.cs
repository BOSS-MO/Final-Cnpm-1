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
    public partial class login : Form
    {
        string emailadmin = "admin";
        string passadmin = "admin";
        List<Customer> listCus = listCustomer.Instance.Listcustomer;

        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtEmail.Text , txtPasss.Text))
            {
                product product = new product();
                product.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txtEmail.Focus();
            }

        }

        bool CheckLogin(string email, string pass)
        {
            if (email == this.emailadmin && pass == this.passadmin)
            {
                return true;
            }

            for(int i = 0; i < listCus.Count; i++)
            {
                if(email == listCus[i].Email && pass == listCus[i].Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
