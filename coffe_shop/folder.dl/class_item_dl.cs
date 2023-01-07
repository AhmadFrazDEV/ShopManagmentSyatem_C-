using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using coffe_shop11.folder.BL;
using coffe_shop.folder.UI;
using coffe_shop.folder.BL;
using System.Threading.Tasks;

namespace coffe_shop.folder.dl
{
     class class_item_dl
    {
        
       public static coffe_shop_bl d = new coffe_shop_bl();
       public static List<class_item_bl> items_data = new List<class_item_bl>();
        public static List<class_item_bl> newListForReading = new List<class_item_bl>();
       public static class_item_bl s = new class_item_bl();
        public static void add_in_list()
        {
            items_data.Add(class_item_ui.add_items());
        }

        public static void  addDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            for (int i = 0; i < items_data.Count; i++)
            {
                file.WriteLine(items_data[i].getname() + "," + items_data[i].getitem_type() + "," + items_data[i].getprice());
                file.Flush();
            }
            file.Close();
        }
        
        public static bool readDataFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string P_name = splittedRecord[0];
                    string P_type = splittedRecord[1];
                    int P_price = int.Parse(splittedRecord[2]);
                    
                    class_item_bl s = new class_item_bl(P_name , P_type , P_price);
                    addIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void addIntoList(class_item_bl s)
        {
            newListForReading.Add(s);
        }

           public static void show_items()
           {
                WriteLine("NAME\t\tTYPE\t\tPRICE");
                foreach(class_item_bl s in items_data) 
                {
                    WriteLine(s.getname() + "\t\t" +s.getitem_type() + "\t\t" + s.getprice());
                }

           } 
        public static void cheapest_item()
        {
            WriteLine("NAME\t\tTYPE\t\tPRICE");
            for (int i = 0; i < items_data.Count; i++)
            {
                if (class_item_dl.items_data[i].getprice() < 200)
                {
                    WriteLine(class_item_dl.items_data[i].getname() + "\t\t" + class_item_dl.items_data[i].getitem_type() + "\t\t" + class_item_dl.items_data[i].getprice());
                }
            }
        }
        public static void drink_menu()
        {
            WriteLine("NAME\t\tTYPE\t\tPRICE");
            for (int i = 0; i <class_item_dl.items_data.Count; i++)
            {
                if (class_item_dl.items_data[i].getitem_type() == "drink")
                {
                    WriteLine(class_item_dl.items_data[i].getname() + "\t\t" + class_item_dl.items_data[i].getitem_type() + "\t\t" + class_item_dl.items_data[i].getprice());
                }
            } 
        } 
        public static void food_menu()
        {
            WriteLine("NAME\t\tTYPE\t\tPRICE");
            for (int i = 0; i < class_item_dl.items_data.Count; i++)
            {
                if (class_item_dl.items_data[i].getitem_type() == "food")
                {
                    WriteLine(class_item_dl.items_data[i].getname() + "\t\t" + class_item_dl.items_data[i].getitem_type() + "\t\t" + class_item_dl.items_data[i].getprice());
                }
            }
        } 
        



    }
 }
 