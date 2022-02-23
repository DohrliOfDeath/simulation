using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    class Ereignis
    {
        public string Name { get; set; }
        public int Zeitpunkt { get; set; }
        public int GastId { get; set; }

        public Ereignis(string name, int zp, int gastId)
        {
            this.Name = name;
            this.Zeitpunkt = zp;
            this.GastId = gastId;
        }/*
        public Ereignis(string name, DateTime zp,int dauer)
        {
            this.Name = name;
            this.Zeitpunkt = zp;
            this.Dauer = dauer;
        }*/
    }
}
