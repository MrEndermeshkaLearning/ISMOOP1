using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFor7ISMBoot;

namespace ISMBootCamp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            do
            {
                LibFor7ISMBoot.Airoplane x = new Airoplane();
                LibFor7ISMBoot.Airoplane y = new Airoplane();
                Console.WriteLine($"Fly and Arive in same day? {x.IsArrivingToday()}");
                Console.WriteLine($"GetTotalTime: ");
                x.GetTotalTime();
                LibFor7ISMBoot.Product product = new Product();
               Console.WriteLine($"Total Price UAH:{product.GetTotalPriceInUAH()}\n");
                Console.WriteLine($"Price per one UAH:{product.GetPriceInUAH()}\n");
                Console.WriteLine($"Total Weight: {product.GetTotalWeight()}\n");
                Console.WriteLine("do you want to continue, input zero for no, another for yes\n");
                counter = getInt();
            } while (counter != 0);
        }
        private static int getInt()
        {
            int x = int.MaxValue;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("TryAgain\n");
                }
                if (x != int.MaxValue)
                {
                    break;
                }
            }
            return x;
        }
    }
}
