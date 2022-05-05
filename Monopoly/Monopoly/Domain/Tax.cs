using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Tax
    {
        private int taxAmount;
        private string name;
        public Tax(int taxAmount,string name)
        {
            this.taxAmount = taxAmount;
            this.name = name;
        }
    }
}
