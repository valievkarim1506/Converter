using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Interfaces.Utilities
{
    internal static class ApiBank
    {
        public static double GetRate(string Currency)
        {
            switch (Currency)
            {
                case "Nis":
                    return 2.5;
                case "Rub":
                    return 92;
                case "Pound":
                    return 0.8;
                case "Jpy":
                    return 0.007;
                case "Byn":
                    return 3.2;
                default:
                    throw new ArgumentException("Invalid currency type");
            }

        }
    }
}
