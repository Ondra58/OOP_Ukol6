using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    internal class Osoba
    {
        protected string jmeno;
        protected string prijmeni;
        protected int hmotnost;
        protected  double vyska;
        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Hmotnost = hmotnost;
            this.Vyska = vyska;
        }
        public string Jmeno
        {
            get => jmeno;
            set => jmeno = value;
        }
        public string Prijmeni
        {
            get => prijmeni;
            set => prijmeni = value;
        }
        public int Hmotnost
        {
            get => hmotnost;
            set
            {
                if (value > 0 && value <= 300)
                {
                    hmotnost = value;
                }
                else
                {
                    MessageBox.Show("Hmotnost mimo rozsah!");
                }
            }
        }
        public double Vyska
        {
            get => vyska;
            set
            {
                if (value > 2.5)
                {
                    vyska = value / 100;
                }
                else
                {
                    vyska = value;
                }
            }
        }
        public virtual double BMI(int hmotnost, double vyska)
        {
            return (double)Math.Round((double)hmotnost / (vyska * vyska), 2);
        }

        public override string ToString()
        {
            return "Jméno: " + jmeno + "\nPříjmení: " + prijmeni + "\nHmotnost: " + hmotnost + "\nVýška: " + vyska + "\nBMI: " + BMI(hmotnost, vyska);
        }
    }
}
