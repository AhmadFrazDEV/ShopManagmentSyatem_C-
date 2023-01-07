using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using coffe_shop11.folder.BL;
using System.Threading.Tasks;

namespace coffe_shop.folder.UI
{
    internal class coffe_shop_ui
    { 
        
        public static coffe_shop_bl take_orders()
        {

            coffe_shop_bl data = new coffe_shop_bl();
            WriteLine("ENTER NAME OF ITEM");
            string name= ReadLine();
            data.setorder(name);
            string shop = "Tesha";
            return data;
        }  
        
    }
}
