using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffe_shop.folder.BL
{
    internal class class_item_bl
    {
        private string name;
        private string item_type;
        private int price;

        public string getname() { return name; }
        public void setname(string name) { this.name = name; }

        public string getitem_type() { return item_type; }
        public void setitem_type(string item_type) { this.item_type = item_type; }

        public int getprice() { return price; }
        public void setprice(int price) { this.price = price; }

        public  class_item_bl()
        {

        } 

        public class_item_bl(string name , string type , int price)
        {
            this.name = name;
            item_type = type;
            this.price = price;
        }
      
    }
}
