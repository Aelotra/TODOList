using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Model
{
    internal class TFiche
    {
        public int id { get; }
        public string nomFiche { get; }
        public DateTime dateCrea { get; }
        public DateTime dateFerm { get; }
        public string descr { get; }

        public TFiche(int id, string nom, DateTime crea, string descr)
        {
            this.id = id;
            this.nomFiche = nom;
            this.dateCrea = crea;
            this.descr = descr;
        }
    }
}
