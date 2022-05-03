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
				("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
			if (h == DialogResult.OK)
				Application.Exit();
		}

		private void txtMaMonHoc_TextChanged(object sender, EventArgs e)
		{

		}

		

		private void Form2_Load(object sender, EventArgs e)
		{
			var makhoas = from mk in qlsinhvien.Khoas
						  select mk.MaKhoa;
			cboKhoa.DataSource = makhoas;

			var sinhviens = from sv in qlsinhvien.SinhViens
							select sv;
			
			dataGridView1.DataSource = sinhviens;
		}
	}
}
