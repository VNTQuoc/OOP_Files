using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_CD
{
    internal class CDlist
    {
        private CD[] list = null;
        private int count = 0;
        public CDlist(int size)
        {
            if(size < 10)
            {
                size = 10;
            }
            list = new CD[size];
        }
        int findCD(int CDid)
        {
            for(int i = 0; i < count; i++)
            {
                if(CDid.Equals(list[i].getID()))
                {
                    return i;
                }
            }
            return -1;
        }
        public void addCD()
        {
            if (count == list.Length)
            {
                Console.WriteLine("List is full!");
            }
            else
            {
                int newID;
                string newName;
                int newNumberofsongs;
                double newPrice;
                int pos;
                do
                {
                    Console.WriteLine("Type the ID of CD: ");
                    newID = Convert.ToInt32(Console.ReadLine());
                    pos = findCD(newID);
                    if (pos >= 0)
                    {
                        Console.WriteLine("The ID is already existed!");

                    }
                } while (pos >= 0);

                Console.WriteLine("Type the Name of CD: ");
                newName = Console.ReadLine();
                Console.WriteLine("Number of songs: ");
                newNumberofsongs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the price: ");
                newPrice = Convert.ToDouble(Console.ReadLine());
                list[count++] = new CD(newID, newName, newNumberofsongs, newPrice);
                Console.WriteLine("New CD has been added!");
            }

        }
        public void addCD(CD cD)
        {
            this.list[count++] = cD;
        }
        public void countCD()
        {
            Console.WriteLine("The list have " + count.ToString() + " CD");
        }
        public double totalPrice()
        {
            double total = 0;
            for (int i = 0; i < count; i++)
            {
                total += list[i].getPrice();
            }
            return total;
        }
        public void printCDlist()
        {
            if (count == 0)
            {
                Console.WriteLine("IT is empty!");
                return;
            }
            else
            {
                Console.WriteLine("The list: ");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
        }
        public void Pricemanagement()
        {
            if (count == 0)
            {
                return;
            }
            for(int i = 0; i < count; i++)
            {
                for(int j = count - 1; j > i; j--)
                {
                    if (list[j].getPrice() > list[i].getPrice())
                    {
                        CD a = this.list[j];
                        this.list[j] = this.list[i];
                        this.list[i] = a;
                    }
                }
            }
        }
        public void Namemanagement()
        {
            if (count == 0)
            {
                return;

            }
            for (int i = 0; i < count; i++)
            {
                for(int j = count - 1; j > i; j--)
                {
                    if (string.Compare(list[i].getName(), list[j].getName()) == 1)
                    {
                        CD a = this.list[j];
                        this.list[j] = this.list[i];
                        this.list[i] = a;
                    }
                }
            }
        }
     
            
    }
}

