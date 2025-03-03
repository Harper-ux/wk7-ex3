using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace wk7_ex3
{
    internal class Shopper
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        private double price;

        public Shopper(string productID, string productName, double price)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //attempt stumped coder and workscheduale got ahead of them 
        }
    }
}
