using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    class XuLyBenhNhan
    {
        private Dictionary<string, BenhNhan> dsbn;
        public XuLyBenhNhan()
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            dsbn = data.getDSbenhnhan();
        }
        public List<BenhNhan> getDSbenhnhan()
        {
            return dsbn.Values.ToList();
        }
        public BenhNhan tim(string mabn)
        {
            try
            {
                return dsbn[mabn];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool them(BenhNhan a)
        {
            try
            {
                dsbn.Add(a.Mabn, a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(string mabn)
        {
            return dsbn.Remove(mabn);
        }
        public bool sua(BenhNhan a)
        {
            BenhNhan b = tim(a.Mabn);
            if (b != null)
            {
                b.Hotenbn = a.Hotenbn;
                b.Diachi = a.Diachi;
                b.Sdt = a.Sdt;
                b.Cmnd = a.Cmnd;
                b.Phai = a.Phai;
                b.Ngaysinh = a.Ngaysinh;
                b.BenhAn = a.BenhAn;
                b.Suckhoe = a.Suckhoe;
                return true;
            }
            return false;
        }
    }
    class XuLyBacSi
    {
        private Dictionary<string, BacSi> dsbs;
        public XuLyBacSi()
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            dsbs = data.getDSbacsi();
        }
        public List<BacSi> getDSbacsi()
        {
            return dsbs.Values.ToList();
        }
        public BacSi tim(string mabs)
        {
            try
            {
                return dsbs[mabs];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool them(BacSi a)
        {
            try
            {
                dsbs.Add(a.Mabs, a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(string mabs)
        {
            return dsbs.Remove(mabs);
        }
        public bool sua(BacSi a)
        {
            BacSi b = tim(a.Mabs);
            if (b != null)
            {
                b.Mabs = a.Mabs;
                b.Hotenbs = a.Hotenbs;
                b.Chuyenkhoa = a.Chuyenkhoa;
                b.Phai = a.Phai;
                return true;
            }
            return false;
        }
    }
    class XuLyLoaiThuoc
    {
        private Dictionary<string, LoaiThuoc> dslt;
        public XuLyLoaiThuoc()
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            dslt = data.getDSloaithuoc();
        }
        public List<LoaiThuoc> getDSloaithuoc()
        {
            return dslt.Values.ToList();
        }
        public LoaiThuoc tim(string mathuoc)
        {
            try
            {
                return dslt[mathuoc];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool them(LoaiThuoc a)
        {
            try
            {
                dslt.Add(a.Mathuoc, a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(string mathuoc)
        {
            return dslt.Remove(mathuoc);
        }
        public bool sua(LoaiThuoc a)
        {
            LoaiThuoc b = tim(a.Mathuoc);
            if (b != null)
            {
                b.Mathuoc=a.Mathuoc ;
                b.Tenthuoc=a.Tenthuoc ;
                b.Soluong=a.Soluong ;
                b.Hangsd=a.Hangsd ;
                return true;
            }
            return false;
        }
    }
}
