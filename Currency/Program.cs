using Program.Interfaces;
using Program.Models;
using Program.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        public static void Main()
        {
            //Nis Nis = new Nis("Nis");
            //Console.WriteLine(Nis.ReturnRateFromApi());

            //Rub Rub = new Rub("Rub");
            //Console.WriteLine(Rub.ReturnRateFromApi());

            //Pound Pound = new Pound("Pound");
            //Console.WriteLine(Pound.ReturnRateFromApi());


            //IFactory factory = new UEFactory();
            //Currency Niscurrency = factory.CreateCurrency("Nis");
            //Console.WriteLine(Niscurrency.ReturnRateFromApi());


            //Console.WriteLine(CurrencyCalculator.EUFactory(10, "Pound"));


            Console.WriteLine(CurrencyCalculatorForUEandAsia.EUandAsiaCurrencies(10, "Rub"));
            

            
        }


    }
}
