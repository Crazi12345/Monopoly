using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Auction
    {
        private Property auctionItem;
        private string auctionName;
        private int bid;
        private int startingBid;

        public Auction(Property auctionItem, string auctionName, int startingBid)
        {
            this.auctionItem = auctionItem;
            this.auctionName = auctionName;
            this.startingBid = startingBid;
        }





        public int getBid()
        {
            return bid;
        }
        public void setBid(int newBid) { bid = newBid; }
    }
}
