using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Trade
    {
        private int money;
        private Property properties;

        public Trade(int money, Property properties)
        {
            this.money = money;
            this.properties = properties;
        }
    }
}
