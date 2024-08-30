namespace assignment_manager
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
            this.btn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EntryField2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.EntryField3 = new System.Windows.Forms.TextBox();
            this.Lb1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EntryField1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Academic Subject";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(427, 376);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Write to CSV";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assignment";
            // 
            // EntryField2
            // 
            this.EntryField2.Location = new System.Drawing.Point(605, 43);
            this.EntryField2.Name = "EntryField2";
            this.EntryField2.Size = new System.Drawing.Size(183, 22);
            this.EntryField2.TabIndex = 5;
            this.EntryField2.Text = "Enter Assigment Name:";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(533, 376);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(125, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Write to List View";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(13, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 397);
            this.tabControl1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Assigment Details";
            // 
            // EntryField3
            // 
            this.EntryField3.Location = new System.Drawing.Point(605, 73);
            this.EntryField3.Multiline = true;
            this.EntryField3.Name = "EntryField3";
            this.EntryField3.Size = new System.Drawing.Size(183, 22);
            this.EntryField3.TabIndex = 9;
            this.EntryField3.Text = "Enter details here:";
            // 
            // Lb1
            // 
            this.Lb1.FormattingEnabled = true;
            this.Lb1.ItemHeight = 16;
            this.Lb1.Location = new System.Drawing.Point(668, 163);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(120, 84);
            this.Lb1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subjects";
            // 
            // EntryField1
            // 
            this.EntryField1.Location = new System.Drawing.Point(605, 106);
            this.EntryField1.Name = "EntryField1";
            this.EntryField1.Size = new System.Drawing.Size(183, 22);
            this.EntryField1.TabIndex = 12;
            this.EntryField1.Text = "Enter Subjects:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(605, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(681, 375);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(107, 23);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "Write to Combo";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EntryField1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.EntryField3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.EntryField2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EntryField2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EntryField3;
        private System.Windows.Forms.ListBox Lb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EntryField1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn3;
    }
}

