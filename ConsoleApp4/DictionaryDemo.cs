using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   
    class product
    {
        public product(int Id, string Name)
        {
            ProductId = Id;
            ProductName = Name;
        }

        private int p_Id;
        public int ProductId
        {
            get { return p_Id; }
            set { p_Id = value; }
        }

        private string pro_name;
        public string ProductName { get { return pro_name; } set { pro_name = value; } }
    }
    class DictionaryDemo
    {
        static void Main()
        {

            Dictionary<int, product> products = new Dictionary<int, product>();
            product pr = new product(1, "Samsung");
            product pr1 = new product(2, "LG");
            products.Add(pr.ProductId, pr);
            products.Add(pr1.ProductId, pr1);
            foreach (KeyValuePair<int, product> keys in products)
            {
                Console.Write(" Product Id: " + keys.Key + " " + "Product Name " + keys.Value.ProductName + " ");
            }
            Console.ReadLine();
        }

        


    }


}

