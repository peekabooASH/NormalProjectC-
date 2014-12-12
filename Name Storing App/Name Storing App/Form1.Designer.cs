namespace Name_Storing_App
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.addData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.lebelCount = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.showListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.addData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.lebelCount);
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.addText);
            this.groupBox1.Location = new System.Drawing.Point(56, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(159, 14);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 38);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add no. of Name";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // addData
            // 
            this.addData.Location = new System.Drawing.Point(105, 14);
            this.addData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(44, 20);
            this.addData.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(157, 104);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // lebelCount
            // 
            this.lebelCount.AutoSize = true;
            this.lebelCount.Location = new System.Drawing.Point(72, 79);
            this.lebelCount.Name = "lebelCount";
            this.lebelCount.Size = new System.Drawing.Size(0, 13);
            this.lebelCount.TabIndex = 3;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Location = new System.Drawing.Point(6, 92);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(60, 13);
            this.show.TabIndex = 2;
            this.show.Text = "Add Count:";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(157, 69);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Name";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(6, 69);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(133, 20);
            this.addText.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(214, 151);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showListbox
            // 
            this.showListbox.FormattingEnabled = true;
            this.showListbox.Location = new System.Drawing.Point(56, 185);
            this.showListbox.Name = "showListbox";
            this.showListbox.Size = new System.Drawing.Size(233, 121);
            this.showListbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter no. of name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Names:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 333);
            this.Controls.Add(this.showListbox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Name Storing App UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label lebelCount;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox showListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

