using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    internal class Pacient : Osoba
    {
        double obvodPasu;
        public Pacient(string jmeno, string prijmeni, int hmotnost,double vyska, double obvodPasu) : base(jmeno, prijmeni, hmotnost, vyska)
        {
            this.ObvodPasu = obvodPasu;
        }
        public double ObvodPasu 
        { 
            get => obvodPasu;
            set
            {
                if (value < 1.5)
                {
                    obvodPasu = value;
                }
                else
                {
                    obvodPasu = value / 100;
                }
            }
        }
        public double ABSI()
        {
            return (double)Math.Round(obvodPasu / (Math.Pow(BMI(hmotnost, vyska), 2 / 3) * Math.Pow(vyska, 1 / 2)), 3);
        }
        public override string ToString()
        {
            return base.ToString() + "\nObvod pasu: " + obvodPasu + "\nABSI: " + ABSI();
        }
    }
}
