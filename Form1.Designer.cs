namespace LabOriginal2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adauga = new System.Windows.Forms.Button();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.adresa = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.salveaza = new System.Windows.Forms.Button();
            this.sterge = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.numeCautat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adauga);
            this.groupBox1.Controls.Add(this.categorie);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.adresa);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.nume);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // adauga
            // 
            this.adauga.Location = new System.Drawing.Point(258, 160);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(75, 23);
            this.adauga.TabIndex = 10;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // categorie
            // 
            this.categorie.FormattingEnabled = true;
            this.categorie.Items.AddRange(new object[] {
            "Prieteni",
            "Colegi",
            "Rude",
            "Diversi"});
            this.categorie.Location = new System.Drawing.Point(99, 168);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(121, 23);
            this.categorie.TabIndex = 9;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(111, 72);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 23);
            this.data.TabIndex = 8;
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(84, 133);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(100, 23);
            this.adresa.TabIndex = 7;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(84, 103);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(100, 23);
            this.telefon.TabIndex = 6;
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(81, 39);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 23);
            this.nume.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "data nasteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "categorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nume";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(23, 268);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(366, 241);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "prieteni.png");
            this.imageList1.Images.SetKeyName(2, "colegi.png");
            this.imageList1.Images.SetKeyName(3, "rude.png");
            this.imageList1.Images.SetKeyName(4, "question.png");
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(410, 268);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(474, 241);
            this.propertyGrid1.TabIndex = 2;
            // 
            // salveaza
            // 
            this.salveaza.Location = new System.Drawing.Point(270, 515);
            this.salveaza.Name = "salveaza";
            this.salveaza.Size = new System.Drawing.Size(119, 23);
            this.salveaza.TabIndex = 11;
            this.salveaza.Text = "Salveaza in fisier";
            this.salveaza.UseVisualStyleBackColor = true;
            this.salveaza.Click += new System.EventHandler(this.salveaza_Click);
            // 
            // sterge
            // 
            this.sterge.Location = new System.Drawing.Point(809, 515);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(75, 23);
            this.sterge.TabIndex = 12;
            this.sterge.Text = "Sterge";
            this.sterge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.numeCautat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(438, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 133);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(160, 85);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 13;
            this.search.Text = "Cauta";
            this.search.UseVisualStyleBackColor = true;
            // 
            // numeCautat
            // 
            this.numeCautat.Location = new System.Drawing.Point(74, 53);
            this.numeCautat.Name = "numeCautat";
            this.numeCautat.Size = new System.Drawing.Size(100, 23);
            this.numeCautat.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "nume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.salveaza);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox categorie;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button salveaza;
        private System.Windows.Forms.Button sterge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox numeCautat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
    }
}
