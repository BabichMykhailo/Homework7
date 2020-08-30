using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Homework
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; set; }
        public int ExpirationDate { get; set; }
        public DateTime DeliveryDay { get; set; }


        public Product(string name, double price, int expirationDate)
        {
            Name = name;
            Price = price;
            ExpirationDate = expirationDate;
            DeliveryDay = DateTime.Now;
        }

        public DateTime ExpirationDay()
        {
            return DeliveryDay.AddDays(ExpirationDate);
        }

        public override string ToString()
        {
            return $"Name {Name}, Price {Price}, ExpirationDate {ExpirationDate}";
        }

        public Product(string name, double price, int expirationDate, DateTime deliveryDay)
        {
            Name = name;
            Price = price;
            ExpirationDate = expirationDate;
            DeliveryDay = deliveryDay;
        }
    }

    
}
