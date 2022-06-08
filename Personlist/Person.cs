using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personlist
{
    public class Person
    {
        private int ID;
        private string Name;
        private int Age;

        public Person()
        {

        }
        public Person(int iD, string name, int age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
        public int getID()
        {
            return ID;
        }
        public string getName()
        {
            return Name;
        }
        public int getAge()
        {
            return Age;
        }
        public void setID(string code)
        {
            this.ID = ID;
        }
        public void setName(string name)
        {
            this.Name = Name;
        }
        public void setAge(int age)
        {
            this.Age = Age;
        }
        public void input()
        {
            Console.WriteLine("Person's ID please: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person's Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public string toString()
        {
            return this.ID + ", " + this.Name + ", " + this.Age;
        }

    }

}
