using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using coffe_shop.folder.BL;
using System.Threading.Tasks;

namespace coffe_shop.folder.UI
{
    internal class class_item_ui
    {
        public static class_item_bl add_items()
        {
            class_item_bl data = new class_item_bl();
            Write("enter name of item: ");
            string name = ReadLine();
            data.setname(name);

            Write("enter item type: ");
            string item_type = ReadLine();
            data.setitem_type(item_type);

            Write("enter price of item: ");
            int price = int.Parse(ReadLine());
            data.setprice(price);

           return data;
        } 
        

    }
}
