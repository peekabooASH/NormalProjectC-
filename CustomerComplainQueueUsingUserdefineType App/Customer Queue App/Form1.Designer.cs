namespace Customer_Queue_App
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.complainText2 = new System.Windows.Forms.TextBox();
            this.nameText2 = new System.Windows.Forms.TextBox();
            this.serialText = new System.Windows.Forms.TextBox();
            this.label2Complain = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.labelSerial = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.complainText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.labelComplain = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 166);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(10, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 140);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.complainText2);
            this.groupBox2.Controls.Add(this.nameText2);
            this.groupBox2.Controls.Add(this.serialText);
            this.groupBox2.Controls.Add(this.label2Complain);
            this.groupBox2.Controls.Add(this.label2Name);
            this.groupBox2.Controls.Add(this.labelSerial);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DeQueue Customer";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dequeueButton.Location = new System.Drawing.Point(201, 9);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(101, 34);
            this.dequeueButton.TabIndex = 6;
            this.dequeueButton.Text = "DeQueue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // complainText2
            // 
            this.complainText2.Location = new System.Drawing.Point(92, 88);
            this.complainText2.Name = "complainText2";
            this.complainText2.Size = new System.Drawing.Size(177, 20);
            this.complainText2.TabIndex = 5;
            // 
            // nameText2
            // 
            this.nameText2.Location = new System.Drawing.Point(92, 54);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(177, 20);
            this.nameText2.TabIndex = 4;
            // 
            // serialText
            // 
            this.serialText.Location = new System.Drawing.Point(92, 20);
            this.serialText.Name = "serialText";
            this.serialText.Size = new System.Drawing.Size(69, 20);
            this.serialText.TabIndex = 3;
            // 
            // label2Complain
            // 
            this.label2Complain.AutoSize = true;
            this.label2Complain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Complain.Location = new System.Drawing.Point(7, 91);
            this.label2Complain.Name = "label2Complain";
            this.label2Complain.Size = new System.Drawing.Size(66, 13);
            this.label2Complain.TabIndex = 2;
            this.label2Complain.Text = "Complain :";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Name.Location = new System.Drawing.Point(7, 62);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(51, 13);
            this.label2Name.TabIndex = 1;
            this.label2Name.Text = "Name : ";
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerial.Location = new System.Drawing.Point(7, 28);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(67, 13);
            this.labelSerial.TabIndex = 0;
            this.labelSerial.Text = "Serial No :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.complainText);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.labelComplain);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EnQueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(80, 100);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(91, 35);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "EnQueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // complainText
            // 
            this.complainText.Location = new System.Drawing.Point(80, 62);
            this.complainText.Name = "complainText";
            this.complainText.Size = new System.Drawing.Size(170, 20);
            this.complainText.TabIndex = 3;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(80, 28);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(170, 20);
            this.nameText.TabIndex = 2;
            // 
            // labelComplain
            // 
            this.labelComplain.AutoSize = true;
            this.labelComplain.Location = new System.Drawing.Point(7, 70);
            this.labelComplain.Name = "labelComplain";
            this.labelComplain.Size = new System.Drawing.Size(66, 13);
            this.labelComplain.TabIndex = 1;
            this.labelComplain.Text = "Complain :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 342);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox complainText2;
        private System.Windows.Forms.TextBox nameText2;
        private System.Windows.Forms.TextBox serialText;
        private System.Windows.Forms.Label label2Complain;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox complainText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label labelComplain;
        private System.Windows.Forms.Label labelName;

    }
}

