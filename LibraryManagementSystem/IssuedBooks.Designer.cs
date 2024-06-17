using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class IssuedBooks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookIssue_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bookIssue_clearBtn = new System.Windows.Forms.Button();
            this.bookIssue_deleteBtn = new System.Windows.Forms.Button();
            this.bookIssue_updateBtn = new System.Windows.Forms.Button();
            this.bookIssue_addBtn = new System.Windows.Forms.Button();
            this.bookIssue_returnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.bookIssue_picture = new System.Windows.Forms.PictureBox();
            this.bookIssue_issueDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.bookIssue_author = new System.Windows.Forms.ComboBox();
            this.bookIssue_bookTitle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bookIssue_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookIssue_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookIssue_contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookIssue_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 394);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 298);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Issued Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.bookIssue_status);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.bookIssue_clearBtn);
            this.panel2.Controls.Add(this.bookIssue_deleteBtn);
            this.panel2.Controls.Add(this.bookIssue_updateBtn);
            this.panel2.Controls.Add(this.bookIssue_addBtn);
            this.panel2.Controls.Add(this.bookIssue_returnDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bookIssue_picture);
            this.panel2.Controls.Add(this.bookIssue_issueDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bookIssue_author);
            this.panel2.Controls.Add(this.bookIssue_bookTitle);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bookIssue_email);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bookIssue_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bookIssue_contact);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bookIssue_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(28, 438);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 336);
            this.panel2.TabIndex = 1;
            // 
            // bookIssue_status
            // 
            this.bookIssue_status.FormattingEnabled = true;
            this.bookIssue_status.Items.AddRange(new object[] {
            "Return",
            "Not Return"});
            this.bookIssue_status.Location = new System.Drawing.Point(781, 31);
            this.bookIssue_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_status.Name = "bookIssue_status";
            this.bookIssue_status.Size = new System.Drawing.Size(209, 30);
            this.bookIssue_status.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(709, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Status:";
            // 
            // bookIssue_clearBtn
            // 
            this.bookIssue_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_clearBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_clearBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_clearBtn.Location = new System.Drawing.Point(787, 249);
            this.bookIssue_clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_clearBtn.Name = "bookIssue_clearBtn";
            this.bookIssue_clearBtn.Size = new System.Drawing.Size(171, 62);
            this.bookIssue_clearBtn.TabIndex = 29;
            this.bookIssue_clearBtn.Text = "CLEAR";
            this.bookIssue_clearBtn.UseVisualStyleBackColor = false;
            this.bookIssue_clearBtn.Click += new System.EventHandler(this.bookIssue_clearBtn_Click);
            // 
            // bookIssue_deleteBtn
            // 
            this.bookIssue_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_deleteBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_deleteBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_deleteBtn.Location = new System.Drawing.Point(588, 249);
            this.bookIssue_deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_deleteBtn.Name = "bookIssue_deleteBtn";
            this.bookIssue_deleteBtn.Size = new System.Drawing.Size(171, 62);
            this.bookIssue_deleteBtn.TabIndex = 28;
            this.bookIssue_deleteBtn.Text = "DELETE";
            this.bookIssue_deleteBtn.UseVisualStyleBackColor = false;
            this.bookIssue_deleteBtn.Click += new System.EventHandler(this.bookIssue_deleteBtn_Click);
            // 
            // bookIssue_updateBtn
            // 
            this.bookIssue_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_updateBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_updateBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_updateBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_updateBtn.Location = new System.Drawing.Point(391, 249);
            this.bookIssue_updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_updateBtn.Name = "bookIssue_updateBtn";
            this.bookIssue_updateBtn.Size = new System.Drawing.Size(171, 62);
            this.bookIssue_updateBtn.TabIndex = 27;
            this.bookIssue_updateBtn.Text = "UPDATE";
            this.bookIssue_updateBtn.UseVisualStyleBackColor = false;
            this.bookIssue_updateBtn.Click += new System.EventHandler(this.bookIssue_updateBtn_Click);
            // 
            // bookIssue_addBtn
            // 
            this.bookIssue_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.bookIssue_addBtn.FlatAppearance.BorderSize = 0;
            this.bookIssue_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bookIssue_addBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_addBtn.ForeColor = System.Drawing.Color.White;
            this.bookIssue_addBtn.Location = new System.Drawing.Point(193, 249);
            this.bookIssue_addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_addBtn.Name = "bookIssue_addBtn";
            this.bookIssue_addBtn.Size = new System.Drawing.Size(171, 62);
            this.bookIssue_addBtn.TabIndex = 26;
            this.bookIssue_addBtn.Text = "ADD";
            this.bookIssue_addBtn.UseVisualStyleBackColor = false;
            this.bookIssue_addBtn.Click += new System.EventHandler(this.bookIssue_addBtn_Click);
            // 
            // bookIssue_returnDate
            // 
            this.bookIssue_returnDate.Location = new System.Drawing.Point(447, 175);
            this.bookIssue_returnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_returnDate.Name = "bookIssue_returnDate";
            this.bookIssue_returnDate.Size = new System.Drawing.Size(247, 27);
            this.bookIssue_returnDate.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Return:";
            // 
            // bookIssue_picture
            // 
            this.bookIssue_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bookIssue_picture.Location = new System.Drawing.Point(1011, 33);
            this.bookIssue_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_picture.Name = "bookIssue_picture";
            this.bookIssue_picture.Size = new System.Drawing.Size(117, 145);
            this.bookIssue_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookIssue_picture.TabIndex = 23;
            this.bookIssue_picture.TabStop = false;
            // 
            // bookIssue_issueDate
            // 
            this.bookIssue_issueDate.Location = new System.Drawing.Point(447, 126);
            this.bookIssue_issueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_issueDate.Name = "bookIssue_issueDate";
            this.bookIssue_issueDate.Size = new System.Drawing.Size(247, 27);
            this.bookIssue_issueDate.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Issue:";
            // 
            // bookIssue_author
            // 
            this.bookIssue_author.FormattingEnabled = true;
            this.bookIssue_author.Location = new System.Drawing.Point(447, 75);
            this.bookIssue_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_author.Name = "bookIssue_author";
            this.bookIssue_author.Size = new System.Drawing.Size(209, 30);
            this.bookIssue_author.TabIndex = 20;
            // 
            // bookIssue_bookTitle
            // 
            this.bookIssue_bookTitle.FormattingEnabled = true;
            this.bookIssue_bookTitle.Location = new System.Drawing.Point(448, 30);
            this.bookIssue_bookTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIssue_bookTitle.Name = "bookIssue_bookTitle";
            this.bookIssue_bookTitle.Size = new System.Drawing.Size(209, 30);
            this.bookIssue_bookTitle.TabIndex = 19;
            this.bookIssue_bookTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Book Title:";
            // 
            // bookIssue_email
            // 
            this.bookIssue_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_email.Location = new System.Drawing.Point(121, 170);
            this.bookIssue_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIssue_email.Name = "bookIssue_email";
            this.bookIssue_email.Size = new System.Drawing.Size(208, 27);
            this.bookIssue_email.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // bookIssue_name
            // 
            this.bookIssue_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_name.Location = new System.Drawing.Point(119, 74);
            this.bookIssue_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIssue_name.Name = "bookIssue_name";
            this.bookIssue_name.Size = new System.Drawing.Size(209, 27);
            this.bookIssue_name.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name:";
            // 
            // bookIssue_contact
            // 
            this.bookIssue_contact.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_contact.Location = new System.Drawing.Point(119, 121);
            this.bookIssue_contact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIssue_contact.Name = "bookIssue_contact";
            this.bookIssue_contact.Size = new System.Drawing.Size(209, 27);
            this.bookIssue_contact.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact #:";
            // 
            // bookIssue_id
            // 
            this.bookIssue_id.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIssue_id.Location = new System.Drawing.Point(119, 30);
            this.bookIssue_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIssue_id.Name = "bookIssue_id";
            this.bookIssue_id.Size = new System.Drawing.Size(209, 27);
            this.bookIssue_id.TabIndex = 9;
            this.bookIssue_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Issued ID:";
            // 
            // IssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IssuedBooks";
            this.Size = new System.Drawing.Size(1207, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssue_picture)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bookIssue_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookIssue_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookIssue_contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookIssue_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bookIssue_picture;
        private System.Windows.Forms.DateTimePicker bookIssue_issueDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bookIssue_author;
        private System.Windows.Forms.ComboBox bookIssue_bookTitle;
        private System.Windows.Forms.DateTimePicker bookIssue_returnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bookIssue_clearBtn;
        private System.Windows.Forms.Button bookIssue_deleteBtn;
        private System.Windows.Forms.Button bookIssue_updateBtn;
        private System.Windows.Forms.Button bookIssue_addBtn;
        private System.Windows.Forms.ComboBox bookIssue_status;
        private System.Windows.Forms.Label label10;
        private DataGridView dataGridView1;
    }
}
