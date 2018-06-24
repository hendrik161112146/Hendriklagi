using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mika_desktop.Dosen
{
    public partial class DosenForm : Form
    {
        public DosenForm()
        {
            InitializeComponent();
        }

        private void DosenForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            if (BaseForm.role != 1)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
            }
        }
    }
}
