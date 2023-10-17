using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    [Serializable]
    class Thuoc
    {
        private string madt;
        private string tendt;
        private int soluong;
        private double dongia;
        private LoaiThuoc thuoc;
        public LoaiThuoc TThuoc
        {
            get { return thuoc; }
            set { thuoc = value; }
        }
        public string Madt
        {
            get { return madt; }
            set { madt = value; }
        }
        public string Tendt
        {
            get { return tendt; }
            set { tendt = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public double Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public Thuoc()
        {
            madt = "";
            tendt = "";
            soluong = 0;
            dongia = 0;
            thuoc = null;
        }
        public Thuoc(string Madt,string Tendt,int Soluong,double Dongia, LoaiThuoc TThuoc)
        {
            madt = Madt;
            tendt = Tendt;
            soluong = Soluong;
            dongia = Dongia;
            thuoc = TThuoc;
        }
    }
    [Serializable]
    class ChitietPhieuKham
    {
        private int soluong;
        private double dongia;
        private Thuoc donthuoc;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public double Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public Thuoc Donthuoc
        {
            get { return donthuoc; }
            set { donthuoc = value; }
        }
        public ChitietPhieuKham()
        {
            soluong = 0;
            dongia = 0;
            donthuoc = null;
        }
        public ChitietPhieuKham(int Soluong,double Dongia,Thuoc Donthuoc)
        {
            soluong = Soluong;
            dongia = Dongia;
            donthuoc = Donthuoc;
        }
        public double thanhtien()
        {
            return dongia * soluong;
        }
    }
    [Serializable]
    class PhieuKham
    {
        private string mapk;
        private DateTime ngaylappk;
        private string tenpk;
        private List<ChitietPhieuKham> chitietpk;
        private BenhNhan _bn;
        private BacSi _bs;
        //private string hotenbs;
        //private string hotenbn;
        //public string Hotenbn
        //{
        //    get { return hotenbn; }
        //    set { hotenbn = value; }
        //}
        //public string Hotenbs
        //{
        //    get { return hotenbs; }
        //    set { hotenbs = value; }
        //}
        public BacSi Bs
        {
            get { return _bs; }
            set { _bs = value; }
        }
        public BenhNhan Bn
        {
            get { return _bn; }
            set { _bn = value; }
        }
        public string Mapk
        {
            get { return mapk; }
            set { mapk = value; }
        }
        public string Tenpk
        {
            get { return tenpk; }
            set { tenpk = value; }
        }
        public DateTime Ngaylappk
        {
            get { return ngaylappk; }
            set { ngaylappk = value; }
        }
        public List<ChitietPhieuKham> Chitietpk
        {
            get { return chitietpk; }
        }
        public PhieuKham()
        {
            mapk = "";
            ngaylappk = DateTime.Now;
            tenpk = "";
            chitietpk = new List<ChitietPhieuKham>();
            _bn = null;
            _bs = null;
            //hotenbs = "";
            //hotenbn = "";

        }
        public PhieuKham(string Mapk,DateTime Ngaylappk,string Tenpk, BenhNhan Bn,BacSi Bs/*, string Hotenbs, string Hotenbn*/)
        {
            mapk = Mapk;
            ngaylappk = Ngaylappk;
            tenpk = Tenpk;
            chitietpk = new List<ChitietPhieuKham>();
            _bn = Bn;
            _bs = Bs;
            //hotenbs = Hotenbs;
            //hotenbn = Hotenbn;
        }
        public double thanhtien()
        {
            double s = 0;
            foreach(ChitietPhieuKham a in chitietpk)
            {
                s += a.thanhtien();

            }return s;
        }
    }
}
