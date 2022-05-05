using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Domain
{
    internal class Street : Property
    {
        private int rent;
        private int houses = 0;



        public Street(string name, int price, int pawnPrice, int rent) : base(name, price, pawnPrice)
        {
            this.rent = rent;
        }


    }
}
