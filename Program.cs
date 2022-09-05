using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compoundInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("compound interest : {0}\n");
            CompoundInterest();
        }
        /*static void CompoundInterest()
        {
            double principle = 6000;
            int interest = 5;
            int year = 10;

           var amount = principle * (Math.Pow((1 + interest / 100), year));
        }*/
       
        static void CompoundInterest()
        {
            double[] monthlyValues = { 1000, 2000, 1000, 4000, 3000 };
            double investement = monthlyValues[4];
            double total = 0;
            int monthlyInterestReturn = 5;
            int numberOfYears = 2;


            var amount = total * (Math.Pow((1 + monthlyInterestReturn / 100), numberOfYears));

            Console.ReadLine();

        }
            



       

    }

   

}
