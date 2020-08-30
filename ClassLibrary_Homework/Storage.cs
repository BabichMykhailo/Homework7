using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Homework
{
    public class Storage
    {
        public static List<Product> products = new List<Product>();

        public static void WriteOff()
        {
            foreach(var product in products)
            {
                if (DateTime.Now == product.ExpirationDay())
                {
                    products.Remove(product);
                }
            }
        }

        public static int StorageCopacity()
        {
            return products.Count;
        }
    }
}
