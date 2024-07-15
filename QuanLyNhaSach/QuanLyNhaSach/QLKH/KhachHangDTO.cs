using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.QLKH
{
    internal class KhachHangDTO
    {
        string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        string Email;

        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }
        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        string soDT;

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public KhachHangDTO() 
        {
            
        }
        public KhachHangDTO(string maKH, string hoTen, string email1, string diaChi, string soDT)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.Email1 = email1;
            this.diaChi = diaChi;
            this.soDT = soDT;
        }
    }
}
