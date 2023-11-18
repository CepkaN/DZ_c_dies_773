using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_773
{
    public class Giocatore
    {
        public string Nome{get;set;}
        public List<KRR> GiocoKAR { get; set; }
        public Queue<KRR> GiocoKARta { get; set; }
        public Giocatore(string N) { GiocoKAR = new List<KRR>(); Nome = N;GiocoKARta = new Queue<KRR>(); }
        public void AddKAR(KRR k) {  GiocoKAR.Add(k);}
        public void Mostrr()
        {
            Console.WriteLine(Nome);
            foreach(var k in GiocoKAR)
            {
                k.MMM();
            }
        }
        public void QUUUU()
        {
            foreach(var k in GiocoKAR)
            {
                GiocoKARta.Enqueue(k);
            }
        }
       
    }
}
