using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    class ViewPhieuKham
    {
        public string Mapk { get; set; }
        public string Ngaylappk { get; set; }
        public string Tenpk { get; set; }
        public string Madt { get; set; }
        public string Tendt { get; set; }
        public string Dongia { get; set; }
        public string Soluong { get; set; }
        public string thanhtien { get; set; }
        public string Hotenbs { get; set; }
        public string Mabs { get; set; }
        public string Mabn { get; set; }
        public string Hotenbn { get; set; }
        public string Mathuoc { get; set; }
        public string Tenthuoc { get; set; }
        public static List<ViewPhieuKham> chuyendoi(PhieuKham pk)
        {
            List<ViewPhieuKham> ds = new List<ViewPhieuKham>();
            foreach (ChitietPhieuKham a in pk.Chitietpk)
            {
                ViewPhieuKham b = new ViewPhieuKham();
                b.Mapk = pk.Mapk;
                b.Ngaylappk = pk.Ngaylappk.ToString();
                b.Tenpk = pk.Tenpk;
                b.Madt = a.Donthuoc.Madt;
                b.Tendt = a.Donthuoc.Tendt;
                b.Dongia = a.Dongia.ToString();
                b.Soluong = a.Soluong.ToString();
                b.thanhtien = a.thanhtien().ToString();
                b.Mathuoc = a.Donthuoc.TThuoc.Mathuoc;
                b.Tenthuoc = a.Donthuoc.TThuoc.Tenthuoc;

                //b.Mabs = pk.Bs.Mabs;
                //b.Hotenbs = pk.Bs.Hotenbs;
                //b.Mabn = pk.Bn.Mabn;
                //b.Hotenbn = pk.Bn.Hotenbn;

                ds.Add(b);
            }
            return ds;
        }
    }
}
