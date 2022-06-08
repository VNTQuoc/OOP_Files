using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_HangThucPham
{
    public class HangThucPham
    {
        private string maHang;
        private string tenHang;
        private long donGia;
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;
        
        public HangThucPham(string mahang)
        {
            this.maHang = mahang;
        }
        
        public HangThucPham(string mahang, string tenhang, long dongia, DateTime ngaysanxuat, DateTime ngayhethan)
        {
            this.setMaHang(mahang);
            this.setTenHang(tenhang);
            this.setDonGia(dongia);
            this.ngaySanXuat = ngaysanxuat;
            this.setNgayHetHan(ngayhethan);
        }
        
        public string getMaHang()
        {
            return maHang;
        }
        public string getTenHang()
        {
            return tenHang;
        }
        public long getDonGia()
        {
            return donGia;
        }
        public DateTime getNgaySanXuat()
        {
            return ngaySanXuat;
        }
        public DateTime getNgayHetHan()
        {
            return ngayHetHan;
        }
        
        public void setTenHang(string tenhang)
        {
            if (tenhang.Trim().Length == 0)
            {
                this.tenHang = "xxx";
            }
            else
            {
                this.tenHang = tenhang;
            }
        }
        public void setDonGia(long dongia)
        {
            if (dongia < 0)
            {
                this.donGia = 0;
            }
            else
            {
                this.donGia = dongia;
            }
        }
        public void setNgaySanXuat(DateTime ngaysanxuat)
        {
            int result = DateTime.Compare(this.ngaySanXuat, DateTime.Now);
            if (result > 0)
            {
                this.ngaySanXuat = DateTime.Now;
            }
            else
            {
                this.ngaySanXuat = ngaysanxuat;
            }
        }
        public void setNgayHetHan(DateTime ngayhethan)
        {
            int result = DateTime.Compare(this.ngayHetHan, this.ngaySanXuat);
            if (result < 0)
            {
                this.ngayHetHan = this.ngaySanXuat;
            }
            else
            {
                this.ngayHetHan = ngayhethan;
            }
        }
        private void setMaHang(string mahang)
        {
            if (!String.Equals(mahang.Trim(), ""))
            {
                this.maHang = mahang;
            }
            else throw new Exception("Loi: Ma hang rong!");
        }
        public string checkHetHan()
        {
            int result = DateTime.Compare(this.ngayHetHan, DateTime.Now);
            return result < 0 ? "Hang het han" : "";
        }
        public string toString()
        {
            return String.Format("{0} \t\t{1} \t\t{2} \t\t\t{3} \t\t{4} \t\t{5}\n", this.maHang, this.tenHang, this.donGia, this.ngaySanXuat.ToString("dd/MM/yyyy"), this.ngayHetHan.ToString("dd/MM/yyyy"), this.checkHetHan());
        }
    }
}
    

