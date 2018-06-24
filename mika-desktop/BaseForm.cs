using mika_desktop.Absensi;
using mika_desktop.Profile;
using mika_desktop.Mhs;
using mika_desktop.Dosen;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace mika_desktop
{
    public partial class BaseForm : Form
    {
        private ProfileForm profileForm;
        private AbsensiForm absensiForm;
        private MhsForm mhsForm;
        private DosenForm dosenForm;

        private Button btnMahasiswa;
        private Button btnDosen;
        private Button btnMataKuliah;
        private Button btnNilai;
        private Button btnAbsensi;
        private Button btnProfile;

        public static int role; // set to global variable so that we can access it from anywhere
        private int selected = 0;

        /*
         *  Variable 'selected' is used to give each menu an index
         *  Profile = 1
         *  Absensi = 2
         *  Nilai = 3
         *  Mahasiswa = 4
         *  Dosen = 5
         *  Mata Kuliah = 6
         * 
         */

        public BaseForm(int role)
        {
            InitializeComponent();
            mhsForm = new MhsForm();
            BaseForm.role = role;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Text = "MIKA - Role = " + role;

            generateButtons();
        }

        private void generateButtons()
        {
            if (role == 1) // admin
            {
                showBtnMahasiswa(0);
                showBtnDosen(59);
                showBtnMataKuliah(59 * 2);
            }

            if (role == 2) // dosen
            {
                showBtnProfile(0);
                showBtnMahasiswa(59);
                showBtnDosen(59 * 2);
                showBtnMataKuliah(59 * 3);

                profileForm = new ProfileForm();
                selected = 1;
                profileForm.MdiParent = this;
                profileForm.Show();
            }

            if (role == 3) // mahasiswa
            {
                showBtnProfile(0);
                showBtnAbsensi(59);
                showBtnNilai(59 * 2);
                showBtnDosen(59 * 3);
                showBtnMataKuliah(59 * 4);

                profileForm = new ProfileForm();
                selected = 1;
                profileForm.MdiParent = this;
                profileForm.Show();
            }
        }

        private void showBtnProfile(int y)
        {
            btnProfile = new Button();
            panel1.Controls.Add(btnProfile);

            btnProfile.Location = new Point(0, y);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(155, 61);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += new EventHandler(btnProfile_Click);
        }

        private void showBtnAbsensi(int y)
        {
            btnAbsensi = new Button();
            panel1.Controls.Add(btnAbsensi);

            btnAbsensi.Location = new Point(0, y);
            btnAbsensi.Name = "btnAbsensi";
            btnAbsensi.Size = new Size(155, 61);
            btnAbsensi.TabIndex = 1;
            btnAbsensi.Text = "Absensi";
            btnAbsensi.UseVisualStyleBackColor = true;
            btnAbsensi.Click += new EventHandler(btnAbsensi_Click);
        }

        private void showBtnNilai(int y)
        {
            btnNilai = new Button();
            panel1.Controls.Add(btnNilai);

            btnNilai.Location = new Point(0, y);
            btnNilai.Name = "btnNilai";
            btnNilai.Size = new Size(155, 61);
            btnNilai.TabIndex = 2;
            btnNilai.Text = "Nilai";
            btnNilai.UseVisualStyleBackColor = true;
            btnNilai.Click += new EventHandler(btnNilai_Click);
        }

        private void showBtnMahasiswa(int y)
        {
            btnMahasiswa = new Button();
            panel1.Controls.Add(btnMahasiswa);

            btnMahasiswa.Location = new Point(0, y);
            btnMahasiswa.Name = "btnMahasiswa";
            btnMahasiswa.Size = new Size(155, 61);
            btnMahasiswa.TabIndex = 1;
            btnMahasiswa.Text = "Mahasiswa";
            btnMahasiswa.UseVisualStyleBackColor = true;
            btnMahasiswa.Click += new EventHandler(btnMahasiswa_Click);
        }

        private void showBtnDosen(int y)
        {
            btnDosen = new Button();
            panel1.Controls.Add(btnDosen);

            btnDosen.Location = new Point(0, y);
            btnDosen.Name = "btnDosen";
            btnDosen.Size = new Size(155, 61);
            btnDosen.TabIndex = 4;
            btnDosen.Text = "Dosen";
            btnDosen.UseVisualStyleBackColor = true;
            btnDosen.Click += new EventHandler(btnDosen_Click);
        }

        private void showBtnMataKuliah(int y)
        {
            btnMataKuliah = new Button();
            panel1.Controls.Add(btnMataKuliah);

            btnMataKuliah.Location = new Point(0, y);
            btnMataKuliah.Name = "btnMataKuliah";
            btnMataKuliah.Size = new Size(155, 61);
            btnMataKuliah.TabIndex = 5;
            btnMataKuliah.Text = "Mata Kuliah";
            btnMataKuliah.UseVisualStyleBackColor = true;
            btnMataKuliah.Click += new EventHandler(btnMataKuliah_Click);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (selected != 1)
            {
                closeCurrentForm();

                profileForm = new ProfileForm();
                selected = 1;
                profileForm.MdiParent = this;
                profileForm.Show();
            }
        }

        private void btnAbsensi_Click(object sender, EventArgs e)
        {
            if (selected != 2)
            {
                closeCurrentForm();

                absensiForm = new AbsensiForm();
                selected = 2;
                absensiForm.MdiParent = this;
                absensiForm.Show();
            }
        }

        private void btnNilai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            if (selected != 4)
            {
                closeCurrentForm();
                mhsForm.close_child();

                selected = 4;
                mhsForm.MdiParent = this;
                mhsForm.Show();
            }
        }

        private void btnDosen_Click(object sender, EventArgs e)
        {
            
            if (selected != 5)
            {
                closeCurrentForm();
                mhsForm.close_child();

                dosenForm = new DosenForm();
                selected = 5;
                dosenForm.MdiParent = this;
                dosenForm.Show();
            }
        }

        private void btnMataKuliah_Click(object sender, EventArgs e)
        {
           
        }

        private void closeCurrentForm()
        {
            if (selected == 1)
            {
                profileForm.Hide();
            }

            if (selected == 2)
            {
                absensiForm.Hide();
            }

            if (selected == 4)
            {
                mhsForm.Hide();
            }

            if (selected == 5)
            {
                dosenForm.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
