using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tugas_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxDKV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDKV.Checked)
            {
                checkBoxAnim.Checked = false;
                checkBoxPPLG.Checked = false;
            }
        }

        private void checkBoxAnim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnim.Checked)
            {
                checkBoxDKV.Checked = false;
                checkBoxPPLG.Checked = false;
            }
        }

        private void checkBoxPPLG_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPPLG.Checked)
            {
                checkBoxAnim.Checked = false;
                checkBoxDKV.Checked = false;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNIS.Text) ||
                string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text) ||
                string.IsNullOrWhiteSpace(monthCalendarTGL.SelectionStart.ToShortDateString()) ||
                string.IsNullOrWhiteSpace(comboBoxAgama.Text) ||
                (!checkBoxDKV.Checked && !checkBoxAnim.Checked && !checkBoxPPLG.Checked) ||
                (!radioButtonLK.Checked && !radioButtonPR.Checked))
            {
                MessageBox.Show("Harap isi semua form.");
            }
            else
            {
                string nis = textBoxNIS.Text;
                string nama = textBoxNama.Text;
                string alamat = textBoxAlamat.Text;
                string tanggalLahir = monthCalendarTGL.SelectionStart.ToShortDateString();
                string agama = comboBoxAgama.Text;

                string jurusan = "";
                if (checkBoxDKV.Checked)
                    jurusan += checkBoxDKV.Text + ", ";
                if (checkBoxAnim.Checked)
                    jurusan += checkBoxAnim.Text + ", ";
                if (checkBoxPPLG.Checked)
                    jurusan += checkBoxPPLG.Text + ", ";

                if (!string.IsNullOrEmpty(jurusan))
                    jurusan = jurusan.TrimEnd(',', ' ');

                string jenisKelamin = (radioButtonLK.Checked) ? "Laki - laki" : "Perempuan";

                if (IsDataAlreadyExists(nama, alamat))
                {
                    MessageBox.Show("Nama atau Alamat anda sudah ada", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dataGridView1.Rows.Add(nis, nama, alamat, tanggalLahir, jenisKelamin, agama, jurusan);
                }
            }
        }

        private bool IsDataAlreadyExists(string nama, string alamat)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column2"].Value != null && row.Cells["Column3"].Value != null)
                {
                    string existingNama = row.Cells["Column3"].Value.ToString();
                    string existingAlamat = row.Cells["Column3"].Value.ToString();

                    if (existingNama == nama && existingAlamat == alamat)
                    {
                        return true;
                    }
                }
            }
            return false; // Data does not exist
        }

        private void monthCalendarTGL_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.", "Peringatan");
            }
        }

        private void comboBoxAgama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus semua data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                textBoxNIS.Text = string.Empty;
                textBoxNama.Text = string.Empty;
                textBoxAlamat.Text = string.Empty;
                radioButtonLK.Checked = false;
                radioButtonPR.Checked = false;
                comboBoxAgama.Text = string.Empty;
                monthCalendarTGL.Text = string.Empty;
                checkBoxDKV.Checked = false;
                checkBoxAnim.Checked = false;
                checkBoxPPLG.Checked = false;
            }
        }
    }
}