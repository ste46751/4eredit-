using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _4eredità.Program;

namespace _4eredità
{
    internal class Program
    {
        public class quadrato
        {
            protected double lato;

            public quadrato(double lato)
            {
                this.lato = lato;
            }

            public void AreaPerim(double lato)
            {
                double area = lato * lato;

                double perim = lato * 4;

                Console.WriteLine($"L'area del quadrato è:{area}\nIl perimetro è:{perim}");

            }
        }
        class cubo : quadrato
        {
            public cubo(double _lato) : base(_lato)
            {

            }
            public void SupVolume(double lato)
            {
                double sup = lato * lato*6;

                double volume = lato * lato*lato;

                Console.WriteLine($"La superficie del quadrato è:{sup}\nIl volume è:{volume}");

            }
        }
        static void Main(string[] args)
        {
            double lato;
            Console.WriteLine("Inserisci la lunghezza del lato del quadrato");
            lato=double.Parse(Console.ReadLine());
            quadrato q=new quadrato(lato);

            q.AreaPerim(lato);

            cubo c=new cubo(lato);  
            c.SupVolume(lato);

            Console.ReadLine();
        }
    }
}
