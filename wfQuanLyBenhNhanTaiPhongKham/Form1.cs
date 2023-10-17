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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            if (data.docDulieu("test.dat") == false)
                MessageBox.Show("không đọc dữ liệu");

        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbenhnhan f = new Formbenhnhan();

            f.Show(); 
        }

        private void ghiFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu data = TruyCapDuLieu.khoitao();
            if (data.ghiDulieu("test.dat") == true)
                MessageBox.Show("ghi thành công");
            else MessageBox.Show("không ghi được");
        }

        private void quảnLýBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbacsi f = new Formbacsi();
            f.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formloaithuoc f = new Formloaithuoc();
            f.Show();
        }

        private void đơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdonthuoc f = new Formdonthuoc();
            f.Show();
        }

        private void quảnLýPhiếuKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formphieukham f = new Formphieukham();
            f.Show();
        }
    }
}
