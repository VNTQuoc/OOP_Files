using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_HangThucPham
{
    public class Hangthucpham
    {
        static void Main(string[] args)
        {
            HangThucPham o1 = new HangThucPham("001", "Gao", 100000, new DateTime(2019, 7, 10), new DateTime(2020, 8, 9));
            HangThucPham o2 = new HangThucPham("002", "Mi", 5000, new DateTime(2019, 3, 1), new DateTime(2022, 9, 1));
            HangThucPham o3 = new HangThucPham("003", "Nuoc", 10000, new DateTime(2020, 3, 1), new DateTime(2020, 3, 6));
            Console.WriteLine("{0} \t{1} \t{2} \t\t{3} \t\t{4} \t\t{5}\n", "Ma_Hang", "Ten_Hang", "Don_Gia", "Ngay_San_Xuat", "Ngay_Het_Han", "Ghi_Chu");
            Console.WriteLine(o1.toString());
            Console.WriteLine(o2.toString());
            Console.WriteLine(o3.toString());
        }
    }
  
}
