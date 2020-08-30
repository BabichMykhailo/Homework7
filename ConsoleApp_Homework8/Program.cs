using ClassLibrary_Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double price; 
            int expirationDate;

            while (true)
            {
                Console.WriteLine("Press any key to add product, press <escape> to quit. Press <i> for info");
                ConsoleKeyInfo P = Console.ReadKey();

                if (P.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (P.Key == ConsoleKey.I)
                {
                    foreach(var i in Storage.products)
                    {
                        Console.WriteLine(i);
                    }    
                    Console.WriteLine(Storage.StorageCopacity());
                }
                else
                {
                    Console.WriteLine("Enter name");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter price");
                    Double.TryParse(Console.ReadLine(), out price);

                    Console.WriteLine("Enter Expiraration date");
                    Int32.TryParse(Console.ReadLine(), out expirationDate);

                    Console.WriteLine("Enter the date of delivery(yyyy/mm/dd):");
                    string[] date = Console.ReadLine().Split('/');
                    DateTime deliveryDate = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));

                    Storage.products.Add(new Product(name, price, expirationDate, deliveryDate));
                }
            }
        }
    }
}
