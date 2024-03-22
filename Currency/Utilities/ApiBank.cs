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
                    return 3.6;
                case "Rub":
                    return 70;
                case "Pound":
                    return 0.8;
                case "Jpy":
                    return 0.007;
                default:
                    throw new ArgumentException("Invalid currency type");
            }

        }
    }
}
