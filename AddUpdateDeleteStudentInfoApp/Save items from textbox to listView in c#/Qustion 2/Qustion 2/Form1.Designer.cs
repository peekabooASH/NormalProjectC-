namespace Qustion_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Addnewbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(185, 50);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(433, 20);
            this.nametxt.TabIndex = 3;
            // 
            // numbertxt
            // 
            this.numbertxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numbertxt.Location = new System.Drawing.Point(185, 91);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(433, 20);
            this.numbertxt.TabIndex = 4;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(185, 138);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(433, 20);
            this.emailtxt.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentName,
            this.Number,
            this.Email});
            this.listView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(572, 164);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // StudentName
            // 
            this.StudentName.Text = "Student Name";
            this.StudentName.Width = 164;
            // 
            // Number
            // 
            this.Number.Text = "Contact Number";
            this.Number.Width = 199;
            // 
            // Email
            // 
            this.Email.Tag = "";
            this.Email.Text = "Email Adress";
            this.Email.Width = 204;
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Updatebtn.Location = new System.Drawing.Point(414, 164);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(205, 27);
            this.Updatebtn.TabIndex = 7;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancelbtn.Location = new System.Drawing.Point(414, 193);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(205, 27);
            this.Cancelbtn.TabIndex = 8;
            this.Cancelbtn.Text = "CANCEL";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Savebtn.Location = new System.Drawing.Point(185, 164);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(205, 27);
            this.Savebtn.TabIndex = 9;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Addnewbtn
            // 
            this.Addnewbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Addnewbtn.Location = new System.Drawing.Point(185, 193);
            this.Addnewbtn.Name = "Addnewbtn";
            this.Addnewbtn.Size = new System.Drawing.Size(205, 27);
            this.Addnewbtn.TabIndex = 10;
            this.Addnewbtn.Text = "Add New";
            this.Addnewbtn.UseVisualStyleBackColor = false;
            this.Addnewbtn.Click += new System.EventHandler(this.Addnewbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(653, 402);
            this.Controls.Add(this.Addnewbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Form Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button Addnewbtn;
    }
}

