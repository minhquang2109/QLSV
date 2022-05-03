using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT_qlsv
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		QLSVDataContext qlsinhvien = new QLSVDataContext();



		private void btnThem_Click(object sender, EventArgs e)
		{
			SinhVien sv = new SinhVien();
			
			sv.MaSinhVien = txtMaSV.Text;
			sv.HoTen = txtHoTen.Text;
			qlsinhvien.SinhViens.InsertOnSubmit(sv);
			qlsinhvien.SubmitChanges();

			var sinhviens = from sv1 in qlsinhvien.SinhViens
							join l in qlsinhvien.Lops
							on sv1.MaLop equals l.MaLop
							select new { sv1.MaSinhVien, sv.HoTen, sv1.NgaySinh, l.TenLop };

			dataGridView1.DataSource = sinhviens;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnXua_Click(object sender, EventArgs e)
		{

		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			DialogResult h = MessageBox.Show
				("Bạn có chắc muốn thoát không?", "Thoát !", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}

		



		private void Form2_Load(object sender, EventArgs e)
		{
			var makhoas = from mk in qlsinhvien.Khoas
						  select mk.MaKhoa;
			cboKhoa.DataSource = makhoas;

			var sinhviens = from sv in qlsinhvien.SinhViens
							join l in qlsinhvien.Lops
							on sv.MaLop equals l.MaLop
							select new { sv.MaSinhVien, sv.HoTen, sv.NgaySinh, l.TenLop };
			
			dataGridView1.DataSource = sinhviens;
		}
	}
}
