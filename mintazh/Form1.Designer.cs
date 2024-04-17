namespace mintazh
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            futoBindingSource = new BindingSource(components);
            button1Betoltes = new Button();
            button1Mentes = new Button();
            button1Torles = new Button();
            button2Ujsor = new Button();
            buttonErdekes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = futoBindingSource;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 231);
            dataGridView1.TabIndex = 0;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            // 
            // futoBindingSource
            // 
            futoBindingSource.DataSource = typeof(Futo);
            // 
            // button1Betoltes
            // 
            button1Betoltes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1Betoltes.Location = new Point(778, 82);
            button1Betoltes.Name = "button1Betoltes";
            button1Betoltes.Size = new Size(75, 23);
            button1Betoltes.TabIndex = 1;
            button1Betoltes.Text = "Betoltes";
            button1Betoltes.UseVisualStyleBackColor = true;
            button1Betoltes.Click += button1Betoltes_Click;
            // 
            // button1Mentes
            // 
            button1Mentes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1Mentes.Location = new Point(697, 82);
            button1Mentes.Name = "button1Mentes";
            button1Mentes.Size = new Size(75, 23);
            button1Mentes.TabIndex = 2;
            button1Mentes.Text = "Mentes";
            button1Mentes.UseVisualStyleBackColor = true;
            button1Mentes.Click += button1Mentes_Click;
            // 
            // button1Torles
            // 
            button1Torles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1Torles.Location = new Point(686, 398);
            button1Torles.Name = "button1Torles";
            button1Torles.Size = new Size(75, 23);
            button1Torles.TabIndex = 3;
            button1Torles.Text = "Torles";
            button1Torles.UseVisualStyleBackColor = true;
            button1Torles.Click += button1Torles_Click;
            // 
            // button2Ujsor
            // 
            button2Ujsor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2Ujsor.Location = new Point(767, 398);
            button2Ujsor.Name = "button2Ujsor";
            button2Ujsor.Size = new Size(75, 23);
            button2Ujsor.TabIndex = 4;
            button2Ujsor.Text = "Uj sor";
            button2Ujsor.UseVisualStyleBackColor = true;
            button2Ujsor.Click += button2Ujsor_Click;
            // 
            // buttonErdekes
            // 
            buttonErdekes.Location = new Point(29, 389);
            buttonErdekes.Name = "buttonErdekes";
            buttonErdekes.Size = new Size(75, 23);
            buttonErdekes.TabIndex = 5;
            buttonErdekes.Text = "Érdekességek";
            buttonErdekes.UseVisualStyleBackColor = true;
            buttonErdekes.Click += buttonErdekes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 449);
            Controls.Add(buttonErdekes);
            Controls.Add(button2Ujsor);
            Controls.Add(button1Torles);
            Controls.Add(button1Mentes);
            Controls.Add(button1Betoltes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1Betoltes;
        private Button button1Mentes;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource futoBindingSource;
        private Button button1Torles;
        private Button button2Ujsor;
        private Button buttonErdekes;
    }
}
