using Program.Interfaces;
using Program.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    abstract class Currency:IBank
    {
        private double rateOfCurrency;

        public abstract double GetRateFromApi(string Currency);
        //{
        //    return ApiBank.GetRate(Currency);
        //}
        //    we need this as abstract if we want smth to be different for each currency
        //    for example a commision fee


        public Currency(string Currency)
        {
            rateOfCurrency = GetRateFromApi(Currency);

        }

        public double ReturnRateFromApi()
        {
            return rateOfCurrency;
        }


    }
}
