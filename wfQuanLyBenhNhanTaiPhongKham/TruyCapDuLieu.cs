using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    [Serializable]
    class TruyCapDuLieu
    {
        private static TruyCapDuLieu data = null;
        private Dictionary<string, BenhNhan> m_dsbn;
        private  Dictionary<string, BacSi> m_dsbs;
        private  Dictionary<string, LoaiThuoc> m_dslt;
        private  Dictionary<string, Thuoc> m_dsdt;
        private  Dictionary<string, PhieuKham> m_dspk;

        private TruyCapDuLieu()
        {
            m_dsbn = new Dictionary<string, BenhNhan>();
            m_dsbs = new Dictionary<string, BacSi>();
            m_dslt = new Dictionary<string, LoaiThuoc>();
            m_dsdt = new Dictionary<string, Thuoc>();
            m_dspk = new Dictionary<string, PhieuKham>();
            
        }
        public static TruyCapDuLieu khoitao()
        {
            if(data==null) data =new TruyCapDuLieu();
            return data;
        }
        public Dictionary<string, BenhNhan> getDSbenhnhan()
        {
            return m_dsbn;
        }
        public Dictionary<string, LoaiThuoc> getDSloaithuoc()
        {
            return m_dslt;
        }
        public Dictionary<string, BacSi> getDSbacsi()
        {
            return m_dsbs;
        }
        public Dictionary<string, Thuoc> getDSthuoc()
        {
            return m_dsdt;
        }
        public Dictionary<string, PhieuKham> getDSphieukham()
        {
            return m_dspk;
        }
        public bool ghiDulieu(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, data);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docDulieu(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                data = bf.Deserialize(f) as TruyCapDuLieu;
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
