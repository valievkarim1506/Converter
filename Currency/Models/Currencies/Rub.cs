using Program.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    internal class Rub : Currency
    {
        public Rub(string Currency) : base(Currency)
        {
        }

        public override double GetRateFromApi(string Currency)
        {
            return ApiBank.GetRate(Currency);
        }
    }
}
