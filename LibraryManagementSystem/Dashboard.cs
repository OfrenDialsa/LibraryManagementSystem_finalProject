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
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project Kuliah\Pvisual\Tugas Akhir\Tugas final\LibraryManagementSystem\LibraryManagementSystem\Database\library.mdf;Integrated Security=True;Connect Timeout=30;encrypt=false;");
        public Dashboard()
        {
            InitializeComponent();

            displayAB();
            displayIB();
            displayRB();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayAB();
            displayIB();
            displayRB();
        }

        public void displayAB()
        {
            if (connect.State == ConnectionState.Closed) 
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT (id) FROM books " +
                        "WHERE status = 'Available' AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempAB = 0;

                        if (reader.Read())
                        {
                            tempAB = Convert.ToInt32(reader[0]);
                            dashboardAB.Text = tempAB.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayIB()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT (id) FROM issues " +
                        "WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempIB = 0;

                        if (reader.Read())
                        {
                            tempIB = Convert.ToInt32(reader[0]);
                            dashboardIB.Text = tempIB.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayRB()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT (id) FROM issues " +
                        "WHERE status = 'Return' AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempRB = 0;

                        if (reader.Read())
                        {
                            tempRB = Convert.ToInt32(reader[0]);
                            dashboardRB.Text = tempRB.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
