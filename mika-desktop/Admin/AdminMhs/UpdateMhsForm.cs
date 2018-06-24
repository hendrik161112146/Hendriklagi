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

namespace mika_desktop.Admin.AdminMhs
{
    public partial class UpdateMhsForm : Form
    {
        Dataset.DataSetMIKA.Mhs_profilDataTable dsprof;
        Dataset.DataSetMIKA.Mhs_dpDataTable dsdp = new Dataset.DataSetMIKA.Mhs_dpDataTable();
        Dataset.DataSetMIKA.Mhs_haDataTable dsha = new Dataset.DataSetMIKA.Mhs_haDataTable();
        Dataset.DataSetMIKA.Mhs_dkDataTable dsdk = new Dataset.DataSetMIKA.Mhs_dkDataTable();
        Dataset.DataSetMIKA.Mhs_uaDataTable dsua = new Dataset.DataSetMIKA.Mhs_uaDataTable();
        int jumlah_mhs = 0;
       

        public UpdateMhsForm()
        {
            InitializeComponent();
        }
        private void UpdateMhsForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnsimpanMhs_Click(object sender, EventArgs e)
        {
            jumlah_mhs++;
            dsprof = new Dataset.DataSetMIKA.Mhs_profilDataTable();
            dsprof.Rows.Add(profmhs1.Text, profmhs2.Text, profmhs3.Text, profmhs4.Text, profmhs5.Text, profmhs6.Text, profmhs7.Text, profmhs8.Text, profmhs9.Text,profmhs10.Text);
            dsdp.Rows.Add(dpmhs1.Text, dpmhs2.Text, dpmhs3, Text, dpmhs4.Text, dpmhs5.Text, dpmhs7.Text, dpmhs8.Text, dpmhs9.Text, dpmhs10.Text);
            dsha.Rows.Add(hamhs1.Text, hamhs2.Text, hamhs3.Text, hamhs4.Text, hamhs5.Text, hamhs6.Text, hamhs7.Text, hamhs8.Text, hamhs9.Text);
            dsdk.Rows.Add(dkmhs1.Text, dkmhs2.Text, dkmhs3.Text, dkmhs4.Text, dkmhs5.Text, dkmhs6.Text);
            dsua.Rows.Add(uamhs1.Text, uamhs2.Text, uamhs3.Text,uamhs4.Text);
        }

        private void btnselesaiMhs_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnresetMhs_Click(object sender, EventArgs e)
        {
            profmhs1.Text = ""; profmhs2.Text = ""; profmhs3.Text = ""; profmhs4.Text = ""; profmhs5.Text = ""; profmhs6.Text = ""; profmhs7.Text = ""; profmhs8.Text = ""; profmhs9.Text = ""; profmhs10.Text = "";
            dpmhs1.Text = ""; dpmhs2.Text = ""; dpmhs3.Text = ""; dpmhs4.Text = ""; dpmhs5.Text = ""; dpmhs7.Text = ""; dpmhs8.Text = ""; dpmhs9.Text = ""; dpmhs10.Text = "";
            hamhs1.Text = ""; hamhs2.Text = ""; hamhs3.Text = ""; hamhs4.Text = ""; hamhs5.Text = ""; hamhs6.Text = ""; hamhs7.Text = ""; hamhs8.Text = ""; hamhs9.Text = "";
            dkmhs1.Text = ""; dkmhs2.Text = ""; dkmhs3.Text = ""; dkmhs4.Text = ""; dkmhs5.Text = ""; dkmhs6.Text = "";
            uamhs1.Text = ""; uamhs2.Text = ""; uamhs3.Text = ""; uamhs4.Text = "";
        }
    }
}
