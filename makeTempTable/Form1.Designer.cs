namespace makeTempTable
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiaddwith = new System.Windows.Forms.RadioButton();
            this.uiaddtemporytable = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.uiAutoToNumber = new System.Windows.Forms.CheckBox();
            this.chkExistHeader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 105);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(260, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(12, 183);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(562, 105);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "results will copy to clipboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "output";
            // 
            // uiaddwith
            // 
            this.uiaddwith.AutoSize = true;
            this.uiaddwith.Checked = true;
            this.uiaddwith.Location = new System.Drawing.Point(12, 8);
            this.uiaddwith.Name = "uiaddwith";
            this.uiaddwith.Size = new System.Drawing.Size(106, 16);
            this.uiaddwith.TabIndex = 8;
            this.uiaddwith.TabStop = true;
            this.uiaddwith.Text = "add with script";
            this.uiaddwith.UseVisualStyleBackColor = true;
            this.uiaddwith.CheckedChanged += new System.EventHandler(this.uiaddwith_CheckedChanged);
            // 
            // uiaddtemporytable
            // 
            this.uiaddtemporytable.AutoSize = true;
            this.uiaddtemporytable.Location = new System.Drawing.Point(12, 30);
            this.uiaddtemporytable.Name = "uiaddtemporytable";
            this.uiaddtemporytable.Size = new System.Drawing.Size(160, 16);
            this.uiaddtemporytable.TabIndex = 9;
            this.uiaddtemporytable.Text = "add tempory table script";
            this.uiaddtemporytable.UseVisualStyleBackColor = true;
            this.uiaddtemporytable.CheckedChanged += new System.EventHandler(this.uiaddtemporytable_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(208, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uiAutoToNumber
            // 
            this.uiAutoToNumber.AutoSize = true;
            this.uiAutoToNumber.Location = new System.Drawing.Point(408, 3);
            this.uiAutoToNumber.Name = "uiAutoToNumber";
            this.uiAutoToNumber.Size = new System.Drawing.Size(114, 16);
            this.uiAutoToNumber.TabIndex = 11;
            this.uiAutoToNumber.Text = "Auto to_Number";
            this.uiAutoToNumber.UseVisualStyleBackColor = true;
            // 
            // chkExistHeader
            // 
            this.chkExistHeader.AutoSize = true;
            this.chkExistHeader.Location = new System.Drawing.Point(408, 19);
            this.chkExistHeader.Name = "chkExistHeader";
            this.chkExistHeader.Size = new System.Drawing.Size(95, 16);
            this.chkExistHeader.TabIndex = 12;
            this.chkExistHeader.Text = "header Exist";
            this.chkExistHeader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 297);
            this.Controls.Add(this.chkExistHeader);
            this.Controls.Add(this.uiAutoToNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiaddtemporytable);
            this.Controls.Add(this.uiaddwith);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Excel To TempTableScript Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton uiaddwith;
        private System.Windows.Forms.RadioButton uiaddtemporytable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox uiAutoToNumber;
        private System.Windows.Forms.CheckBox chkExistHeader;
    }
}

