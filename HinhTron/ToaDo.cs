using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    internal class ToaDo
    {
        private string name;
        private float x;
        private float y;
        //constructor
        public ToaDo()
        {

        }
        public ToaDo(string ten, float x, float y)
        {
            this.name = ten;
            this.x = x;
            this.y = y;
        }
        
        public float getX()
        {
            return x;
        }
        public float getY()
        {
            return y;
        }
        
        public void setX()
        {
            this.x = x;
        }
        public void setY()
        {
            this.y = y;
        }
        public string toString()
        {
            return String.Format("{0}({1},{2})", name, x, y);
        }
    }
}
    

