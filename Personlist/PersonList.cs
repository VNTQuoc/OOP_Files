using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlist
{
    public class PersonList
    {
        private Person[] list = null;
        private int count = 0;
        public PersonList(int size)
        {
            if (size < 10)
            {
                size = 10;
            }
            list = new Person[size];
        }
        int find(string pID)
        {
            for(int i = 0; i < count; i++)
            {
                if (pID.Equals(list[i].getID()));
                {
                    return i;
                }
            }
            return -1;
        }
        public void add()
        {
            if (count == list.Length)
            {
                Console.WriteLine("List is full: ");
            }
            else
            {
                int newID;
                string newName;
                int newAge;

                int pos;
                do
                {
                    Console.WriteLine("Person's ID: ");
                    newID = Convert.ToInt32(Console.ReadLine());
                    pos = find(newID);
                    if(pos >= 0)
                    {
                        Console.WriteLine("The ID is existed!");
                    }
                }while(pos >= 0);
                Console.WriteLine("Person's Name: ");
                newName = Console.ReadLine();
                Console.WriteLine("Age: ");
                newAge = Convert.ToInt32(Console.ReadLine());
                list[count++] = new Person(newID, newName, newAge);
                Console.WriteLine("New person has been added!");
                

            }
        }

        private int find(int newID)
        {
            throw new NotImplementedException();
        }

        public void remove()
        {
            if(count == 0)
            {
                Console.WriteLine("The list is empty!");
                return;
            }
            string removeID;
            Console.WriteLine("Enter the code of removed person: ");
            removeID = Console.ReadLine().ToUpper();
            int pos = find(removeID);
            if (pos < 0)
            {
                Console.WriteLine("This person does not exist.");
            }
            else
            {
                for (int i = pos; i < count - 1; i++)
                {
                    list[i] = list[i + 1];
                    count--;
                }
                Console.WriteLine("The person " + removeID + " was removed");
            }

        }
        public void update()
        {
            if (count == 0)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            string code;
            Console.WriteLine("Enter the code of updated person: ");
            code = Console.ReadLine().ToUpper();
            int pos = find(code);
            if (pos < 0)
            {
                Console.WriteLine("This person does not exist.");
            }
            else
            {
                string newName;
                int newAge;
                Console.WriteLine("Enter the person's name: ");
                newName = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter the person's age: ");
                newAge = Convert.ToInt32(Console.ReadLine());
                list[pos].setName(newName);
                list[pos].setAge(newAge);
                Console.WriteLine("The person " + code + " was updated");
            }
        }
        public void print()
        {
            if (count == 0)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            else
            {
                Console.WriteLine("LIST OF PERSONS:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(list[i].toString());
                }
            }
        }
        public void sort()
        {
            if (count == 0)
            {
                return;
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = count - 1; j < i; j--)
                {
                    if (list[j].getAge() > list[j - 1].getAge())
                    {
                        Person p = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = p;
                    }
                }
            }
        }
    }
}


