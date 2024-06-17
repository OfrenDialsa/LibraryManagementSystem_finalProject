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
    public partial class ReturnBooks : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project Kuliah\Pvisual\Tugas Akhir\Tugas final\LibraryManagementSystem\LibraryManagementSystem\Database\library.mdf;Integrated Security=True;Connect Timeout=30;encrypt=false;");
        public ReturnBooks()
        {
            InitializeComponent();
            displayIssuedBooksData();
        }

        public void RefreshData()
        {
            if (InvokeRequired) 
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayIssuedBooksData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            if (returnBooks_issueId.Text == "" 
                ||returnBooks_name.Text == ""
                ||returnBooks_contact.Text == ""
                ||returnBooks_email.Text == ""
                ||returnBooks_bookTitle.Text == ""
                ||returnBooks_author.Text == ""
                ||returnBooks_IssueDate.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) 
                {
                    DialogResult check = MessageBox.Show("Are you sure that Issue ID: " + returnBooks_issueId.Text.Trim() + 
                        " is return already?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            connect.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @date_update" +
                                " WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@date_update", today);
                                cmd.Parameters.AddWithValue("@issueID", returnBooks_issueId.Text.Trim());
                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();

                                MessageBox.Show("Return Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearfields();

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
            }
        }

        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();
            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBooks_issueId.Text = row.Cells[1].Value.ToString();
                returnBooks_name.Text = row.Cells[2].Value.ToString();
                returnBooks_contact.Text = row.Cells[3].Value.ToString();
                returnBooks_email.Text = row.Cells[4].Value.ToString();
                returnBooks_bookTitle.Text = row.Cells[5].Value.ToString();
                returnBooks_author.Text = row.Cells[6].Value.ToString();
                returnBooks_IssueDate.Text = row.Cells[7].Value.ToString();

            }
        }

        private void returnBooks_clearBtn_Click(object sender, EventArgs e)
        {
            
        }

        public void clearfields()
        {
            returnBooks_issueId.Text = "";
            returnBooks_name.Text = "";
            returnBooks_contact.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
            returnBooks_author.Text = "";
        }

        private void returnBooks_clearBtn_Click_1(object sender, EventArgs e)
        {
            returnBooks_issueId.Text = "";
            returnBooks_name.Text = "";
            returnBooks_contact.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
            returnBooks_author.Text = "";
        }
    }
}
