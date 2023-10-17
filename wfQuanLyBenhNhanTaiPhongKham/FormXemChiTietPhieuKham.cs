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
    public partial class FormXemChiTietPhieuKham : Form
    {
        public object phieukham;
        public FormXemChiTietPhieuKham()
        {
            InitializeComponent();
        }

        private void FormXemChiTietPhieuKham_Load(object sender, EventArgs e)
        {
            PhieuKham pk = phieukham as PhieuKham;
            txtMapk.Text = pk.Mapk;
            txtTenpk.Text = pk.Tenpk;
            dtpNgaylappk.Value = pk.Ngaylappk;
            //textBox1.Text = pk.Bn.Hotenbn;
            //textBox2.Text = pk.Bs.Hotenbs;
            
            hienthiPhieuKham(pk);

        }
        private void hienthiPhieuKham(PhieuKham x)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ViewPhieuKham.chuyendoi(x);
            dgv.DataSource = bs;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
