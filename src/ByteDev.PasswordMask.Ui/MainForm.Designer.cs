namespace ByteDev.PasswordMask.Ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.thirdNumberTextBox = new System.Windows.Forms.TextBox();
            this.fourthNumberTextBox = new System.Windows.Forms.TextBox();
            this.output1TextBox = new System.Windows.Forms.TextBox();
            this.output2TextBox = new System.Windows.Forms.TextBox();
            this.output3TextBox = new System.Windows.Forms.TextBox();
            this.output4TextBox = new System.Windows.Forms.TextBox();
            this.pasteButton = new System.Windows.Forms.Button();
            this.eyePictureBox = new System.Windows.Forms.PictureBox();
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.passwordLengthToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.generalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(14, 12);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(182, 20);
            this.passwordTextBox.TabIndex = 20;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberTextBox.Location = new System.Drawing.Point(11, 76);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(38, 26);
            this.firstNumberTextBox.TabIndex = 1;
            this.firstNumberTextBox.Text = "1";
            this.firstNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstNumberTextBox_MouseClick);
            this.firstNumberTextBox.TextChanged += new System.EventHandler(this.firstNumberTextBox_TextChanged);
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberTextBox.Location = new System.Drawing.Point(68, 76);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(38, 26);
            this.secondNumberTextBox.TabIndex = 2;
            this.secondNumberTextBox.Text = "1";
            this.secondNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.secondNumberTextBox_MouseClick);
            this.secondNumberTextBox.TextChanged += new System.EventHandler(this.secondNumberTextBox_TextChanged);
            // 
            // thirdNumberTextBox
            // 
            this.thirdNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdNumberTextBox.Location = new System.Drawing.Point(127, 76);
            this.thirdNumberTextBox.Name = "thirdNumberTextBox";
            this.thirdNumberTextBox.Size = new System.Drawing.Size(38, 26);
            this.thirdNumberTextBox.TabIndex = 3;
            this.thirdNumberTextBox.Text = "1";
            this.thirdNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.thirdNumberTextBox_MouseClick);
            this.thirdNumberTextBox.TextChanged += new System.EventHandler(this.thirdNumberTextBox_TextChanged);
            // 
            // fourthNumberTextBox
            // 
            this.fourthNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthNumberTextBox.Location = new System.Drawing.Point(184, 76);
            this.fourthNumberTextBox.Name = "fourthNumberTextBox";
            this.fourthNumberTextBox.Size = new System.Drawing.Size(38, 26);
            this.fourthNumberTextBox.TabIndex = 4;
            this.fourthNumberTextBox.Text = "1";
            this.fourthNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fourthNumberTextBox_MouseClick);
            this.fourthNumberTextBox.TextChanged += new System.EventHandler(this.fourthNumberTextBox_TextChanged);
            // 
            // output1TextBox
            // 
            this.output1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output1TextBox.Location = new System.Drawing.Point(11, 108);
            this.output1TextBox.Name = "output1TextBox";
            this.output1TextBox.Size = new System.Drawing.Size(38, 26);
            this.output1TextBox.TabIndex = 5;
            // 
            // output2TextBox
            // 
            this.output2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output2TextBox.Location = new System.Drawing.Point(68, 108);
            this.output2TextBox.Name = "output2TextBox";
            this.output2TextBox.Size = new System.Drawing.Size(38, 26);
            this.output2TextBox.TabIndex = 6;
            // 
            // output3TextBox
            // 
            this.output3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output3TextBox.Location = new System.Drawing.Point(127, 108);
            this.output3TextBox.Name = "output3TextBox";
            this.output3TextBox.Size = new System.Drawing.Size(38, 26);
            this.output3TextBox.TabIndex = 7;
            // 
            // output4TextBox
            // 
            this.output4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output4TextBox.Location = new System.Drawing.Point(184, 108);
            this.output4TextBox.Name = "output4TextBox";
            this.output4TextBox.Size = new System.Drawing.Size(38, 26);
            this.output4TextBox.TabIndex = 8;
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(68, 38);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(75, 23);
            this.pasteButton.TabIndex = 30;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // eyePictureBox
            // 
            this.eyePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("eyePictureBox.Image")));
            this.eyePictureBox.Location = new System.Drawing.Point(202, 12);
            this.eyePictureBox.Name = "eyePictureBox";
            this.eyePictureBox.Size = new System.Drawing.Size(20, 20);
            this.eyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyePictureBox.TabIndex = 32;
            this.eyePictureBox.TabStop = false;
            this.eyePictureBox.Click += new System.EventHandler(this.eyePictureBox_Click);
            // 
            // checkPasswordButton
            // 
            this.checkPasswordButton.Location = new System.Drawing.Point(151, 38);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(73, 23);
            this.checkPasswordButton.TabIndex = 33;
            this.checkPasswordButton.Text = "Pwned?";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordLengthToolStripStatusLabel,
            this.generalStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 148);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(236, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // passwordLengthToolStripStatusLabel
            // 
            this.passwordLengthToolStripStatusLabel.Name = "passwordLengthToolStripStatusLabel";
            this.passwordLengthToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // generalStatusLabel
            // 
            this.generalStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.generalStatusLabel.Name = "generalStatusLabel";
            this.generalStatusLabel.Size = new System.Drawing.Size(4, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 170);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.eyePictureBox);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.output4TextBox);
            this.Controls.Add(this.output3TextBox);
            this.Controls.Add(this.output2TextBox);
            this.Controls.Add(this.output1TextBox);
            this.Controls.Add(this.fourthNumberTextBox);
            this.Controls.Add(this.thirdNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox thirdNumberTextBox;
        private System.Windows.Forms.TextBox fourthNumberTextBox;
        private System.Windows.Forms.TextBox output1TextBox;
        private System.Windows.Forms.TextBox output2TextBox;
        private System.Windows.Forms.TextBox output3TextBox;
        private System.Windows.Forms.TextBox output4TextBox;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.PictureBox eyePictureBox;
        private System.Windows.Forms.Button checkPasswordButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel passwordLengthToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel generalStatusLabel;
    }
}

