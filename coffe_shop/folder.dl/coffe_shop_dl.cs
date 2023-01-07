using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using coffe_shop.folder.UI;
using coffe_shop.folder.BL;
using coffe_shop11.folder.BL;
using System.Threading.Tasks;

namespace coffe_shop.folder.dl
{
    internal class coffe_shop_dl
    {
        public static coffe_shop_bl data1 = new coffe_shop_bl();
        public static List<coffe_shop_bl> do_orders = new List<coffe_shop_bl>();


        public static void orders_in_list()
        {
            bool flag = false;
            data1 = coffe_shop_ui.take_orders();

            for (int i = 0; i < class_item_dl.items_data.Count; i++)
            {
                if (data1.getorder() == class_item_dl.items_data[i].getname())
                {
                    WriteLine("YES! THIS ITEM EXISTS IN THE MENU");
                    do_orders.Add(data1);
                    flag = true;
                    break;
                }

            }
            if (flag == false)
            {
                WriteLine("not exists");
            }
        }
        public static void fullfill_order()
        {
            for (int i = 0; i < do_orders.Count; i++)
            {
                WriteLine("your " + do_orders[i].getorder() + " is ready ! ");
            }
        }
        public static void orders_added()
        {
            WriteLine("\tYOUR ORDERS NAME ARE......");
            for (int i = 0; i < do_orders.Count; i++)
            {

                WriteLine(do_orders[i].getorder());

            }
        }
        public static float calculte_bill()
        {
            int bill = 0;
            for (int i = 0; i < class_item_dl.items_data.Count; i++)
            {
                if (do_orders[i].getorder() == class_item_dl.items_data[i].getname())
                {
                    bill = bill + class_item_dl.items_data[i].getprice();
                }
            }
            return bill;

        }
    }
}
