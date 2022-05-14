namespace LabMTP_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.varsta = new System.Windows.Forms.NumericUpDown();
            this.an = new System.Windows.Forms.ComboBox();
            this.nota1 = new System.Windows.Forms.ComboBox();
            this.nota4 = new System.Windows.Forms.ComboBox();
            this.nota3 = new System.Windows.Forms.ComboBox();
            this.nota2 = new System.Windows.Forms.ComboBox();
            this.adauga = new System.Windows.Forms.Button();
            this.gg = new System.Windows.Forms.GroupBox();
            this.selectAn = new System.Windows.Forms.ComboBox();
            this.selectNume = new System.Windows.Forms.TextBox();
            this.ordonareNume = new System.Windows.Forms.Button();
            this.ordonareMedie = new System.Windows.Forms.Button();
            this.afisareAn = new System.Windows.Forms.Button();
            this.cautareNume = new System.Windows.Forms.Button();
            this.Afisare = new System.Windows.Forms.ListBox();
            this.sterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.varsta)).BeginInit();
            this.gg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Varsta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(86, 47);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(100, 23);
            this.Nume.TabIndex = 4;
            // 
            // varsta
            // 
            this.varsta.Location = new System.Drawing.Point(84, 76);
            this.varsta.Name = "varsta";
            this.varsta.Size = new System.Drawing.Size(120, 23);
            this.varsta.TabIndex = 5;
            // 
            // an
            // 
            this.an.FormattingEnabled = true;
            this.an.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.an.Location = new System.Drawing.Point(83, 111);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(32, 23);
            this.an.TabIndex = 6;
            // 
            // nota1
            // 
            this.nota1.FormattingEnabled = true;
            this.nota1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nota1.Location = new System.Drawing.Point(83, 150);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(32, 23);
            this.nota1.TabIndex = 7;
            // 
            // nota4
            // 
            this.nota4.FormattingEnabled = true;
            this.nota4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nota4.Location = new System.Drawing.Point(197, 150);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(32, 23);
            this.nota4.TabIndex = 8;
            // 
            // nota3
            // 
            this.nota3.FormattingEnabled = true;
            this.nota3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nota3.Location = new System.Drawing.Point(159, 150);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(32, 23);
            this.nota3.TabIndex = 9;
            // 
            // nota2
            // 
            this.nota2.FormattingEnabled = true;
            this.nota2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nota2.Location = new System.Drawing.Point(121, 150);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(32, 23);
            this.nota2.TabIndex = 10;
            // 
            // adauga
            // 
            this.adauga.Location = new System.Drawing.Point(45, 190);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(159, 34);
            this.adauga.TabIndex = 11;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // gg
            // 
            this.gg.Controls.Add(this.selectAn);
            this.gg.Controls.Add(this.selectNume);
            this.gg.Controls.Add(this.ordonareNume);
            this.gg.Controls.Add(this.ordonareMedie);
            this.gg.Controls.Add(this.afisareAn);
            this.gg.Controls.Add(this.cautareNume);
            this.gg.Location = new System.Drawing.Point(45, 256);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(316, 256);
            this.gg.TabIndex = 12;
            this.gg.TabStop = false;
            this.gg.Text = "afisare";
            // 
            // selectAn
            // 
            this.selectAn.FormattingEnabled = true;
            this.selectAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.selectAn.Location = new System.Drawing.Point(176, 150);
            this.selectAn.Name = "selectAn";
            this.selectAn.Size = new System.Drawing.Size(32, 23);
            this.selectAn.TabIndex = 17;
            // 
            // selectNume
            // 
            this.selectNume.Location = new System.Drawing.Point(138, 186);
            this.selectNume.Name = "selectNume";
            this.selectNume.Size = new System.Drawing.Size(100, 23);
            this.selectNume.TabIndex = 16;
            // 
            // ordonareNume
            // 
            this.ordonareNume.Location = new System.Drawing.Point(11, 44);
            this.ordonareNume.Name = "ordonareNume";
            this.ordonareNume.Size = new System.Drawing.Size(159, 34);
            this.ordonareNume.TabIndex = 15;
            this.ordonareNume.Text = "Ordonare dupa nume";
            this.ordonareNume.UseVisualStyleBackColor = true;
            this.ordonareNume.Click += new System.EventHandler(this.ordonareNume_Click);
            // 
            // ordonareMedie
            // 
            this.ordonareMedie.Location = new System.Drawing.Point(11, 84);
            this.ordonareMedie.Name = "ordonareMedie";
            this.ordonareMedie.Size = new System.Drawing.Size(159, 34);
            this.ordonareMedie.TabIndex = 14;
            this.ordonareMedie.Text = "Ordonare dupa medie";
            this.ordonareMedie.UseVisualStyleBackColor = true;
            this.ordonareMedie.Click += new System.EventHandler(this.ordonareMedie_Click);
            // 
            // afisareAn
            // 
            this.afisareAn.Location = new System.Drawing.Point(11, 139);
            this.afisareAn.Name = "afisareAn";
            this.afisareAn.Size = new System.Drawing.Size(159, 34);
            this.afisareAn.TabIndex = 13;
            this.afisareAn.Text = "Afisarea studentilor din an:";
            this.afisareAn.UseVisualStyleBackColor = true;
            this.afisareAn.Click += new System.EventHandler(this.afisareAn_Click);
            // 
            // cautareNume
            // 
            this.cautareNume.Location = new System.Drawing.Point(11, 179);
            this.cautareNume.Name = "cautareNume";
            this.cautareNume.Size = new System.Drawing.Size(121, 34);
            this.cautareNume.TabIndex = 12;
            this.cautareNume.Text = "Cautare dupa nume";
            this.cautareNume.UseVisualStyleBackColor = true;
            this.cautareNume.Click += new System.EventHandler(this.cautareNume_Click);
            // 
            // Afisare
            // 
            this.Afisare.FormattingEnabled = true;
            this.Afisare.ItemHeight = 15;
            this.Afisare.Location = new System.Drawing.Point(411, 50);
            this.Afisare.Name = "Afisare";
            this.Afisare.Size = new System.Drawing.Size(443, 469);
            this.Afisare.TabIndex = 13;
            // 
            // sterge
            // 
            this.sterge.Location = new System.Drawing.Point(695, 525);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(159, 34);
            this.sterge.TabIndex = 14;
            this.sterge.Text = "Sterge";
            this.sterge.UseVisualStyleBackColor = true;
            this.sterge.Click += new System.EventHandler(this.sterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 626);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.Afisare);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.an);
            this.Controls.Add(this.varsta);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "form";
            ((System.ComponentModel.ISupportInitialize)(this.varsta)).EndInit();
            this.gg.ResumeLayout(false);
            this.gg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.NumericUpDown varsta;
        private System.Windows.Forms.ComboBox an;
        private System.Windows.Forms.ComboBox nota1;
        private System.Windows.Forms.ComboBox nota4;
        private System.Windows.Forms.ComboBox nota3;
        private System.Windows.Forms.ComboBox nota2;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.GroupBox gg;
        private System.Windows.Forms.ComboBox selectAn;
        private System.Windows.Forms.TextBox selectNume;
        private System.Windows.Forms.Button ordonareNume;
        private System.Windows.Forms.Button ordonareMedie;
        private System.Windows.Forms.Button afisareAn;
        private System.Windows.Forms.Button cautareNume;
        private System.Windows.Forms.ListBox Afisare;
        private System.Windows.Forms.Button sterge;
    }
}
