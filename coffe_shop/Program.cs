using System;
using static System.Console; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using coffe_shop.menu.UI;
using coffe_shop.folder.dl;
using System.Threading.Tasks;
using coffe_shop11.folder.BL;

namespace coffe_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\C# Projects\\VIVA\\shop\\Data.txt";
            if(class_item_dl.readDataFromFile(path))
            {
                WriteLine("Successfully Read");
            }
            int op = 0;
            do
            {
                op = MENU_UI.menu();
                if (op == 1)
                {
                    
                    class_item_dl.add_in_list();
                    class_item_dl.addDataIntoFile(path);

                }
                else if (op == 2)
                {
                    class_item_dl.cheapest_item();
                }
                else if (op == 3)
                {
                    class_item_dl.drink_menu();
                }
                else if (op == 4)
                {
                    class_item_dl.food_menu();
                }
                else if (op == 5)
                {
                    class_item_dl.show_items();
                    WriteLine();
                    coffe_shop_dl.orders_in_list();

                }
                else if (op == 6)
                {
                    coffe_shop_dl.fullfill_order();
                }
                else if (op == 7)
                {
                    coffe_shop_dl.orders_added();
                }
                else if (op == 8)
                {
                    float result = coffe_shop_dl.calculte_bill();
                    WriteLine("YOUR BILL IS =" + result);
                }
                ReadKey();
                Clear();
            }
            while (op != 9);


        }
    }
}
