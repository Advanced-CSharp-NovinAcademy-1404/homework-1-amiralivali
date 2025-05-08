using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePrice
{
    internal class Program
    {
        static double CalculatePrice(double price, double tax = 0.1, double discount = 0.05)
        {
            tax *= price;
            discount *= price;
            double finalPrice = price + tax - discount;
            return finalPrice;
        }
        static void Main(string[] args)
        {
            double price = 0;
            //فراخوانی اول
            price = CalculatePrice(120000);
            Console.WriteLine("price :{0}", price); // Expected:126000

            //فراخوانی دوم
            price = CalculatePrice(120000, 0);
            Console.WriteLine("price :{0}", price); // Expected:114000

            //فراخوانی سوم
            price = CalculatePrice(120000, 0, 0.10); 
            Console.WriteLine("price :{0}", price); // Expected:108000

            //فراخوانی چهارم
            price = CalculatePrice(120000, discount: 0.15);
            Console.WriteLine("price :{0}", price); // Expected:114000

            //فراخوانی پنجم
            price = CalculatePrice(120000, 0.09);
            Console.WriteLine("price :{0}", price); // Expected:124800

            Console.ReadLine();
        }
    }
}
