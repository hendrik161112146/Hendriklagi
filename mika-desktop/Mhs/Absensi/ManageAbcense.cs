using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mika_desktop.Mhs.Absensi
{
    public partial class ManageAbcense : Form
    {

       

        public ManageAbcense()
        {
            InitializeComponent();
        }

        private void ManageAbcense_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void closeForm() {
            this.Hide();

        }
    }
}
