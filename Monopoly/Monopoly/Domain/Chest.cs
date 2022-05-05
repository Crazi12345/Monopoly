using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Chest
    {
        private string text;
        private int amount;

        public Chest(string text, int amount)
        {
            this.text = text;
            this.amount = amount;
        }
    }
}
