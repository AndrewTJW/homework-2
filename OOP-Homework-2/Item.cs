using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    internal class Item
    {
        private string itemname { get; set; }
        private int itemcount { get; set; }
        private double price { get; set; }

        private string itemID { get; set; }

        public Item(string a_itemname, int a_itemcount, double a_price, string a_itemID)
        {
            itemname = a_itemname;
            itemcount = a_itemcount;
            price = a_price;
            itemID = a_itemID;
        }

        public string getItemName()
        {
            return itemname;
        }
        public int getItemCount()
        {
            return itemcount;
        }
        public double getPrice ()
        {
            return price;
        }
        public string getItemID()
        {
            return itemID;
        }
    }
}
