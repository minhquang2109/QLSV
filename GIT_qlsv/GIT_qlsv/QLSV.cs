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
			var monhocs = from mh in qlsv.MonHocs
							select mh;
			dataGridView1.DataSource = monhocs;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			MonHoc mh = new MonHoc();
			mh.MaMonHoc = txtMaMonHoc.Text;
			mh.TenMonHoc = txtTenMonHoc.Text;
			qlsv.MonHocs.InsertOnSubmit(mh);
			qlsv.SubmitChanges();
			var monhocs = from mh1 in qlsv.MonHocs
						  select mh1;
			dataGridView1.DataSource = monhocs;

		}

		


		private void btnXoa_Click(object sender, EventArgs e)
		{

		}

		private void btnXua_Click(object sender, EventArgs e)
		{

		}
	}
}
