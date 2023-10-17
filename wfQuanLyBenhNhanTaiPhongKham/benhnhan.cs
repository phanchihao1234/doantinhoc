using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanLyBenhNhanTaiPhongKham
{ 
    [Serializable]
    class BenhNhan
        {
            private string mabn;
            private string hotenbn;
            private int sdt;
            private int cmnd;
            private DateTime ngaysinh;
            private bool phai;

            private string diachi;
            private string benhan;
            private string suckhoe;

            public string Mabn
            {
                get { return mabn; }
                set { mabn = value; }
            }
            public string Hotenbn
            {
                get { return hotenbn; }
                set { hotenbn = value; }
            }
            public int Sdt
            {
                get { return sdt; }
                set { sdt = value; }
            }
            public int Cmnd
            {
                get { return cmnd; }
                set { cmnd = value; }
            }
            public DateTime Ngaysinh
            {
                get { return ngaysinh; }
                set { ngaysinh = value; }
            }
            public bool Phai
            {
                get { return phai; }
                set { phai = value; }
            }
            public string Diachi
            {
                get { return diachi; }
                set { diachi = value; }
            }
            public string BenhAn
            {
                get { return benhan; }
                set { benhan = value; }
            }
            public string Suckhoe
            {
                get { return suckhoe; }
                set { suckhoe = value; }
            }
            public BenhNhan(string Mabn, string Hotenbn, int Sdt, int Cmnd, DateTime Ngaysinh, bool Phai, string Diachi, string BenhAn, string Suckhoe)
            {
                mabn = Mabn;
                hotenbn = Hotenbn;
                sdt = Sdt;
                cmnd = Cmnd;
                ngaysinh = Ngaysinh;
                phai = Phai;
                diachi = Diachi;
                benhan = BenhAn;
                suckhoe = Suckhoe;
            }
            public BenhNhan()
            {
                mabn = "";
                hotenbn = "";
                sdt = 0;
                cmnd = 0;
                ngaysinh = DateTime.Now;
                phai = false;
                diachi = "";
                benhan = "";
                suckhoe = "";
            }
        }
    [Serializable]
    class BacSi
    {
        private string mabs;
        private string hotenbs;
        private string chuyenkhoa;
        private bool phai;

        public BacSi()
        {
            mabs = "";
            hotenbs = "";
            chuyenkhoa = "";
            phai = false;
        }
        public BacSi(string Mabs, string Hotenbs, string Chuyenkhoa, bool Phai)
        {
            mabs = Mabs;
            hotenbs = Hotenbs;
            chuyenkhoa = Chuyenkhoa;
            phai = Phai;
        }
        public string Mabs
        {
            get { return mabs; }
            set { mabs = value; }
        }
        public string Hotenbs
        {
            get { return hotenbs; }
            set { hotenbs = value; }
        }
        public string Chuyenkhoa
        {
            get { return chuyenkhoa; }
            set { chuyenkhoa = value; }
        }
        public bool Phai
        {
            get { return phai; }
            set { phai = value; }
        }
    }
    [Serializable]
    class LoaiThuoc
    {
        private string mathuoc;
        private string tenthuoc;
        private string soluong;
        private DateTime hangsudung;
        public LoaiThuoc()
        {
            mathuoc = "";
            tenthuoc = "";
            soluong = "";
            hangsudung = DateTime.Now;
        }
        public LoaiThuoc(string Mathuoc, string Tenthuoc, string Soluong, DateTime Hangsd)
        {
            mathuoc = Mathuoc;
            tenthuoc = Tenthuoc;
            soluong = Soluong;
            hangsudung = Hangsd;
        }
        public string Mathuoc
        {
            get { return mathuoc; }
            set { mathuoc = value; }
        }
        public string Tenthuoc
        {
            get { return tenthuoc; }
            set { tenthuoc = value; }
        }
        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public DateTime Hangsd
        {
            get { return hangsudung; }
            set { hangsudung = value; }
        }
    }

}
