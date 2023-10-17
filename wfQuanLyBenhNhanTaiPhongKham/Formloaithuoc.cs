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
    public partial class Formloaithuoc : Form
    {
        private XuLyLoaiThuoc xuly;
        public Formloaithuoc()
        {
            InitializeComponent();
        }

        private void Formloaithuoc_Load(object sender, EventArgs e)
        {
            xuly = new XuLyLoaiThuoc();
            hienthi(xuly.getDSloaithuoc());
        }
        private void hienthi(List<LoaiThuoc> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiThuoc x = new LoaiThuoc();
                x.Mathuoc = txtMathuoc.Text;
                x.Tenthuoc = txtTenthuoc.Text;
                x.Soluong = txtSoluong.Text;
                x.Hangsd = dtpHangsd.Value;
                xuly.them(x);
                hienthi(xuly.getDSloaithuoc());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string malt = r.Cells[0].Value.ToString();
                DialogResult kq = MessageBox.Show("Bạn muốn xóa dòng này?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    xuly.xoa(malt);
            }
            hienthi(xuly.getDSloaithuoc());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiThuoc x = new LoaiThuoc();
                x.Mathuoc = txtMathuoc.Text;
                x.Tenthuoc = txtTenthuoc.Text;
                x.Soluong = txtSoluong.Text;
                x.Hangsd = dtpHangsd.Value;
                xuly.sua(x);
                hienthi(xuly.getDSloaithuoc());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgv_SChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string malt = r.Cells[0].Value.ToString();
                LoaiThuoc a = xuly.tim(malt);
                txtMathuoc.Text = a.Mathuoc;
                txtTenthuoc.Text = a.Tenthuoc;
                txtSoluong.Text = a.Soluong;
                dtpHangsd.Value = a.Hangsd;
                break;
            }
        }
    }
}
