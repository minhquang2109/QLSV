namespace GIT_qlsv
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.btnXua = new System.Windows.Forms.ToolStripButton();
			this.btnDong = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.cboKhoa = new System.Windows.Forms.ComboBox();
			this.txtMalop = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.label1.Location = new System.Drawing.Point(302, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "QUẢN LÍ SINH VIÊN";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnXua,
            this.btnDong});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(57, 22);
			this.btnThem.Text = "Thêm";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(47, 22);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnXua
			// 
			this.btnXua.Image = ((System.Drawing.Image)(resources.GetObject("btnXua.Image")));
			this.btnXua.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXua.Name = "btnXua";
			this.btnXua.Size = new System.Drawing.Size(46, 22);
			this.btnXua.Text = "Sửa";
			this.btnXua.Click += new System.EventHandler(this.btnXua_Click);
			// 
			// btnDong
			// 
			this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
			this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(56, 22);
			this.btnDong.Text = "Đóng";
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(134, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mã khoa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(134, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mã sinh viên ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(134, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ngày sinh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(440, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Họ tên";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(441, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mã lớp";
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(225, 128);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(146, 20);
			this.txtMaSV.TabIndex = 13;
			// 
			// cboKhoa
			// 
			this.cboKhoa.FormattingEnabled = true;
			this.cboKhoa.Location = new System.Drawing.Point(225, 77);
			this.cboKhoa.Name = "cboKhoa";
			this.cboKhoa.Size = new System.Drawing.Size(121, 21);
			this.cboKhoa.TabIndex = 14;
			// 
			// txtMalop
			// 
			this.txtMalop.Location = new System.Drawing.Point(517, 79);
			this.txtMalop.Name = "txtMalop";
			this.txtMalop.Size = new System.Drawing.Size(146, 20);
			this.txtMalop.TabIndex = 16;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(517, 128);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(146, 20);
			this.txtHoTen.TabIndex = 17;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
			this.btnTimKiem.Location = new System.Drawing.Point(679, 77);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(83, 99);
			this.btnTimKiem.TabIndex = 18;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.Red;
			this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dataGridView1.Location = new System.Drawing.Point(12, 217);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(776, 221);
			this.dataGridView1.TabIndex = 19;
			// 
			// DateTimePicker1
			// 
			this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			this.DateTimePicker1.Location = new System.Drawing.Point(225, 175);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.DateTimePicker1.TabIndex = 20;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.txtMalop);
			this.Controls.Add(this.cboKhoa);
			this.Controls.Add(this.txtMaSV);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnThem;
		private System.Windows.Forms.ToolStripButton btnXoa;
		private System.Windows.Forms.ToolStripButton btnXua;
		private System.Windows.Forms.ToolStripButton btnDong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMaSV;
		private System.Windows.Forms.ComboBox cboKhoa;
		private System.Windows.Forms.TextBox txtMalop;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DateTimePicker DateTimePicker1;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}