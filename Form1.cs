using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOriginal2
{
    public partial class Form1 : Form
    {

        List<Persoana> list = new List<Persoana>();
        int maxIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizare();
        }

        private void Actualizare()
        {
            nume.Text = "";
            telefon.Text = "";
            adresa.Text = "";
            categorie.SelectedIndex = 0;
            treeView1.Nodes.Clear();
            propertyGrid1.SelectedObject = null;

            treeView1.Nodes.Add("Prieteni", "Prieten", 1);
            treeView1.Nodes.Add("Colegi", "Colegi", 2);
            treeView1.Nodes.Add("Rude", "Rude", 3);
            treeView1.Nodes.Add("Diverse", "Diverse", 4);

            foreach(Persoana p in list)
            {
                TreeNode myNode;
                switch(p.Categorie)
                {
                    case Categorie.Prieteni:
                        myNode = treeView1.Nodes["prieteni"];
                        break;

                    case Categorie.Colegi:
                        myNode = treeView1.Nodes["colegi"];
                        break;

                    case Categorie.Rude:
                        myNode = treeView1.Nodes["rude"];
                        break;

                    default:
                        myNode = treeView1.Nodes["diversi"];
                        break;

                }
                myNode.Nodes.Add(p.Index.ToString(),p.Nume,GetImageIned(p.Categorie));
            }
        }

        private int GetImageIned(Categorie categorie)
        {
            return Convert.ToInt32(categorie) + 1;
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            Persoana p;
            p = new Persoana(maxIndex++, nume.Text, data.Value, telefon.Text, adresa.Text, GetCategorie(categorie.SelectedIndex));
            bool duplicat = VerificaDuplicat(p);
            if(!duplicat)
            {
                list.Add(p);
                Actualizare();
            }
            else
            {
                MessageBox.Show("exista deja","Duplicate",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private bool VerificaDuplicat(Persoana p)
        {
            Persoana pers = list.Find(
                delegate (Persoana myPers)
                {
                    return myPers.Nume == p.Nume;
                });
            return pers != null;
        }

        private Categorie GetCategorie(int index)
        {
            switch(index)
            {
                case 0:
                   return Categorie.Prieteni;
                case 1:
                    return Categorie.Colegi;
                case 2: 
                    return Categorie.Rude;
                default:
                    return Categorie.Diversi;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Persoana pers;
            int index;
            propertyGrid1.SelectedObject = null;
            if(int.TryParse(e.Node.Name,out index))
            {
                pers = GetByIndex(index);
                if(pers != null)
                {
                    propertyGrid1.SelectedObject = pers;
                }
            }
        }

        private Persoana GetByIndex(int index)
        {
           foreach(Persoana pers in list)
            {
                if (pers.Index == index)
                    return pers;
            }
            return null;
        }

        private void salveaza_Click(object sender, EventArgs e)
        {
            string dir= Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\agenda.txt",false);
            foreach(Persoana pers in list)
            {
                sw.WriteLine("Nume: " + pers.Nume);
                sw.WriteLine("Categorie: " + pers.Categorie);
                sw.WriteLine("Data nasteri: " + pers.DataNasteri);
                sw.WriteLine("Telefon: " + pers.Telefon);
                sw.WriteLine("Adresa: " + pers.Adresa);
                sw.WriteLine("-----------------------------------------");
            }
            sw.Close();
            Process.Start("notepad.exe", dir + "\\agenda.txt");
        }
    }
}
