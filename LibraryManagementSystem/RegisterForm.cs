using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project Kuliah\Pvisual\Tugas akhir\Tugas final\LibraryManagementSystem\LibraryManagementSystem\Database\library.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            loginForm lForm = new loginForm();
            lForm.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String checkUsername = "select count(*) from users where username = @username";
                        using(SqlCommand checkCMD = new SqlCommand(checkUsername, connect))
                        {
                            checkCMD.Parameters.AddWithValue("@username", register_username.Text.Trim());
                            int count = (int) checkCMD.ExecuteScalar();

                            if (count >= 1) 
                            {
                                MessageBox.Show("Username " +'"'+ register_username.Text.Trim() +'"' + " has already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                            } else
                            {
                                //Untuk mendapatkan data tanggal hari ini
                                DateTime day = DateTime.Today;

                                string insertData = "insert into users (email, username, password, date_register) " + "values (@email, @username, @password, @date)";
                                using (SqlCommand insertCMD = new SqlCommand(insertData, connect))
                                {
                                    insertCMD.Parameters.AddWithValue("@email", register_email.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Register succesfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    loginForm loginForm = new loginForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }catch(Exception ex) 
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
