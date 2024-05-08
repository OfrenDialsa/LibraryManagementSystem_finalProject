namespace LibraryManagementSystem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.issueBooks_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.issuedBooks1 = new LibraryManagementSystem.IssuedBooks();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 55);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System | Main Form";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1500, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.issueBooks_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 795);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 737);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Log Out";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_32px;
            this.logout_btn.Location = new System.Drawing.Point(17, 721);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(60, 55);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.returnBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks_btn.Location = new System.Drawing.Point(29, 475);
            this.returnBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(287, 74);
            this.returnBooks_btn.TabIndex = 6;
            this.returnBooks_btn.Text = "RETURN BOOKS";
            this.returnBooks_btn.UseVisualStyleBackColor = true;
            this.returnBooks_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // issueBooks_btn
            // 
            this.issueBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.issueBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.issueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBooks_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBooks_btn.ForeColor = System.Drawing.Color.White;
            this.issueBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.issueBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBooks_btn.Location = new System.Drawing.Point(29, 394);
            this.issueBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.issueBooks_btn.Name = "issueBooks_btn";
            this.issueBooks_btn.Size = new System.Drawing.Size(287, 74);
            this.issueBooks_btn.TabIndex = 5;
            this.issueBooks_btn.Text = "ISSUE BOOKS";
            this.issueBooks_btn.UseVisualStyleBackColor = true;
            this.issueBooks_btn.Click += new System.EventHandler(this.issueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(29, 313);
            this.addBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(287, 74);
            this.addBooks_btn.TabIndex = 4;
            this.addBooks_btn.Text = "ADD BOOKS";
            this.addBooks_btn.UseVisualStyleBackColor = true;
            this.addBooks_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(29, 232);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(287, 74);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(59, 173);
            this.greet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(223, 34);
            this.greet_label.TabIndex = 2;
            this.greet_label.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(88, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(343, 55);
            this.returnBooks1.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(1207, 795);
            this.returnBooks1.TabIndex = 2;
            // 
            // issuedBooks1
            // 
            this.issuedBooks1.Location = new System.Drawing.Point(343, 55);
            this.issuedBooks1.Name = "issuedBooks1";
            this.issuedBooks1.Size = new System.Drawing.Size(1207, 795);
            this.issuedBooks1.TabIndex = 3;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(343, 55);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(1207, 795);
            this.addBooks1.TabIndex = 4;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(343, 55);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1207, 795);
            this.dashboard1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 850);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.addBooks1);
            this.Controls.Add(this.issuedBooks1);
            this.Controls.Add(this.returnBooks1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Button issueBooks_btn;
        private System.Windows.Forms.Button returnBooks_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private ReturnBooks returnBooks1;
        private IssuedBooks issuedBooks1;
        private AddBooks addBooks1;
        private Dashboard dashboard1;
    }
}