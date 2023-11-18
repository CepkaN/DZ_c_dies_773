using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_773
{
    public class Gonka
    {
        public double Fine = 100;
        public bool BOO = false;
        public List<Automobile> voiture { get; set; }
        public Gonka()
        {
            voiture=new List<Automobile>();
        }
        public void AddVoiture(Automobile v)
        {
            voiture.Add(v);
        }
        public bool Confrontare()
        {
            foreach(var V in voiture)
            {
                V.VarVelocita();
                V.AltroCorso();
                if (V.Corso >= Fine)
                {
                    V.Pobeda = true;BOO = true;
                    Console.WriteLine(" Победил " + V.Nome);return true;
                }
            }return false;
        }
        public void Igra()
        {
            int a = 0;
            while (!Confrontare())
            {
                ++a;
                Console.WriteLine(a);
            }
        }
    }
}
