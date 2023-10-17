using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfQuanLyBenhNhanTaiPhongKham
{
    public partial class Formbacsi : Form
    {
        private XuLyBacSi xuly;
        public Formbacsi()
        {
            InitializeComponent();
        }

        private void Formbacsi_Load(object sender, EventArgs e)
        {
            xuly = new XuLyBacSi();
            hienthi(xuly.getDSbacsi());
            
        }
        private void hienthi(List<BacSi> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BacSi a = new BacSi();
                a.Mabs = textMabs.Text;
                a.Hotenbs = textHotenbs.Text;
                a.Chuyenkhoa = textChuyenkhoa.Text;
                a.Phai = radioNam.Checked;
                xuly.sua(a);
                hienthi(xuly.getDSbacsi());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BacSi x = new BacSi();
                x.Mabs = textMabs.Text;
                x.Hotenbs = textHotenbs.Text;
                x.Chuyenkhoa = textChuyenkhoa.Text;
                x.Phai = radioNam.Checked;
                
                xuly.them(x);
                hienthi(xuly.getDSbacsi());
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mabs = r.Cells[0].Value.ToString();
                DialogResult kq = MessageBox.Show("Bạn muốn xóa dòng này?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    xuly.xoa(mabs);
            }
            hienthi(xuly.getDSbacsi());
        }

        private void dgv_SChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mabs = r.Cells[0].Value.ToString();
                BacSi a = xuly.tim(mabs);
                textMabs.Text = a.Mabs;
                textHotenbs.Text = a.Hotenbs;
                textChuyenkhoa.Text = a.Chuyenkhoa;
                if (a.Phai == true) radioNam.Checked = true;
                else radioNu.Checked = true;
                break;
            }
        }
    }
}
