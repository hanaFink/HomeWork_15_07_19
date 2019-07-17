using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_07_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfTax = 0;
            ITaxable [] myAssets = new ITaxable[6];
            myAssets[0] = new House("Herzel","Nes Ziona",2500000,60,30);
            myAssets[1] = new House("Ahuza", "Raanana", 5000000, 45, 10);
            myAssets[2] = new House("Waizman", "Rehovot", 2000000, 75, 50);
            myAssets[3] = new Bus("111-222", 50, 60000,10);
            myAssets[4] = new Bus("33-444-333",80,150000,25); 
            myAssets[5] = new Bus("55-666-77", 140, 2500000, 35);
            for (int i = 0; i < myAssets.Length; i++)
            {
                Console.Write(myAssets[i]);
                Console.WriteLine(myAssets[i].CalculateTax());
                sumOfTax += myAssets[i].CalculateTax();

            }
            Console.WriteLine($"The sum of taxes is : {sumOfTax:n}");
        }
    }
}
