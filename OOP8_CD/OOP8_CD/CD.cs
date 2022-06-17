using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_CD
{
    internal class CD
    {
        private int ID;
        private string Name;
        private int Numberofsongs;
        private double Price;

        public CD()
        {

        }
        public CD(int ID, string Name, int Numberofsongs, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Numberofsongs = Numberofsongs;
            this.Price = Price;
        }
        public int getID()
        {
            return ID;
        }
        public string getName()
        {
            return Name;
        }
        public int getNumbers()
        {
            return Numberofsongs;
        }
        public double getPrice()
        {
            return Price;
        }
        public void setID()
        {
            this.ID = ID;
        }
        public void setName()
        {
            this.Name = Name;
        }
        public void setNumbers()
        {
            this.Numberofsongs = Numberofsongs;
        }
        public void setPrice()
        {
            this.Price = Price;
        }
        public string toString()
        {
            return String.Format("{0} | {1} | {2} | {3}", ID, Name, Numberofsongs, Price);
        }
    }
}
