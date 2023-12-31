using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bai21_Project_thuc_te.Program;

namespace Bai21_Project_thuc_te
{
    public class PhongBan
    {
        public int mpb { get; set; }
        public string tenPb { get; set; }
        public NhanVien tenTp { get; set; }
        public PhongBan() { }
        public PhongBan(int mpb, string tenPb, NhanVien tenTp)
        {
            this.mpb = mpb;
            this.tenPb = tenPb;
            this.tenTp = tenTp;
        }
        public void Them()
        {
            Console.WriteLine("Nhap ma phong ban: ");
            mpb = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten phong ban: ");
            tenPb = Console.ReadLine();
        }
    }
}
