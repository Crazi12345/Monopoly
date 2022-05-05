using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Domain
{
    internal class Railway : Property
    {
        private int rent;

        public Railway(string name, int price, int pawnPrice) : base(name, price, pawnPrice)
        {
            price = 200;
            pawnPrice = 100;
        }

        
        public int rentPayment()
        {
            if (getOwner() != null)
            {
                //Land on railway: Check owner, then check owner's inventory
            }
            return rent;
        }
    }
}
