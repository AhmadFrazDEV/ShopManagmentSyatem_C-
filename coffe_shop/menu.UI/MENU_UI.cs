using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffe_shop.menu.UI
{
    internal class MENU_UI
    {
       
        public static int menu()
        {
           
            WriteLine();
           
            WriteLine();
            WriteLine("\t1.ADD A MENU ITEM ");
            WriteLine("\t2.View the Cheapest Item in the menu");
            WriteLine("\t3.View the Drink’s Menu");
            WriteLine("\t4.View the Food’s Menu");
            WriteLine("\t5.Add Order");
            WriteLine("\t6.Fulfill the Order");
            WriteLine("\t7.View the Orders’s List");
            WriteLine("\t8.Total Payable Amount");
            WriteLine("\t9.Exit");
            WriteLine();
            Write("enter option number:");
            int num = int.Parse(ReadLine());
            return num;
        }

    }
}
