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
        private List<Property> properties;

        public Trade(int money, List<Property> properties)
        {
            this.money = money;
            this.properties = properties;
        }


        public int Money{ get { return money; } }
        public List<Property> Properties { get { return properties; } }
        public void addProperty(Property property)
        {
             properties.Add(property);
        }
        public void removeProperty(Property property)
        {
            Properties.Remove(property);
        }
    }
}
