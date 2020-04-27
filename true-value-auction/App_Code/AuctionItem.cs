using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace truevalueauction.App_Code
{

    public class AuctionItem
    {
        private string itemName;
        private string itemDesc;
        private double itemPrice;
        private int auctionLength;
        private string itemCondition;
        private string file;

        public AuctionItem()
        {
            this.itemName = "";
            this.itemDesc = "";
            this.itemPrice = 0;
            this.auctionLength = 0;
            this.itemCondition = "";
            this.file = "";
        }

        public AuctionItem(string itemName, string itemDesc, double itemPrice, int auctionLength, string itemCondition, string file)
        {
            this.itemName = itemName;
            this.itemDesc = itemDesc;
            this.itemPrice = itemPrice;
            this.auctionLength = auctionLength;
            this.itemCondition = itemCondition;
            this.file = file;
        }

        public void SetItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public void SetItemDesc(string itemDesc)
        {
            this.itemDesc = itemDesc;
        }

        public void SetItemPrice(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }

        public void SetItemCondition(string itemCondition)
        {
            this.itemCondition = itemCondition;
        }

        public void SetFile(string file)
        {
            this.file = file;
        }

        public void SetAuctionLength(int auctionLength)
        {
            this.auctionLength = auctionLength;
        }


        public string GetItemName()
        {
            return itemName;
        }

        public string GetItemDesc()
        {
            return itemDesc;
        }

        public double GetItemPrice()
        {
            return itemPrice;
        }

        public string GetItemCondition()
        {
            return itemCondition;
        }

        public string GetFile()
        {
            return file;
        }

        public int GetAuctionLength()
        {
            return auctionLength;
        }




    }
}