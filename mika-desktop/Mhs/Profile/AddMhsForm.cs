using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mika_desktop.Mhs
{
    public partial class AddMhsForm : Form
    {
        /*
         *  TODO:
         *  Insert dummy picture to PictureBox
         *
         */

        public interface AddMhsFormListener
        {
            void refreshDgv();
        }

        private AddMhsFormListener listener;

        public AddMhsForm(AddMhsFormListener listener)
        {
            InitializeComponent();
            this.listener = listener;
        }

        private void AddMhsForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            listener.refreshDgv();
        }
    }
}
