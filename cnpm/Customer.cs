using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnpm
{
    class Customer
    {
        private int id;
        public int Id { get => id; set => id = value; }

        private string email;

        public string Email { get => email; set => email = value; }

        private string password;

        public string Password { get => password; set => password = value; }

        private string ho;
        public string Ho { get => ho; set => ho = value; }

        private string ten;

        public string Ten { get => ten; set => ten = value; }

        private int Phone;
        public int Phone1 { get => Phone; set => Phone = value; }

        private string address;

        public string Address { get => address; set => address = value; }

        private DateTime create_date;

        public DateTime Create_date { get => create_date; set => create_date = value; }

        public Customer(int id , string email , string password , string ho , string ten , int phone , string address , DateTime date)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.ho = ho;
            this.ten = ten;
            this.Phone = phone;
            this.address = address;
            this.create_date = date;
        }
    }
}
