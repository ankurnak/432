namespace BinaryDecimalApp
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
            this.SetBinaryString = new System.Windows.Forms.Button();
            this.SetDigit = new System.Windows.Forms.Button();
            this.AddDigit = new System.Windows.Forms.Button();
            this.RemoveLastDigit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBinaryString = new System.Windows.Forms.TextBox();
            this.nudIndex = new System.Windows.Forms.NumericUpDown();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SetBinaryString
            // 
            this.SetBinaryString.Location = new System.Drawing.Point(87, 254);
            this.SetBinaryString.Name = "SetBinaryString";
            this.SetBinaryString.Size = new System.Drawing.Size(75, 23);
            this.SetBinaryString.TabIndex = 0;
            this.SetBinaryString.Text = "SetBinaryString";
            this.SetBinaryString.UseVisualStyleBackColor = true;
            this.SetBinaryString.Click += new System.EventHandler(this.SetBinaryString_Click);
            // 
            // SetDigit
            // 
            this.SetDigit.Location = new System.Drawing.Point(267, 254);
            this.SetDigit.Name = "SetDigit";
            this.SetDigit.Size = new System.Drawing.Size(75, 23);
            this.SetDigit.TabIndex = 1;
            this.SetDigit.Text = "SetDigit";
            this.SetDigit.UseVisualStyleBackColor = true;
            this.SetDigit.Click += new System.EventHandler(this.SetDigit_Click);
            // 
            // AddDigit
            // 
            this.AddDigit.Location = new System.Drawing.Point(465, 254);
            this.AddDigit.Name = "AddDigit";
            this.AddDigit.Size = new System.Drawing.Size(75, 23);
            this.AddDigit.TabIndex = 2;
            this.AddDigit.Text = "AddDigit";
            this.AddDigit.UseVisualStyleBackColor = true;
            this.AddDigit.Click += new System.EventHandler(this.AddDigit_Click);
            // 
            // RemoveLastDigit
            // 
            this.RemoveLastDigit.Location = new System.Drawing.Point(87, 336);
            this.RemoveLastDigit.Name = "RemoveLastDigit";
            this.RemoveLastDigit.Size = new System.Drawing.Size(75, 23);
            this.RemoveLastDigit.TabIndex = 3;
            this.RemoveLastDigit.Text = "RemoveLastDigit";
            this.RemoveLastDigit.UseVisualStyleBackColor = true;
            this.RemoveLastDigit.Click += new System.EventHandler(this.RemoveLastDigit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(267, 336);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(465, 336);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(191, 85);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 22);
            this.lblNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "lblNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "tbBinaryString";
            // 
            // tbBinaryString
            // 
            this.tbBinaryString.Location = new System.Drawing.Point(507, 88);
            this.tbBinaryString.Name = "tbBinaryString";
            this.tbBinaryString.Size = new System.Drawing.Size(100, 22);
            this.tbBinaryString.TabIndex = 9;
            // 
            // nudIndex
            // 
            this.nudIndex.Location = new System.Drawing.Point(176, 166);
            this.nudIndex.Name = "nudIndex";
            this.nudIndex.Size = new System.Drawing.Size(120, 22);
            this.nudIndex.TabIndex = 10;
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(400, 166);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 22);
            this.nudValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "nudIndex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "nudValue";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(635, 254);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(75, 23);
            this.txt.TabIndex = 14;
            this.txt.Text = "txt";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(635, 336);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(75, 23);
            this.img.TabIndex = 15;
            this.img.Text = "img";
            this.img.UseVisualStyleBackColor = true;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(747, 128);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(173, 108);
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 386);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.img);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.nudIndex);
            this.Controls.Add(this.tbBinaryString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.RemoveLastDigit);
            this.Controls.Add(this.AddDigit);
            this.Controls.Add(this.SetDigit);
            this.Controls.Add(this.SetBinaryString);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetBinaryString;
        private System.Windows.Forms.Button SetDigit;
        private System.Windows.Forms.Button AddDigit;
        private System.Windows.Forms.Button RemoveLastDigit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.TextBox lblNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBinaryString;
        private System.Windows.Forms.NumericUpDown nudIndex;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txt;
        private System.Windows.Forms.Button img;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

