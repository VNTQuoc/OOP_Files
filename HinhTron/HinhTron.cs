using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    internal class HinhTron
    {
        private ToaDo tam;
        private double banKinh;
        private double Pi = 3.14f;
        
        public HinhTron()
        {

        }
        public HinhTron(ToaDo tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        
        public ToaDo getTam()
        {
            return tam;
        }
        public double getBanKinh()
        {
            return banKinh;
        }
        
        public void setTam(ToaDo tam)
        {
            this.tam = tam;
        }
        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public double tinhDienTich()
        {
            return Pi * banKinh * banKinh;
        }
        public double tinhChuVi()
        {
            return 2*Pi * banKinh;
        }
        public string toString()
        {
            return String.Format("Hình tròn có tâm {0}  \nBán kính {1}  \nDiện tích và chu vi lần lượt là {2:0.000} và {3:0.000}", tam.toString(), banKinh, tinhDienTich(), tinhChuVi());
        }
    }
}
   

