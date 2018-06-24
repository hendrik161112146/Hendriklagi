using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mika_desktop.Dataset;

namespace mika_desktop.Login
{
    public partial class LoginForm : Form
    {
        public static DataSetMIKA dsMIKA;
        private int[] Role = { 1, 2, 3 };


        public LoginForm()
        {
            InitializeComponent();
            dsMIKA = new DataSetMIKA();
        }

        public class User // Just for testing for now before using real DB
        {
            public string username { set; get; }
            public string password { set; get; }
            public int role { set; get; }

            public User(string username, string password, int role)
            {
                this.username = username;
                this.password = password;
                this.role = role;
            }
        }

        private void fillData() // Just for testing for now before using real DB
        {
            List<User> list = new List<User>();
            list.Add(new User("jono", "123", 1));
            list.Add(new User("andi", "111", 2));
            list.Add(new User("joko", "000", 2));
            list.Add(new User("ronaldo", "777", 3));
            list.Add(new User("toni", "555", 3));

            foreach (User i in list)
            {
                dsMIKA.Tables["User"].Rows.Add(i.username, i.password, i.role.ToString());                
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
            fillData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                DataRow[] result = dsMIKA.Tables["User"].Select("Username like '%" + username +
                "%' and Password like '%" + password + "%'");

                if (result.Length > 0)
                {
                    foreach (DataRow i in result)
                    {
                        Hide();
                        BaseForm baseForm = new BaseForm(Convert.ToInt32(i["Role"]));
                        baseForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("OOps", "Wrong Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUsername.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Credentials!", "Wrong Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsername.Focus();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if(username == "" || password == "")
                {
                    MessageBox.Show("Form can\'t be empty", "Form empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnLogin_Click(this, new EventArgs());
                }
            }
        }

        private void tbUsername_KeyUp(object sender, KeyEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (username == "" || password == "")
                {
                    MessageBox.Show("Form can\'t be empty", "Form empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnLogin_Click(this, new EventArgs());
                }
            }
        }
    }
}
