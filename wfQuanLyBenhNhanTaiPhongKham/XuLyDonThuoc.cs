using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    class XuLyThuoc
    {
        private Dictionary<string, Thuoc> dsdt;
        public XuLyThuoc()
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            dsdt = data.getDSthuoc();
        }
        public List<Thuoc> getDSthuoc()
        {
            return dsdt.Values.ToList();
        }
        public Thuoc tim( string Madt)
        {
            try
            {
                return dsdt[Madt];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool them(Thuoc a)
        {
            Thuoc b = tim(a.Madt);
            if (b == null)
            {
                dsdt.Add(a.Madt, a);
                return true;
            }
            return false;
        }
        public bool xoa(string Madt)
        {
            return dsdt.Remove(Madt);
        }
        public bool sua(Thuoc a)
        {
            Thuoc b = tim(a.Madt);
            if (b != null)
            {
                b.Tendt = a.Tendt;
                b.Soluong = a.Soluong;
                b.Dongia = a.Dongia;
                b.TThuoc = a.TThuoc;
                return true;
            }
            return false;
        }  
    }
}
