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
    public partial class Formphieukham : Form
    {
        private XuLyThuoc xlDT;
        private XuLyPhieuKham xlPK;
        private PhieuKham pk;
        private XuLyBacSi xlBS;
        private XuLyBenhNhan xlBN;
        public Formphieukham()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Formphieukham_Load(object sender, EventArgs e)
        {
            pk = new PhieuKham();
            xlDT = new XuLyThuoc();
            xlPK = new XuLyPhieuKham();
            xlBS = new XuLyBacSi();
            xlBN = new XuLyBenhNhan();
            hienthiCombobox(xlDT.getDSthuoc());
            hienthiComboboxbs(xlBS.getDSbacsi());
            hienthiCboxBN(xlBN.getDSbenhnhan());
            hienthiDSPK(xlPK.getDSphieukham());
        }
        private void hienthiCombobox(List<Thuoc> dsThuoc)
        {
            cmbMadt.DisplayMember = "Madt";
            cmbMadt.ValueMember = "Madt";
            cmbMadt.DataSource = dsThuoc; 
        }
        
        private void hienthiDSPK(List<PhieuKham> dsPhieu)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsPhieu;
            dgvDSPK.DataSource = bs;
            
        }

        private void cmbMadt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Madt = cmbMadt.SelectedValue.ToString();
            Thuoc a = xlDT.tim(Madt);
            txtTendt.Text = a.Tendt;
            txtDongia.Text = a.Dongia.ToString();
            txtSoluong.Text = a.Soluong.ToString();
        }
       
        private void btnLappk_Click(object sender, EventArgs e)
        {
            try {
                pk.Mapk = txtMapk.Text;
                pk.Tenpk = txtTenpk.Text;
                pk.Ngaylappk = dtpNgaylappk.Value;

                //BacSi a = new BacSi();
                string Mabs = cmbMabs.SelectedValue.ToString();
                pk.Bs = xlBS.tim(Mabs);
                //pk.Hotenbs = pk.Bs.Hotenbs;

                //BenhNhan b = new BenhNhan();
                string Mabn = cmbBenhNhan.SelectedValue.ToString();
                pk.Bn = xlBN.tim(Mabn);
                //pk.Hotenbn = pk.Bn.Hotenbn;


                if (xlPK.them(pk) == false)
                {
                    MessageBox.Show("không thêm được phiếu");
                }
                else
                {
                    hienthiDSPK(xlPK.getDSphieukham());
                    pk = new PhieuKham();
                    hienthiPhieuKham(pk);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void hienthiPhieuKham(PhieuKham x)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ViewPhieuKham.chuyendoi(x);
            dgv.DataSource = bs;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            ChitietPhieuKham ct = new ChitietPhieuKham();

            //string Mabn = cmbBenhNhan.SelectedValue.ToString();
            //pk.Bn = xlBN.tim(Mabn);
            //string Mabs = cmbMabs.SelectedValue.ToString();
            //pk.Bs = xlBS.tim(Mabs);

            string Madt = cmbMadt.SelectedValue.ToString();
            ct.Donthuoc = xlDT.tim(Madt);
            ct.Dongia = ct.Donthuoc.Dongia;
            ct.Soluong = ct.Donthuoc.Soluong;

            pk.Chitietpk.Add(ct);
            hienthiPhieuKham(pk);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSPK.SelectedRows)
            {
                string Mapk = r.Cells[0].Value.ToString();
                PhieuKham pk = xlPK.tim(Mapk);
                FormXemChiTietPhieuKham f = new FormXemChiTietPhieuKham();
                f.phieukham = pk;
                MessageBox.Show(Mapk);
                f.ShowDialog();
                break;
            }
            //FormXemChiTietPhieuKham f = new FormXemChiTietPhieuKham();
            //f.ShowDialog();

        }
        private void hienthiComboboxbs(List<BacSi> dsBS)
        {
            cmbMabs.DisplayMember = "Mabs";
            cmbMabs.ValueMember = "Mabs";
            cmbMabs.DataSource = dsBS; ;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mabs = cmbMabs.SelectedValue.ToString();
            BacSi a = xlBS.tim(Mabs);
            txtHoten.Text = a.Hotenbs;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void hienthiCboxBN(List<BenhNhan> dsBN)
        {
            cmbBenhNhan.DisplayMember = "Mabn";
            cmbBenhNhan.ValueMember = "Mabn";
            cmbBenhNhan.DataSource = dsBN;
        }

        private void cmbBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mabn = cmbBenhNhan.SelectedValue.ToString();
            BenhNhan a = xlBN.tim(Mabn);
            txtTenBN.Text = a.Hotenbn;
        }
    }
}
