using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnpm
{
    public class listCustomer
    {
        private static listCustomer instance;

        public static listCustomer Instance
        {
            get
            {
                if (instance == null)
                    instance = new listCustomer();
                return instance;
            }

            set => instance = value;
        }

        List<Customer> listcustomer;

        internal List<Customer> Listcustomer { get => listcustomer; set => listcustomer = value; }

        listCustomer()
        {
            listcustomer = new List<Customer>();
            DateTime aDateTime =  DateTime.Now;
            listcustomer.Add(new Customer(1, "haihieu", "123456", "hồ", "hiếu", 0785847233, "860/58/7", aDateTime));
        }
    }
}
