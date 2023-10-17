using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    class XuLyPhieuKham
    {
        private Dictionary<string, PhieuKham> dspk;
        public XuLyPhieuKham()
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            dspk = data.getDSphieukham();
        }
        public List<PhieuKham> getDSphieukham()
        {
            return dspk.Values.ToList();
        }
        public PhieuKham tim(string Mapk)
        {
            try
            {
                return dspk[Mapk];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool them(PhieuKham x)
        {
            PhieuKham b = tim(x.Mapk);
            if (b == null)
            {
                dspk.Add(x.Mapk, x);
                return true;
            }
            return false;
        }
    }
}
