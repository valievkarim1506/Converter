using Program.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    internal class EUFactory : IFactory
    {
        public Currency CreateCurrency(string Currency)
        {
            switch (Currency)
            {
                case "Nis":
                    return new Nis("Nis");
                case "Pound":
                    return new Pound("Pound");
                case "Rub":
                    return new Rub("Rub");
                    default:
                    throw new ArgumentException("Invalid currency type");

            }

        }
    }
}
