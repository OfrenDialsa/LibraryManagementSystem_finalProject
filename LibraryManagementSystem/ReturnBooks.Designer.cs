namespace LibraryManagementSystem
{
    partial class ReturnBooks
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
            this.returnBooks_clearBtn = new System.Windows.Forms.Button();
            this.returnBooks_returnBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.returnBooks_author = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.returnBooks_bookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returnBooks_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.returnBooks_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.returnBooks_contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBooks_issueId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnBooks_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.returnBooks_IssueDate);
            this.panel1.Controls.Add(this.returnBooks_clearBtn);
            this.panel1.Controls.Add(this.returnBooks_returnBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.returnBooks_author);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.returnBooks_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.returnBooks_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.returnBooks_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.returnBooks_contact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.returnBooks_issueId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 759);
            this.panel1.TabIndex = 0;
            // 
            // returnBooks_clearBtn
            // 
            this.returnBooks_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.returnBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_clearBtn.Location = new System.Drawing.Point(229, 533);
            this.returnBooks_clearBtn.Name = "returnBooks_clearBtn";
            this.returnBooks_clearBtn.Size = new System.Drawing.Size(170, 64);
            this.returnBooks_clearBtn.TabIndex = 16;
            this.returnBooks_clearBtn.Text = "CLEAR";
            this.returnBooks_clearBtn.UseVisualStyleBackColor = false;
            this.returnBooks_clearBtn.Click += new System.EventHandler(this.returnBooks_clearBtn_Click_1);
            // 
            // returnBooks_returnBtn
            // 
            this.returnBooks_returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.returnBooks_returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_returnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_returnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_returnBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_returnBtn.Location = new System.Drawing.Point(36, 533);
            this.returnBooks_returnBtn.Name = "returnBooks_returnBtn";
            this.returnBooks_returnBtn.Size = new System.Drawing.Size(170, 64);
            this.returnBooks_returnBtn.TabIndex = 15;
            this.returnBooks_returnBtn.Text = "RETURN";
            this.returnBooks_returnBtn.UseVisualStyleBackColor = false;
            this.returnBooks_returnBtn.Click += new System.EventHandler(this.returnBooks_returnBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Book Issued:";
            // 
            // returnBooks_author
            // 
            this.returnBooks_author.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_author.Location = new System.Drawing.Point(135, 339);
            this.returnBooks_author.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_author.Name = "returnBooks_author";
            this.returnBooks_author.Size = new System.Drawing.Size(281, 27);
            this.returnBooks_author.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Author:";
            // 
            // returnBooks_bookTitle
            // 
            this.returnBooks_bookTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_bookTitle.Location = new System.Drawing.Point(137, 290);
            this.returnBooks_bookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_bookTitle.Name = "returnBooks_bookTitle";
            this.returnBooks_bookTitle.Size = new System.Drawing.Size(279, 27);
            this.returnBooks_bookTitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book Title:";
            // 
            // returnBooks_email
            // 
            this.returnBooks_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_email.Location = new System.Drawing.Point(137, 241);
            this.returnBooks_email.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_email.Name = "returnBooks_email";
            this.returnBooks_email.Size = new System.Drawing.Size(279, 27);
            this.returnBooks_email.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // returnBooks_name
            // 
            this.returnBooks_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_name.Location = new System.Drawing.Point(135, 145);
            this.returnBooks_name.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_name.Name = "returnBooks_name";
            this.returnBooks_name.Size = new System.Drawing.Size(281, 27);
            this.returnBooks_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // returnBooks_contact
            // 
            this.returnBooks_contact.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_contact.Location = new System.Drawing.Point(135, 191);
            this.returnBooks_contact.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_contact.Name = "returnBooks_contact";
            this.returnBooks_contact.Size = new System.Drawing.Size(281, 27);
            this.returnBooks_contact.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact #:";
            // 
            // returnBooks_issueId
            // 
            this.returnBooks_issueId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_issueId.Location = new System.Drawing.Point(135, 100);
            this.returnBooks_issueId.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_issueId.Name = "returnBooks_issueId";
            this.returnBooks_issueId.Size = new System.Drawing.Size(281, 27);
            this.returnBooks_issueId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Issued ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(511, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 759);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "All returned Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 648);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // returnBooks_IssueDate
            // 
            this.returnBooks_IssueDate.Location = new System.Drawing.Point(135, 391);
            this.returnBooks_IssueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnBooks_IssueDate.Name = "returnBooks_IssueDate";
            this.returnBooks_IssueDate.Size = new System.Drawing.Size(281, 22);
            this.returnBooks_IssueDate.TabIndex = 23;
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnBooks";
            this.Size = new System.Drawing.Size(1207, 795);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox returnBooks_issueId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnBooks_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox returnBooks_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox returnBooks_contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnBooks_returnBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox returnBooks_author;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox returnBooks_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button returnBooks_clearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker returnBooks_IssueDate;
    }
}
