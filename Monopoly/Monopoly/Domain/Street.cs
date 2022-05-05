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
        private int oneHouseRent;
        private int twoHouseRent;
        private int threeHouseRent;
        private int fourHouseRent;
        private int hotelRent;
        private int houses = 0;
        private int hotel = 0;
        private int housePrice;

        public Street(string name, int price, int pawnPrice, int rent) : base(name, price, pawnPrice)
        {
            this.rent = rent;
        }

        public void buildHouse()
        {
            if (houses < 4 && hotel ==0)
            {
                houses++;
                getOwner().setBalance(getOwner().getBalance() - this.housePrice);
            }

        }

        public void sellHouse()
        {
            if (houses > 0)
            {
                houses--;
                getOwner().setBalance(getOwner().getBalance() + this.housePrice / 2);
            } else
            {
                Console.WriteLine("You do not own a house here");
            }
        }

        public void buildHotel()
        {
            if (houses == 4)
            {
                hotel = 1;
                getOwner().setBalance(getOwner().getBalance() - this.housePrice);
                houses = 0;
            }
        }

        public int getRent()
        {
            if (this.houses == 1)
            {
                return this.oneHouseRent;
            } else if (this.houses == 2)
            {
                return this.twoHouseRent;
            } else if (this.houses == 3)
            {
                return this.threeHouseRent;
            } else if (this.houses == 4)
            {
                return this.fourHouseRent;
            } else if (this.hotel == 1)
            {
                return this.hotelRent;
            } else
            {
                return rent;
            }

        }


    }
}
