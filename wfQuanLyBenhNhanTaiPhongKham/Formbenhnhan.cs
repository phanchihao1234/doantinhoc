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
    
    public partial class Formbenhnhan : Form
    {
        private XuLyBenhNhan xuly;
        public Formbenhnhan()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                BenhNhan x = new BenhNhan();
                x.Mabn = txtMabn.Text;
                x.Hotenbn = txtHoten.Text;
                x.Ngaysinh = dtpngaysinh.Value;
                x.Cmnd = int.Parse(txtCmnd.Text);
                x.Diachi = txtDiachi.Text;
                x.Sdt = int.Parse(txtSdt.Text);
                x.BenhAn = txtBenhan.Text;
                x.Suckhoe = txtSuckhoe.Text;
                x.Phai = radioNam.Checked;
                
                xuly.them(x);
                hienthi(xuly.getDSbenhnhan());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mabn = r.Cells[0].Value.ToString();
                DialogResult kq = MessageBox.Show("Bạn muốn xóa dòng này?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    xuly.xoa(mabn);
            }
            hienthi(xuly.getDSbenhnhan());
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                BenhNhan a = new BenhNhan();
                a.Mabn = txtMabn.Text;
                a.Hotenbn = txtHoten.Text;
                a.Ngaysinh = dtpngaysinh.Value;
                a.Cmnd = int.Parse(txtCmnd.Text);
                a.Diachi = txtDiachi.Text;
                a.Sdt = int.Parse(txtSdt.Text);
                a.BenhAn = txtBenhan.Text;
                a.Suckhoe = txtSuckhoe.Text;
                a.Phai = radioNam.Checked;
                xuly.sua(a);
                hienthi(xuly.getDSbenhnhan());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Formbenhnhan_Load(object sender, EventArgs e)
        {
            xuly = new XuLyBenhNhan();
            hienthi(xuly.getDSbenhnhan());
        }
        private void hienthi(List<BenhNhan> dsbn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsbn;
            dgv.DataSource = bs;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgv.SelectedRows)
            {
                string mabn = r.Cells[0].Value.ToString();
                BenhNhan a = xuly.tim(mabn);
                txtMabn.Text = a.Mabn;
                txtHoten.Text = a.Hotenbn;
                dtpngaysinh.Value = a.Ngaysinh;
                if (a.Phai == true) radioNam.Checked = true;
                else radioNu.Checked = true;
                txtDiachi.Text = a.Diachi;
                txtBenhan.Text = a.BenhAn;
                txtSuckhoe.Text = a.Suckhoe;
                txtSuckhoe.Text = a.Sdt.ToString();
                txtCmnd.Text = a.Cmnd.ToString();
                break;
            }
        }
    }
}
