using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mika_desktop.Admin.AdminMhs;
using mika_desktop.Dataset;
using mika_desktop.Mhs.Absensi;

namespace mika_desktop.Mhs
{
    public partial class MhsForm : Form, AddMhsForm.AddMhsFormListener
    {
        public void refreshDgv()
        {
            MessageBox.Show("Refreshed");
        }

        //private Admin.AdminMhs.UpdateMhsForm admMhs;
        //private Dataset.DataSetMIKA dsprof;
        //public int nomor = 0;

        private AddMhsForm addMhsForm;
        private ManageAbcense manageAbcensForm;

        public MhsForm()
        {
            manageAbcensForm = new ManageAbcense();
            InitializeComponent();
            //this.dsprof = dsprof;
        }

        private void MhsForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


            if (BaseForm.role != 1)
            {
                btnAddMhs.Visible = false;
                btnMngAbsence.Visible = false;
                btnMngScore.Visible = false;
                btnDelete.Visible = false;
            }

            /*
            dgvMhs.Rows.Clear();
            DataRow[] result = ds.Tables["Mhs"].
                Select("Nama like '%" + tbSearch.Text + "%'" +
                " or NIM like '%" + tbSearch.Text + "%'");

            foreach (DataRow row in result)
            {
                string nim = row["NIM"].ToString();
                string nama = row["Nama"].ToString();
                string gender = "Pria";
                if (bool.Parse(row["Gender"].ToString()) == false)
                {
                    gender = "Wanita";
                }
                dgvMhs.Rows.Add(nim, nama, gender);
            }
            */
        }

        private void fillData()
        {

        }

        public void close_child() {

             manageAbcensForm.Hide();  

        }

        private void btnAddMhs_Click(object sender, EventArgs e)
        {
            

            
            addMhsForm = new AddMhsForm(this);
            addMhsForm.MdiParent = ParentForm;
            addMhsForm.Show();

            
            //admMhs = new UpdateMhsForm();
            //admMhs.MdiParent = this.MdiParent;
            //admMhs.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // testing purpose, don't delete yet
            //MessageBox.Show(dgvMhs.Rows[0].Cells[0].Value.ToString());
        }

        private void dgvMhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnMngScore_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMngAbsence_Click(object sender, EventArgs e)
        {
            
            manageAbcensForm.MdiParent = ParentForm;
            manageAbcensForm.Show();
            
        }

        /* BELUM KETEMU CARA TEPAT AMBIL DATA SECARA SPESIFIK DARI MULTIPLE DATASET UNTUK DIMASUKKAN KE DATAGRID 
        public void isidgv()
        {
            nomor = 1;
            dgvMhs.Rows.Clear();
            DataRow[] result = dsprof.Tables["Mhs_profil"].Select();

            foreach (DataRow row in result)
            {
                string nourut = nomor.ToString();
                string nimMhs = row["profmhs5"].ToString();
                string namaMhs = row["profmhs1"].ToString();
                dgvMhs.Rows.Add(nourut,nimMhs,namaMhs);
            }

        }*/
    }
}
