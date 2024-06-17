namespace LibraryManagementSystem
{
    partial class AddBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBooks_importBtn = new System.Windows.Forms.Button();
            this.addBooks_updateBtn = new System.Windows.Forms.Button();
            this.addBooks_addBtn = new System.Windows.Forms.Button();
            this.addBooks_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBooks_published = new System.Windows.Forms.DateTimePicker();
            this.addBooks_clearBtn = new System.Windows.Forms.Button();
            this.addBooks_deleteBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addBooks_author = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addBooks_bookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBooks_picture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(511, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 759);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(617, 647);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "All added Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addBooks_importBtn);
            this.panel1.Controls.Add(this.addBooks_updateBtn);
            this.panel1.Controls.Add(this.addBooks_addBtn);
            this.panel1.Controls.Add(this.addBooks_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addBooks_published);
            this.panel1.Controls.Add(this.addBooks_clearBtn);
            this.panel1.Controls.Add(this.addBooks_deleteBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addBooks_author);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.addBooks_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addBooks_picture);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 759);
            this.panel1.TabIndex = 2;
            // 
            // addBooks_importBtn
            // 
            this.addBooks_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_importBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_importBtn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_importBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_importBtn.Location = new System.Drawing.Point(155, 159);
            this.addBooks_importBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_importBtn.Name = "addBooks_importBtn";
            this.addBooks_importBtn.Size = new System.Drawing.Size(120, 26);
            this.addBooks_importBtn.TabIndex = 22;
            this.addBooks_importBtn.Text = "Import";
            this.addBooks_importBtn.UseVisualStyleBackColor = false;
            this.addBooks_importBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBooks_updateBtn
            // 
            this.addBooks_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_updateBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_updateBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_updateBtn.Location = new System.Drawing.Point(224, 583);
            this.addBooks_updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_updateBtn.Name = "addBooks_updateBtn";
            this.addBooks_updateBtn.Size = new System.Drawing.Size(171, 64);
            this.addBooks_updateBtn.TabIndex = 21;
            this.addBooks_updateBtn.Text = "UPDATE";
            this.addBooks_updateBtn.UseVisualStyleBackColor = false;
            this.addBooks_updateBtn.Click += new System.EventHandler(this.addBooks_updateBtn_Click);
            // 
            // addBooks_addBtn
            // 
            this.addBooks_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_addBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_addBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_addBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_addBtn.Location = new System.Drawing.Point(48, 583);
            this.addBooks_addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_addBtn.Name = "addBooks_addBtn";
            this.addBooks_addBtn.Size = new System.Drawing.Size(171, 64);
            this.addBooks_addBtn.TabIndex = 20;
            this.addBooks_addBtn.Text = "ADD";
            this.addBooks_addBtn.UseVisualStyleBackColor = false;
            this.addBooks_addBtn.Click += new System.EventHandler(this.addBooks_addBtn_Click);
            // 
            // addBooks_status
            // 
            this.addBooks_status.FormattingEnabled = true;
            this.addBooks_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addBooks_status.Location = new System.Drawing.Point(135, 367);
            this.addBooks_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_status.Name = "addBooks_status";
            this.addBooks_status.Size = new System.Drawing.Size(281, 24);
            this.addBooks_status.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status:";
            // 
            // addBooks_published
            // 
            this.addBooks_published.Location = new System.Drawing.Point(135, 325);
            this.addBooks_published.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_published.Name = "addBooks_published";
            this.addBooks_published.Size = new System.Drawing.Size(281, 22);
            this.addBooks_published.TabIndex = 17;
            // 
            // addBooks_clearBtn
            // 
            this.addBooks_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_clearBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_clearBtn.Location = new System.Drawing.Point(224, 654);
            this.addBooks_clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_clearBtn.Name = "addBooks_clearBtn";
            this.addBooks_clearBtn.Size = new System.Drawing.Size(171, 64);
            this.addBooks_clearBtn.TabIndex = 16;
            this.addBooks_clearBtn.Text = "CLEAR";
            this.addBooks_clearBtn.UseVisualStyleBackColor = false;
            this.addBooks_clearBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBooks_deleteBtn
            // 
            this.addBooks_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_deleteBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_deleteBtn.Location = new System.Drawing.Point(48, 654);
            this.addBooks_deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_deleteBtn.Name = "addBooks_deleteBtn";
            this.addBooks_deleteBtn.Size = new System.Drawing.Size(171, 64);
            this.addBooks_deleteBtn.TabIndex = 15;
            this.addBooks_deleteBtn.Text = "DELETE";
            this.addBooks_deleteBtn.UseVisualStyleBackColor = false;
            this.addBooks_deleteBtn.Click += new System.EventHandler(this.addBooks_deleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Published:";
            // 
            // addBooks_author
            // 
            this.addBooks_author.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_author.Location = new System.Drawing.Point(135, 279);
            this.addBooks_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBooks_author.Name = "addBooks_author";
            this.addBooks_author.Size = new System.Drawing.Size(281, 27);
            this.addBooks_author.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Author:";
            // 
            // addBooks_bookTitle
            // 
            this.addBooks_bookTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_bookTitle.Location = new System.Drawing.Point(135, 230);
            this.addBooks_bookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBooks_bookTitle.Name = "addBooks_bookTitle";
            this.addBooks_bookTitle.Size = new System.Drawing.Size(281, 27);
            this.addBooks_bookTitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book Title:";
            // 
            // addBooks_picture
            // 
            this.addBooks_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addBooks_picture.Location = new System.Drawing.Point(155, 39);
            this.addBooks_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBooks_picture.Name = "addBooks_picture";
            this.addBooks_picture.Size = new System.Drawing.Size(120, 121);
            this.addBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBooks_picture.TabIndex = 8;
            this.addBooks_picture.TabStop = false;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddBooks";
            this.Size = new System.Drawing.Size(1207, 795);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBooks_clearBtn;
        private System.Windows.Forms.Button addBooks_deleteBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addBooks_author;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addBooks_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox addBooks_picture;
        private System.Windows.Forms.ComboBox addBooks_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker addBooks_published;
        private System.Windows.Forms.Button addBooks_updateBtn;
        private System.Windows.Forms.Button addBooks_addBtn;
        private System.Windows.Forms.Button addBooks_importBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
