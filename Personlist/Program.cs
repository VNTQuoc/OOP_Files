using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu(5);
            menu.add("Add new person");
            menu.add("Remove a person");
            menu.add("Changing Info of a person");
            menu.add("Show the list");
            menu.add("Exit");
            int choice;
            PersonList list = new PersonList(50);
            do
            {
                Console.WriteLine("\n____Menu____");
                choice = menu.getChoice();
                switch (choice)
                {
                    case 1:
                        list.add();
                        break;
                    case 2:
                        list.remove();
                        break;
                    case 3:
                        list.update();
                        break;
                    case 4:
                        list.sort();
                        list.print();
                        break;
                }
            }
            while (choice >= 1 && choice < 5);
        }
    }
}
