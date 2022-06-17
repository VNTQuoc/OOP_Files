using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_CD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu menu = new Menu(7);
            
            menu.add("Add an CD to the list");
            menu.add("Count number of CDs in the list");
            menu.add("Total price of CDs");
            menu.add("Information all of CDs that are in the list");
            menu.add("Management due to the price(Max -> Min)");
            menu.add("Management due to the Name(Min -> Max)");

            int option;
            CDlist list = new CDlist(60);
            list.addCD(new CD(001, "Save your tear", 9, 1500000));
            list.addCD(new CD(002, "Circle", 12, 1200000));
            list.addCD(new CD(003, "C.R.E.A.M", 15, 1750000));
            list.addCD(new CD(004, "Swimming pool", 20, 1300000));
            do
            {
                Console.WriteLine("\nCD");
                option = menu.getChoice();
                switch (option)
                {
                case 1:

                    list.addCD();
                    break;
                case 2:
                        list.countCD();
                        break;
                    case 3:
                        Console.WriteLine("Total price os CDs is: " + list.totalPrice());
                        break;
                    case 4:
                        list.printCDlist();
                        break;
                    case 5:
                        list.Pricemanagement();
                        list.printCDlist();
                        break;
                    case 6:
                        list.Namemanagement();
                        list.printCDlist();
                        break;


                }

            }
            while (option >= 1 && option < 7);
        }
    }
}