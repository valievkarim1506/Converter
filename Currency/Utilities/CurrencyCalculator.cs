using Program.Interfaces;
using Program.Models;
using Program.Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Utilities
{
    internal static class CurrencyCalculator
    {
        public static double EUFactory(double Tokens, string Currency)
        {
            IFactory factory = new EUFactory();
            Currency currency = factory.CreateCurrency(Currency);
            return Tokens * currency.ReturnRateFromApi();
        }

    }

    internal static class CurrencyCalculatorForUEandAsia
    { 
        private static IFactory ChooseFactoryForCurrency(string Currency)
        {
            FactoryChooser factoryChooser = new FactoryChooser(new EUFactory(), new AsiaFactory());
            IFactory factory = (IFactory)factoryChooser.FactoryChooserForCurrency(Currency);
            return factory;
        }

        private static Currency GetCurrency(IFactory factory, string Currency)
        {
            Currency TypeOfCurrency=factory.CreateCurrency(Currency);
            return TypeOfCurrency;
        }

        public static double EUandAsiaCurrencies(double Tokens, string currency)
        {
            IFactory factory = ChooseFactoryForCurrency(currency);
            Currency TypeOfCurrency=GetCurrency(factory, currency);

            double Result=Tokens*TypeOfCurrency.ReturnRateFromApi();    
            return Result;
        }
    
    }




}
