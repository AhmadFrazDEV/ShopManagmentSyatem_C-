using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using coffe_shop.folder.BL;
using System.Threading.Tasks;

namespace coffe_shop11.folder.BL
{
    internal class coffe_shop_bl
    {
        public string shop_name = "";
          private string order ;

        public string getorder() { return order; }
        public void setorder(string order) { this.order = order; }

        public coffe_shop_bl()
        {

        } 
        public coffe_shop_bl(string shop_name,string order)
        {
            this.order = order; 
        }
       
    }
}
