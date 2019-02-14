using System;

namespace Tip_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("What is your bill amount?");
            string billInput = Console.ReadLine();
            //billInput = billInput.Trim();
            //billInput = billInput.Trim('$');
            billInput = billInput.Trim().Trim('$');

            double bill;
            if (!double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {billInput} is not valid.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What percent would you like to tip?");
            string tipPercentInput = Console.ReadLine();
            //tipPercentInput = tipPercentInput.Trim();
            //tipPercentInput = tipPercentInput.Trim('%');
            tipPercentInput = tipPercentInput.Trim().Trim('%');

            double tipPercent;
            if(!double.TryParse(tipPercentInput, out tipPercent))
            {
                Console.WriteLine($"The value {tipPercentInput} is not valid.");
                Console.ReadLine();
                return;
            }

           
            //double bill = double.Parse(billInput);
            //int tipPercent = int.Parse(tipPercentInput);

            double tipAmount = tipPercent * bill / 100;
            double totalBill = bill + tipAmount;
            tipAmount = Math.Round(tipAmount, 2);
            totalBill = Math.Round(totalBill, 2);

            Console.WriteLine($"Your tip amount is ${tipAmount}.");
            Console.WriteLine($"Your total bill is ${totalBill}.");
            
            Console.ReadLine();






        }
    }
}
