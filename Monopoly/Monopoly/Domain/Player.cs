using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Player
    {
        private String name;
        private int balance = 1500;
        private List<Property> properties;
        private bool jailed = false;

        public Player (String name) {
            this.name = name; 
        }

        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public int getBalance()
        {
            return balance;
        }

    }
}
