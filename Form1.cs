using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMTP_
{
    public partial class Form1 : Form
    {
        private List<Student> lista=new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AfisareLista()
        {
            Afisare.Items.Clear();
            foreach (Student s in lista)
            {
                Afisare.Items.Add(s.AfisareStudent());
            }
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            byte[] n = new byte[4];
            try
            {
                n[0]=Convert.ToByte(nota1.Text);  
                n[1]=Convert.ToByte(nota2.Text);  
                n[2]=Convert.ToByte(nota3.Text);  
                n[3]=Convert.ToByte(nota4.Text);

                Student s = new Student(Convert.ToByte(an.Text), n, Nume.Text, Convert.ToByte(varsta.Value));
                lista.Add(s);
                AfisareLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sterge_Click(object sender, EventArgs e)
        {
            int s = Afisare.SelectedIndex;
            lista.RemoveAt(s);
            AfisareLista();
        }

        private void ordonareNume_Click(object sender, EventArgs e)
        {
            ComparaNume cmp = new ComparaNume();
            lista.Sort(cmp);
            AfisareLista();
        }

        private void cautareNume_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = selectNume.Text;
                byte eror = 0;
                Afisare.Items.Clear();
                foreach(Student s in lista)
                {
                    if(string.Compare(s.NumeStudent,nume)==0)
                    {
                        eror = 1;
                        Afisare.Items.Add(s.AfisareStudent());
                    }
                }
                if (eror == 0)
                    Afisare.Items.Add("Ne pare rau dar nu exista numele");
            }
            catch(Exception ex)
            { 
               throw new Exception(ex.Message);
            }
        }

        private int SortareMedie(Student x, Student y)
        {

            return x.Medie() > y.Medie() ? 1 : -1;
            return 0;
        }

        private void ordonareMedie_Click(object sender, EventArgs e)
        {
            lista.Sort(SortareMedie);
            AfisareLista();
        }

        private void afisareAn_Click(object sender, EventArgs e)
        {
            Afisare.Items.Clear();
            byte an = Convert.ToByte(selectAn.Text);
            foreach(Student s in lista)
            {
                if (s.AnStudiu == an)
                    Afisare.Items.Add(s.AfisareStudent());
            }
        }
    }
}
