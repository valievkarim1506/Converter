using Program.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Utilities
{
    internal class FactoryChooser
    {
        private readonly IFactory EUFactory;
        private readonly IFactory AsianFactory;

        public FactoryChooser(IFactory euFactory, IFactory asianFactory)
        {
            EUFactory = euFactory;
            AsianFactory = asianFactory;
        }

        public object FactoryChooserForCurrency(string currency)
        {
            switch (currency)
            {
                case "Nis":
                case "Pound":
                case "Rub":
                    return EUFactory;

                case "Jpy":
                    return AsianFactory;

                    default:
                    throw new ArgumentException("Invalid type of" + currency);
            }


        }
    }
}
