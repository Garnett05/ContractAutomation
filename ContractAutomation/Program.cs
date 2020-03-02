using System;
using System.Globalization;
using ContractAutomation.Entities;
using ContractAutomation.Services;

namespace ContractAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy)" );
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue, new PayPal());

            contract.InstallmentCalculation(numberInstallments);
            Console.WriteLine(contract);
        }
    }
}
