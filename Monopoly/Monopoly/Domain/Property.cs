using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal abstract class Property
    {
        private string name;
        private int price;
        private int pawnPrice;
        private Player owner = null;
        private bool owned = false;

        public Property(string name, int price, int pawnPrice)
        {
            this.name = name;
            this.price = price;
            this.pawnPrice = pawnPrice;
        }

        public void setOwner(Player owner)
        {
            if (!owned)
            {
                this.owner = owner;
                owned = true;
            }
            else
            {
                Console.WriteLine("This property is owned by " + this.owner.getName);
            }
        }

        public void changeOwner(Player player)
        {
           
        }

        public Player getOwner()
        {
            return owner;
        }

        public int getPrice()
        {
            return price;
        }

        public int getPawnPrice()
        {
            return pawnPrice;
        }

    }
}
