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

        public void addProperty(Property property)
        {
            properties.Add(property);
        }

        public List<Property> getProperties()
        {
            return properties;
        }

        public String printProperties()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Property property in properties)
            {
                sb.Append(property);
            }
            return sb.ToString();
        }

        public void setJailed(bool active)
        {
            this.jailed = active;
        }

        public String getName()
        {
            return this.name;
        }
    }
}
