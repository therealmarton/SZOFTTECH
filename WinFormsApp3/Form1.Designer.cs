namespace WinFormsApp3
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
            button1 = new Button();
            tbHaviKamat = new TextBox();
            tbHitelOsszege = new TextBox();
            dataGridView1 = new DataGridView();
            cbHaviTorleszto = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            havit = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 221);
            button1.Name = "button1";
            button1.Size = new Size(114, 74);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbHaviKamat
            // 
            tbHaviKamat.Location = new Point(39, 112);
            tbHaviKamat.Name = "tbHaviKamat";
            tbHaviKamat.Size = new Size(181, 23);
            tbHaviKamat.TabIndex = 1;
            // 
            // tbHitelOsszege
            // 
            tbHitelOsszege.Location = new Point(39, 58);
            tbHitelOsszege.Name = "tbHitelOsszege";
            tbHitelOsszege.Size = new Size(181, 23);
            tbHitelOsszege.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 365);
            dataGridView1.TabIndex = 3;
            // 
            // cbHaviTorleszto
            // 
            cbHaviTorleszto.FormattingEnabled = true;
            cbHaviTorleszto.Location = new Point(39, 174);
            cbHaviTorleszto.Name = "cbHaviTorleszto";
            cbHaviTorleszto.Size = new Size(121, 23);
            cbHaviTorleszto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 40);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "hitel osszege";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 94);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "havikamat";
            // 
            // havit
            // 
            havit.AutoSize = true;
            havit.Location = new Point(39, 156);
            havit.Name = "havit";
            havit.Size = new Size(74, 15);
            havit.TabIndex = 8;
            havit.Text = "havitorleszto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(havit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbHaviTorleszto);
            Controls.Add(dataGridView1);
            Controls.Add(tbHitelOsszege);
            Controls.Add(tbHaviKamat);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbHaviKamat;
        private TextBox tbHitelOsszege;
        private DataGridView dataGridView1;
        private ComboBox cbHaviTorleszto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label havit;
    }
}
