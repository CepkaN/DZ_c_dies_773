using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_773
{
    public class KRR { 
    public string Nome { get; set; }
        public int Valid { get; set; }
        public KRR(string g,int h) {  Nome = g; Valid = h; }
        public void MMM()
        {
            Console.WriteLine(Nome + "  " + Valid);
        }
    }
    
    public class Karta
    {
        public List<Giocatore> GIO { get; set; }
        public List<KRR> KARTA { get; set; }
        public Karta() { KARTA=new List<KRR> { { new KRR("6", 1) }, {new KRR("6", 1) },{new KRR("6", 1) },{ new KRR("6", 1) } 
        ,{new KRR("7", 2) },{new KRR("7", 2) },{new KRR("7", 2) },{new KRR("7", 2) },{new KRR("8", 3) },{new KRR("8", 3) },{new KRR("8", 3) },{new KRR("8", 3) }
        ,{new KRR("9", 4) } ,{new KRR("9", 4) } ,{new KRR("9", 4) } ,{new KRR("9", 4) } ,{new KRR("10", 5) },{new KRR("10", 5) },{new KRR("10", 5) },{new KRR("10", 5) }
        ,{new KRR("валет", 6) },{new KRR("валет", 6) },{new KRR("валет", 6) },{new KRR("валет", 6) },{new KRR("дама", 7) },{new KRR("дама", 7) },{new KRR("дама", 7) },{new KRR("дама", 7) }
        ,{new KRR("король", 8) },{new KRR("король", 8) },{new KRR("король", 8) },{new KRR("король", 8) },{new KRR("туз", 9) },{new KRR("туз", 9) },{new KRR("туз", 9) },{new KRR("туз", 9) }};
            GIO = new List<Giocatore>();
        }
        public void Mesh()
        {
            Random rand = new Random();

            for (int i = KARTA.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                KRR tmp = KARTA[j];
                KARTA[j].Valid = KARTA[i].Valid;
                KARTA[j].Nome = KARTA[i].Nome;

                KARTA[i] = tmp;
            }
        }
        public void Mostra()
        {
            foreach(var k in KARTA)
            {
                k.MMM();
            }
        }
        public void ADDGIO(Giocatore GG) { GIO.Add(GG); }
        public void RAZDACIA()
        {
            int a = 0;
            int i = 0;
            for(int j=0;j< GIO.Count;++j)
            {
                a+= KARTA.Count / GIO.Count;
                while(i < a){
                    GIO[j].AddKAR(KARTA[i]);
                    ++i;
                }
                
               
            }

        }
        public bool GIOProv()
        {
            foreach(var G in GIO)
            {
                if(G.GiocoKARta.Count == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void IGGGGOgo()
        {
            List<KRR> probnik = new List<KRR>();
            do
            {
                probnik.Clear();
                int max = 0;
                int i = 0;
                int b = 0;
                for (; i < GIO.Count; ++i)
                {
                    KRR karkar = GIO[i].GiocoKARta.Dequeue();
                    karkar.MMM();
                    probnik.Add(karkar);
                    if ( karkar.Valid>=max)
                    {
                        max = karkar.Valid;
                        b = i;
                    }
                }
                foreach (var k in probnik)
                {
                    GIO[b].GiocoKARta.Enqueue(k);
                }
            } while (GIOProv());
            foreach (var G in GIO)
            {
                if (G.GiocoKARta.Count == 0)
                {
                    Console.WriteLine(" Выиграл игрок " + G.Nome);
                }
            }
        }
    }
}
