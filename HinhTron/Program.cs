using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    internal class Hinhtron
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HinhTron hinhTron = new HinhTron(new ToaDo("O", 5, 5), 10.5);
            Console.WriteLine(hinhTron.toString());
        }
    }
}