using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KONZOLE_naPohovor
{
    //Pohovorová otázka: Je možné do pole ukládat různé typy?
    //Odpověď ANO. Předkem všech typů je objekt - vytvoříme-li pole objektů, můžeme tam dát cokoliv:
    public class Pole
    {
        public string MojePole()
        {
            //pole objektů
            object[] poleCehokoliv = new object[3];
            poleCehokoliv[0] = 21;
            poleCehokoliv[1] = "text";

            Osoba Kaja = new Osoba();
            Kaja.Jmeno = "Karel Novák";
            Kaja.Vek = 43;

            poleCehokoliv[2] = Kaja;
            string vystup = "";
            foreach(object obj in poleCehokoliv)            
                vystup += obj + ", " ;
            
            return vystup;
        }

        public string PoleList()
        {
            //můžeme také použít ARRAY LIST pracuje s objekty - vyžaduje using System.Collection
            ArrayList poleListCehokoliv = new ArrayList(); 
            poleListCehokoliv.Add(202);
            poleListCehokoliv.Add("textové sdělení");           
            poleListCehokoliv.Add(new Osoba { Jmeno = "Ema Young", Vek = 25 });
            string vystup2 = "";
            foreach (object obj in poleListCehokoliv)
                vystup2 += obj + ", ";

            return vystup2;
        }

        public override string ToString()
        {
            return PoleList().ToString(); //MojePole().ToString();
        }
    }

    class Osoba
    {
        public string Jmeno { get; set; }
        public int Vek { get; set; }

        public override string ToString()
        {
            return $"Zdravím, jsem osoba: {Jmeno} a je mi {Vek} let!";
        }
    }
}
