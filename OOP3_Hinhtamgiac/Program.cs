using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP3_Hinhtamgiac
{
    public class HinhTamGiac
    {
        static void Main(string[] args)
        {
            Hinhtamgiac hinh1 = new Hinhtamgiac(3, 5, 7);
            Hinhtamgiac hinh2 = new Hinhtamgiac(2, 3, 4);
            Hinhtamgiac hinh3 = new Hinhtamgiac(2, 3, 2);
            Hinhtamgiac hinh4 = new Hinhtamgiac(-2, -2, 3);
            Hinhtamgiac hinh5 = new Hinhtamgiac(5, 5, 5);
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \t\t{4} \t\t{5}", "Canh ma", "Canh mb", "Canh mc", "Kieu tam giac", "Chu vi", "Dien Tich");
            hinh1.HienthiHinhTamGiac();
            hinh2.HienthiHinhTamGiac();
            hinh3.HienthiHinhTamGiac();
            hinh4.HienthiHinhTamGiac();
            hinh5.HienthiHinhTamGiac();
        }
    }
}