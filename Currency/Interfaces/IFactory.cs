using Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Interfaces
{
    internal interface IFactory
    {
        public Currency CreateCurrency(string Currency);
    }
}
