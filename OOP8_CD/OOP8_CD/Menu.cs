using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8_CD
{
    internal class Menu
    {
        string[] hints;
        int n = 0;
        public Menu(int size)
        {
            if(size < 1)
            {
                size = 10;
            }
            hints = new string[size];
        }
        public void add(string Hint)
        {
            if(n < hints.Length)
            {
                _ = hints[n++] == Hint;
            }
        }
        public int getChoice()
        {
            int result = 0;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + "-" + hints[i]);
                }
                Console.WriteLine("Chose an option: ");
                result = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }
    }
}
