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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		QLSVDataContext qlsv = new QLSVDataContext();

		private void btnDong_Click(object sender, EventArgs e)
		{
			DialogResult h = MessageBox.Show
				("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			var Sinhviens = from mh in qlsv.SinhViens
							select mh;
			dataGridView1.DataSource = Sinhviens;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			SinhVien mh = new SinhVien();
			mh.MaSinhVien = txtMaMonHoc.Text;
			mh.HoTen = txtTenMonHoc.Text;
			qlsv.SinhViens.InsertOnSubmit(mh);
			qlsv.SubmitChanges();
			var sinhviens = from mh1 in qlsv.SinhViens
						  select mh1;
			dataGridView1.DataSource = sinhviens;

		}

		


		private void btnXoa_Click(object sender, EventArgs e)
		{
			string mamh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			MonHoc mh = qlsv.MonHocs.Where(t=>t.MaMonHoc == mamh).FirstOrDefault();
			qlsv.MonHocs.DeleteOnSubmit(mh);
			qlsv.SubmitChanges();
			var monhocs = from mh1 in qlsv.MonHocs
						  select mh1;
			dataGridView1.DataSource = monhocs;
		}

		private void btnXua_Click(object sender, EventArgs e)
		{
			string mamh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			MonHoc mh = qlsv.MonHocs.Where(t => t.MaMonHoc == mamh).FirstOrDefault();
			mh.TenMonHoc = txtTenMonHoc.Text;
			qlsv.SubmitChanges();
			var monhocs = from mh1 in qlsv.MonHocs
						  select mh1;
			dataGridView1.DataSource = monhocs;
		}
	}
}
