﻿namespace _5_het_gyakorlat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            valaszGomb1 = new ValaszGomb();
            valaszGomb2 = new ValaszGomb();
            valaszGomb3 = new ValaszGomb();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // valaszGomb1
            // 
            valaszGomb1.BackColor = Color.LightCoral;
            valaszGomb1.BorderStyle = BorderStyle.None;
            valaszGomb1.Location = new Point(12, 143);
            valaszGomb1.Multiline = true;
            valaszGomb1.Name = "valaszGomb1";
            valaszGomb1.ReadOnly = true;
            valaszGomb1.Size = new Size(345, 60);
            valaszGomb1.TabIndex = 0;
            // 
            // valaszGomb2
            // 
            valaszGomb2.BackColor = Color.LightCoral;
            valaszGomb2.BorderStyle = BorderStyle.None;
            valaszGomb2.Location = new Point(12, 239);
            valaszGomb2.Multiline = true;
            valaszGomb2.Name = "valaszGomb2";
            valaszGomb2.ReadOnly = true;
            valaszGomb2.Size = new Size(345, 59);
            valaszGomb2.TabIndex = 1;
            // 
            // valaszGomb3
            // 
            valaszGomb3.BackColor = Color.LightCoral;
            valaszGomb3.BorderStyle = BorderStyle.None;
            valaszGomb3.Location = new Point(12, 329);
            valaszGomb3.Multiline = true;
            valaszGomb3.Name = "valaszGomb3";
            valaszGomb3.ReadOnly = true;
            valaszGomb3.Size = new Size(345, 65);
            valaszGomb3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(423, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 323);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(valaszGomb3);
            Controls.Add(valaszGomb2);
            Controls.Add(valaszGomb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ValaszGomb valaszGomb1;
        private ValaszGomb valaszGomb2;
        private ValaszGomb valaszGomb3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
