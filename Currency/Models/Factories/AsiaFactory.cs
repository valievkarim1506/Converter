using Program.Interfaces;
using Program.Models.Currencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models.Factories
{
    internal class AsiaFactory : IFactory
    {
        public Currency CreateCurrency(string Currency)
        {
            switch (Currency)
            {
                case "Jpy":
                    return new Jpy("Jpy");
                default:
                    throw new ArgumentException("Invalid currency type");

            }
        }
    }
}
