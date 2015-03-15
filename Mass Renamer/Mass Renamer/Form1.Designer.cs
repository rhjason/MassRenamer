namespace Mass_Renamer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStarting = new System.Windows.Forms.TextBox();
            this.textBoxEnding = new System.Windows.Forms.TextBox();
            this.textBoxSignificand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(68, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 225);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(349, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(163, 225);
            this.listBox2.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(105, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(208, 380);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(163, 47);
            this.buttonRename.TabIndex = 4;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter starting value, ending value and significands";
            // 
            // textBoxStarting
            // 
            this.textBoxStarting.Location = new System.Drawing.Point(349, 34);
            this.textBoxStarting.Name = "textBoxStarting";
            this.textBoxStarting.Size = new System.Drawing.Size(48, 20);
            this.textBoxStarting.TabIndex = 6;
            this.textBoxStarting.TextChanged += new System.EventHandler(this.textBoxStarting_TextChanged);
            // 
            // textBoxEnding
            // 
            this.textBoxEnding.Location = new System.Drawing.Point(403, 34);
            this.textBoxEnding.Name = "textBoxEnding";
            this.textBoxEnding.Size = new System.Drawing.Size(50, 20);
            this.textBoxEnding.TabIndex = 7;
            this.textBoxEnding.TextChanged += new System.EventHandler(this.textBoxEnding_TextChanged);
            // 
            // textBoxSignificand
            // 
            this.textBoxSignificand.Location = new System.Drawing.Point(487, 34);
            this.textBoxSignificand.Name = "textBoxSignificand";
            this.textBoxSignificand.Size = new System.Drawing.Size(25, 20);
            this.textBoxSignificand.TabIndex = 8;
            this.textBoxSignificand.TextChanged += new System.EventHandler(this.textBoxSignificand_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.textBoxSignificand);
            this.Controls.Add(this.textBoxEnding);
            this.Controls.Add(this.textBoxStarting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStarting;
        private System.Windows.Forms.TextBox textBoxEnding;
        private System.Windows.Forms.TextBox textBoxSignificand;
    }
}

