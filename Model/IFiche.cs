using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Model
{
    internal interface IFiche
    {
        void AddListe(string nom, string text);
        void DelListe(int id);
        void clear();
        List<TFiche> GetListe();
        void GetTacheById(int id);
        //void GetListeByName(string name);
    }
}
