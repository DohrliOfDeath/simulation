using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    class Resource
    {
        public void Geht(Guest g, int zeitPunkt)
        {
            Console.WriteLine(g.Id + " geht");
            Program.EreignisListe.Add(new Ereignis("Guest Geht", zeitPunkt, g.Id));
        }
        public Guest Process(Guest g, int zeitPunkt)
        {
            Console.WriteLine(g.Id +" kommt");
            Program.EreignisListe.Add(new Ereignis("Guest Kommt", zeitPunkt, g.Id));
            Program.Queue.RemoveAt(0);
            return g;
        }
    }
}
