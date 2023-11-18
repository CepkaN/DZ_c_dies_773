using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_773
{
    public abstract class Automobile
    {
        public string Nome { get; set; }
        public double Velocita { get; set; }
        public double Corso { get; set; }
        public bool Pobeda;
        public void VarVelocita() { 
        Random rnd=new Random();
            double BB =rnd.Next(0,100);
            Velocita = Velocita + BB;
            Console.WriteLine(" Скорость " + Nome + " составляет " + Velocita + " км/ч\n");
        }
        public void AltroCorso() {
            Corso = Velocita * 0.2;
            Console.WriteLine(" Пройденный путь составляет " + Corso + " км \n");
        }
    }
}
