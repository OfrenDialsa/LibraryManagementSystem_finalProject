using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    
    public partial class MainForm : Form
    {
        string num = "yes";
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = true;
            returnBooks1.Visible = false;
            issuedBooks1.Visible = false;

            AddBooks aform = addBooks1 as AddBooks;
            if (aform != null) 
            {
                aform.RefreshData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                loginForm lForm = new loginForm();
                lForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible= true;
            addBooks1.Visible= false;
            returnBooks1.Visible = false;
            issuedBooks1.Visible= false;

            Dashboard dform = dashboard1 as Dashboard;
            if (dform != null)
            {
                dform.RefreshData();
            }
        }

        private void issueBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issuedBooks1.Visible = true;

            ReturnBooks rform = returnBooks1 as ReturnBooks;
            if (rform != null)
            {
                rform.RefreshData();
            }
        }

        private void returnBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = true;
            issuedBooks1.Visible = false;

            IssuedBooks iform = issuedBooks1 as IssuedBooks;
            if (iform != null)
            {
                iform.RefreshData();
            }
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
