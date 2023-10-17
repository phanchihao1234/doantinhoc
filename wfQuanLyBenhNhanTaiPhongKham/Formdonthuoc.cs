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
    public partial class Formdonthuoc : Form
    {
        private XuLyThuoc xuly;
        private XuLyLoaiThuoc xllt;
        private Thuoc t;
        public Formdonthuoc()
        {
            InitializeComponent();
        }

        private void Formdonthuoc_Load(object sender, EventArgs e)
        {
            xuly = new XuLyThuoc();
            xllt = new XuLyLoaiThuoc();
            t = new Thuoc();
            //hienthi(xuly.getDSthuoc());
            hienthiComboBox2(xllt.getDSloaithuoc());
            hienthithuoc(t);

        }
        private void hienthithuoc(Thuoc x)
        {
            dgv.Rows.Clear();//xoa cac dong bi lap lai
            foreach (Thuoc c in xuly.getDSthuoc())
            {

                dgv.Rows.Add(

                c.Madt,
                c.Tendt,
                c.Soluong,
                c.Dongia,

                c.TThuoc.Mathuoc,
                c.TThuoc.Tenthuoc


                );
            }
        }
        private void hienthiComboBox2(List<LoaiThuoc> dslt)
        {

            comboBox1.DisplayMember = "Mathuoc";
            comboBox1.ValueMember = "Mathuoc";
            comboBox1.DataSource = dslt;
        }
        private void hienthi(List<Thuoc> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Thuoc a = new Thuoc();
                a.Madt = txtMadt.Text;
                a.Tendt = txtTendt.Text;
                a.Soluong = int.Parse(txtSoluong.Text);
                a.Dongia = double.Parse(txtDongia.Text);

                a.TThuoc = xllt.tim(comboBox1.SelectedValue.ToString());
                xuly.them(a);
                //hienthi(xuly.getDSthuoc());
                hienthithuoc(t);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    string Madt = r.Cells[0].Value.ToString();
                    DialogResult kq = MessageBox.Show("Bạn muốn xóa dòng này?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                        xuly.xoa(Madt);
                }
                //hienthi(xuly.getDSthuoc());
                hienthithuoc(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgv.SelectedRows)
            {
                string Madt = r.Cells[0].Value.ToString();
                Thuoc a = xuly.tim(Madt);
                txtMadt.Text = a.Madt;
                txtTendt.Text = a.Tendt;
                txtSoluong.Text = a.Soluong.ToString();
                txtDongia.Text = a.Dongia.ToString();

                comboBox1.SelectedValue = a.TThuoc.Mathuoc;
                break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Thuoc a = new Thuoc();
                a.Madt = txtMadt.Text;
                a.Tendt = txtTendt.Text;
                a.Soluong = int.Parse(txtSoluong.Text);
                a.Dongia = double.Parse(txtDongia.Text);

                a.TThuoc = xllt.tim(comboBox1.SelectedValue.ToString());

                xuly.sua(a);
                //hienthi(xuly.getDSthuoc());
                hienthithuoc(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mathuoc = comboBox1.SelectedValue.ToString();
            LoaiThuoc a = xllt.tim(Mathuoc);
            textBox1.Text = a.Tenthuoc;
        }
    }
}
