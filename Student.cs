using System;
using System.Collections.Generic;
using System.Text;

namespace LabMTP_
{
    class Student:Persoana
    {
        private byte an;
        private byte[] note = new byte[4];
        

        public Student(byte an,byte[] note,string nume, byte varsta):base(nume,varsta)
        {
            this.an = an;
            this.note = note;
        }

        public byte AnStudiu 
        {
            get { return an; }
        }

        public string NumeStudent
        {
            get { return nume; }
        }

        public float Medie()
        {
            float m = 0;
            foreach(byte n in note)
            {
                m += n;
            }
            return m / 4;
        }

        public string AfisareStudent()
        {
            return nume + " " + varsta + " ani,anul " + an + ",media " + Medie();
        }
    }
}
