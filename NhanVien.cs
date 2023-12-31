using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_Project_thuc_te
{
    public class NhanVien
    {
        public int mnv { get; set; }
        public string tenNv { get; set; }
        public DateTime ngaySinh { get; set; }
        public string chucVu { get; set; }
        public PhongBan phongBan { get; set; }
        public void Them(PhongBan phongBan)
        {
            Console.WriteLine("\nThem Nhan Vien");
            Console.WriteLine("Nhap ma phong ban: ");
            phongBan.mpb = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            string tenPb = phongBan != null ? phongBan.tenPb : "Không xác định";
            return $"Mnv: {this.mnv}\nTen nv: {this.tenNv}\nNgay sinh: {this.ngaySinh.ToString("dd/MM/yyyy")}\nChuc vu: {this.chucVu}\nPhong ban: {tenPb}\n";
        }
        public double TinhLuong()
        {
            if(chucVu == "Giam doc".ToLower())
            {
                return 10 + (10 * 0.25);
            }else if(chucVu == "Truong phong".ToLower())
            {
                return 10 + (10 * 0.15);
            }else if(chucVu == "Pho phong".ToLower())
            {
                return 10 + (10 * 0.05);
            }
            return 10;
        }
    }
}
