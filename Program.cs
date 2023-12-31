namespace Bai21_Project_thuc_te
{
    public class Program
    {
        List<NhanVien> dsNV = new List<NhanVien>();
        List<PhongBan> dsPB = new List<PhongBan>();

        public void HienThi()
        {
            Console.WriteLine("\nPhong Ban: ");
            foreach (var v in dsPB)
            {
                Console.WriteLine(v.mpb + "\t" + v.tenPb);
            }
            Console.WriteLine("\nNhan Vien: ");
            foreach (var nv in dsNV)
            {
                Console.WriteLine(nv.ToString());
            }
        }
        public void Them()
        {
            PhongBan phongBan = new PhongBan();
            NhanVien nhanVien = new NhanVien();
            while (true)
            {
                Console.WriteLine("a. Them phong ban\n" +
                                  "b. Them nhan vien");
                string s = Console.ReadLine();
                if (s == "a")
                {
                    phongBan.Them();
                    foreach (var v in dsPB)
                    {
                        if ((v.mpb).Equals(phongBan.mpb) || (v.tenPb).Equals(phongBan.tenPb))
                        {
                            Console.WriteLine("Phong ban da ton tai");
                            return;
                        }
                    }
                    dsPB.Add(phongBan);
                    foreach (var v in dsPB)
                    {
                        Console.WriteLine(v.mpb + "\t" + v.tenPb);
                    }
                    break;
                }
                else if (s == "b")
                {
                    nhanVien.Them(phongBan);
                    PhongBan pb = dsPB.Find(p => p.mpb.Equals(phongBan.mpb));
                    if (pb == null)
                    {
                        Console.WriteLine("Phong ban khong ton tai");
                    }
                    else
                    {
                        Console.WriteLine("Nhap ma nhan vien: ");
                        nhanVien.mnv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap ten nhan vien: ");
                        nhanVien.tenNv = Console.ReadLine();
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Nhap ngay sinh: ");
                                nhanVien.ngaySinh = DateTime.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Nhap dung dinh dang ngay sinh");
                            }
                        }
                        Console.WriteLine("Nhap chuc vu: ");
                        nhanVien.chucVu = Console.ReadLine();
                        foreach (var nv in dsNV)
                        {
                            if ((nv.mnv).Equals(nhanVien.mnv))
                            {
                                Console.WriteLine("Nhan vien da ton tai");
                                return;
                            }
                        }
                        nhanVien.phongBan = pb;
                        dsNV.Add(nhanVien);
                    }
                    foreach (var nv in dsNV)
                    {
                        Console.WriteLine(nv.ToString());
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Nhap a hoac b");
                }
            }

        }
        public void SuaPhongBan(int mpb)
        {
            PhongBan pb = dsPB.Find(p => p.mpb.Equals(mpb));
            if (pb == null)
            {
                Console.WriteLine("Phong ban khong ton tai");
            }
            else
            {
                Console.WriteLine("Nhap ten phong ban moi: ");
                pb.tenPb = Console.ReadLine();
            }
        }
        public void SuaNhanVien(int mnv)
        {
            NhanVien nv = dsNV.Find(n => n.mnv.Equals(mnv));
            if (nv == null)
            {
                Console.WriteLine("Nhan vien khong ton tai");
            }
            else
            {
                Console.WriteLine("Nhap ten moi: ");
                nv.tenNv = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Nhap ngay sinh moi: ");
                        nv.ngaySinh = DateTime.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nhap dung dinh dang ngay sinh");
                    }
                }
                Console.WriteLine("Nhap chuc vu moi: ");
                nv.chucVu = Console.ReadLine();
                Console.WriteLine("Nhap phong ban moi: ");
                nv.phongBan.tenPb = Console.ReadLine();
                foreach (var Nv in dsNV)
                {
                    Console.WriteLine(Nv.ToString());
                }
            }
        }
        public void XoaPhongBan(int mpb)
        {
            PhongBan pb = dsPB.Find(p => p.mpb.Equals(mpb));
            if (pb == null)
            {
                Console.WriteLine("Phong ban khong ton tai");
            }
            else
            {
                dsPB.Remove(pb);
                Console.WriteLine("Xoa thanh cong");
            }
        }
        public void XoaNhanVien(int mnv)
        {
            NhanVien nv = dsNV.Find(n => n.mnv.Equals(mnv));
            if (nv == null)
            {
                Console.WriteLine("Nhan vien khong ton tai");
            }
            else
            {
                dsNV.Remove(nv);
                Console.WriteLine("Xoa thanh cong");
            }
        }
        public int SoSanhMpb(PhongBan x, PhongBan y)
        {
            return x.mpb.CompareTo(y.mpb);
        }
        public int SoSanhMnv(NhanVien x, NhanVien y)
        {
            return x.mnv.CompareTo(y.mnv);
        }
        public void SapXep()
        {
            dsPB.Sort(SoSanhMpb);
            dsNV.Sort(SoSanhMnv);
            Console.WriteLine("Phong ban sau sap xep: ");
            foreach (var pb in dsPB)
            {
                Console.WriteLine(pb.mpb + "\t" + pb.tenPb);
            }
            Console.WriteLine("\nNhan vien sau sap xep: ");
            foreach (var nv in dsNV)
            {
                Console.WriteLine(nv.ToString());
            }
        }
        public void TimKiemPhongBan(int mpb)
        {
            PhongBan pb = dsPB.Find(p => p.mpb.Equals(mpb));
            if (pb == null)
            {
                Console.WriteLine("Phong ban khong ton tai");
            }
            else
            {
                Console.WriteLine(pb.mpb+"\t" + pb.tenPb);
            }
        }
        public void TimKiemNhanVien(int mnv)
        {
            NhanVien nv = dsNV.Find(n => n.mnv.Equals(mnv));
            if (nv == null)
            {
                Console.WriteLine("Nhan vien khong ton tai");
            }
            else
            {
                Console.WriteLine(nv.ToString());
            }
        }
        public void TinhLuong(int mnv)
        {
            NhanVien nv = dsNV.Find(NV => NV.mnv.Equals(mnv));
            if (nv == null)
            {
                Console.WriteLine("Khong ton tai nhan vien");
            }
            else
            {
                Console.WriteLine("Luong cua nhan vien {0} la: {1} trieu VND", nv.tenNv, nv.TinhLuong());
            }
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                Console.Write("Menu: \n" +
                "1. Them phong ban, nhan vien\n" +
                "2. Sua\n" +
                "3. Xoa\n" +
                "4. Hien thi\n" +
                "5. Sap xep\n" +
                "6. Tim kiem\n" +
                "7. Thong ke luong\n" +
                "8. Thoat\n" +
                "Nhap lua chon: ");
                int chon = int.Parse(Console.ReadLine());
                string nhap;
                switch (chon)
                {
                    case 1:
                        p.Them();
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("a. Sua Phong Ban\n" +
                            "b. Sua Nhan Vien");
                            nhap = Console.ReadLine();
                            if (nhap == "a")
                            {
                                Console.WriteLine("Nhap ma phong ban: ");
                                int mpb1 = int.Parse(Console.ReadLine());
                                p.SuaPhongBan(mpb1);
                                break;
                            }
                            else if (nhap == "b")
                            {
                                Console.WriteLine("Nhap ma nhan vien: ");
                                int mnv1 = int.Parse(Console.ReadLine());
                                p.SuaNhanVien(mnv1);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nhap a hoac b");
                            }
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("a. Xoa Phong Ban\n" +
                                "b. Xoa Nhan Vien");
                            nhap = Console.ReadLine();
                            if (nhap == "a")
                            {
                                Console.WriteLine("Nhap ma phong ban: ");
                                int mpb2 = int.Parse(Console.ReadLine());
                                p.XoaPhongBan(mpb2);
                                break;
                            }
                            else if (nhap == "b")
                            {
                                Console.WriteLine("Nhap ma nhan vien: ");
                                int mnv2 = int.Parse(Console.ReadLine());
                                p.XoaNhanVien(mnv2);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nhap a hoac b");
                            }
                        }
                        break;
                    case 4:
                        p.HienThi();
                        break;
                    case 5:
                        p.SapXep();
                        break;
                    case 6:
                        while (true)
                        {
                            Console.WriteLine("a. Tim Phong Ban\n" +
                            "b. Tim Nhan Vien");
                            nhap = Console.ReadLine();
                            if (nhap == "a")
                            {
                                Console.WriteLine("Nhap ma phong ban: ");
                                int mpb3 = int.Parse(Console.ReadLine());
                                p.TimKiemPhongBan(mpb3);
                                break;
                            }
                            else if (nhap == "b")
                            {
                                Console.WriteLine("Nhap ma nhan vien: ");
                                int mnv3 = int.Parse(Console.ReadLine());
                                p.TimKiemNhanVien(mnv3);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nhap a hoac b");
                            }
                        }
                        break;
                    case 7: 
                        Console.WriteLine("Nhap ma nhan vien: ");
                        int mnv4 = int.Parse(Console.ReadLine());
                        p.TinhLuong(mnv4);
                        break;
                }
                Console.WriteLine("Nhan phim bat ky de tiep tuc hoac phim 1 de dung: ");
                string bam = Console.ReadLine();
                if (bam == "1")
                {
                    break;
                }
            }
        }
    }
}

