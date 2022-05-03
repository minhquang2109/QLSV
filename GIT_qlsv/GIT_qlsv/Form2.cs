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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox1.DataSource = qlsinhvien;
			comboBox1.DisplayMember = "khoa";
			comboBox1.ValueMember = "Khoa";
		}
	}
}
