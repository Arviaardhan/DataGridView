namespace Tugas_DataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxNIS = new TextBox();
            textBoxNama = new TextBox();
            textBoxAlamat = new TextBox();
            radioButtonLK = new RadioButton();
            radioButtonPR = new RadioButton();
            comboBoxAgama = new ComboBox();
            checkBoxDKV = new CheckBox();
            checkBoxAnim = new CheckBox();
            checkBoxPPLG = new CheckBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            buttonTambah = new Button();
            monthCalendarTGL = new MonthCalendar();
            btnHapus = new Button();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            panel2 = new Panel();
            btnClear = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(543, 28);
            label1.Name = "label1";
            label1.Size = new Size(531, 38);
            label1.TabIndex = 0;
            label1.Text = "PENDAFTARAN DATA SISWA SEKOLAH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(251, 205);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "NAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(251, 277);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "ALAMAT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(251, 523);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 3;
            label4.Text = "JURUSAN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1092, 131);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 4;
            label5.Text = "TANGGAL LAHIR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(251, 395);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 5;
            label6.Text = "JENIS KELAMIN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(251, 460);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 6;
            label7.Text = "AGAMA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(251, 134);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 7;
            label8.Text = "NIS";
            // 
            // textBoxNIS
            // 
            textBoxNIS.BorderStyle = BorderStyle.FixedSingle;
            textBoxNIS.Location = new Point(543, 131);
            textBoxNIS.Name = "textBoxNIS";
            textBoxNIS.Size = new Size(347, 31);
            textBoxNIS.TabIndex = 8;
            textBoxNIS.KeyPress += textBoxNIS_KeyPress;
            // 
            // textBoxNama
            // 
            textBoxNama.BorderStyle = BorderStyle.FixedSingle;
            textBoxNama.Location = new Point(543, 202);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(347, 31);
            textBoxNama.TabIndex = 9;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.BorderStyle = BorderStyle.FixedSingle;
            textBoxAlamat.Location = new Point(543, 274);
            textBoxAlamat.Multiline = true;
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(347, 87);
            textBoxAlamat.TabIndex = 11;
            // 
            // radioButtonLK
            // 
            radioButtonLK.AutoSize = true;
            radioButtonLK.Location = new Point(543, 393);
            radioButtonLK.Name = "radioButtonLK";
            radioButtonLK.Size = new Size(126, 29);
            radioButtonLK.TabIndex = 12;
            radioButtonLK.TabStop = true;
            radioButtonLK.Text = "LAKI - LAKI";
            radioButtonLK.UseVisualStyleBackColor = true;
            // 
            // radioButtonPR
            // 
            radioButtonPR.AutoSize = true;
            radioButtonPR.Location = new Point(749, 393);
            radioButtonPR.Name = "radioButtonPR";
            radioButtonPR.Size = new Size(139, 29);
            radioButtonPR.TabIndex = 13;
            radioButtonPR.TabStop = true;
            radioButtonPR.Text = "PEREMPUAN";
            radioButtonPR.UseVisualStyleBackColor = true;
            // 
            // comboBoxAgama
            // 
            comboBoxAgama.FormattingEnabled = true;
            comboBoxAgama.Items.AddRange(new object[] { "", "Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu" });
            comboBoxAgama.Location = new Point(543, 457);
            comboBoxAgama.Name = "comboBoxAgama";
            comboBoxAgama.Size = new Size(222, 33);
            comboBoxAgama.TabIndex = 14;
            comboBoxAgama.SelectedIndexChanged += comboBoxAgama_SelectedIndexChanged;
            // 
            // checkBoxDKV
            // 
            checkBoxDKV.AutoSize = true;
            checkBoxDKV.Location = new Point(543, 522);
            checkBoxDKV.Name = "checkBoxDKV";
            checkBoxDKV.Size = new Size(72, 29);
            checkBoxDKV.TabIndex = 15;
            checkBoxDKV.Text = "DKV";
            checkBoxDKV.UseVisualStyleBackColor = true;
            checkBoxDKV.CheckedChanged += checkBoxDKV_CheckedChanged;
            // 
            // checkBoxAnim
            // 
            checkBoxAnim.AutoSize = true;
            checkBoxAnim.Location = new Point(654, 522);
            checkBoxAnim.Name = "checkBoxAnim";
            checkBoxAnim.Size = new Size(111, 29);
            checkBoxAnim.TabIndex = 16;
            checkBoxAnim.Text = "ANIMASI";
            checkBoxAnim.UseVisualStyleBackColor = true;
            checkBoxAnim.CheckedChanged += checkBoxAnim_CheckedChanged;
            // 
            // checkBoxPPLG
            // 
            checkBoxPPLG.AutoSize = true;
            checkBoxPPLG.Location = new Point(802, 522);
            checkBoxPPLG.Name = "checkBoxPPLG";
            checkBoxPPLG.Size = new Size(77, 29);
            checkBoxPPLG.TabIndex = 17;
            checkBoxPPLG.Text = "PPLG";
            checkBoxPPLG.UseVisualStyleBackColor = true;
            checkBoxPPLG.CheckedChanged += checkBoxPPLG_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(251, 594);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1113, 372);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "NIS";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "NAMA";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "ALAMAT";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "TANGGAL LAHIR";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "JENIS KELAMIN";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "AGAMA";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "JURUSAN";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.ForestGreen;
            buttonTambah.Cursor = Cursors.Hand;
            buttonTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTambah.ForeColor = SystemColors.ButtonHighlight;
            buttonTambah.Location = new Point(1388, 594);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(112, 43);
            buttonTambah.TabIndex = 19;
            buttonTambah.Text = "TAMBAH";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // monthCalendarTGL
            // 
            monthCalendarTGL.Location = new Point(1092, 181);
            monthCalendarTGL.Name = "monthCalendarTGL";
            monthCalendarTGL.TabIndex = 21;
            monthCalendarTGL.DateChanged += monthCalendarTGL_DateChanged;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHapus.ForeColor = SystemColors.ButtonHighlight;
            btnHapus.Location = new Point(1388, 664);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 43);
            btnHapus.TabIndex = 22;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 793);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Snow;
            btnClose.Location = new Point(79, 793);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 55);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1551, 99);
            panel2.TabIndex = 25;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(1092, 460);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 43);
            btnClear.TabIndex = 26;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 895);
            panel1.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1551, 994);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(panel2);
            Controls.Add(btnHapus);
            Controls.Add(monthCalendarTGL);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridView1);
            Controls.Add(checkBoxPPLG);
            Controls.Add(checkBoxAnim);
            Controls.Add(checkBoxDKV);
            Controls.Add(comboBoxAgama);
            Controls.Add(radioButtonPR);
            Controls.Add(radioButtonLK);
            Controls.Add(textBoxAlamat);
            Controls.Add(textBoxNama);
            Controls.Add(textBoxNIS);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PENDAFTARAN DATA SISWA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxNIS;
        private TextBox textBoxNama;
        private TextBox textBoxAlamat;
        private RadioButton radioButtonLK;
        private RadioButton radioButtonPR;
        private ComboBox comboBoxAgama;
        private CheckBox checkBoxDKV;
        private CheckBox checkBoxAnim;
        private CheckBox checkBoxPPLG;
        private DataGridView dataGridView1;
        private Button buttonTambah;
        private MonthCalendar monthCalendarTGL;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnHapus;
        private Panel panel2;
        private Button btnClose;
        private Button btnClear;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}