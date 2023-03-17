using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEinführung
{
    internal abstract class Dokument
    {
        //Dokument kann durch abstract class keine Objekte mehr erzeugen
        //ABER an andere Klassen Vererben!!!!!!!!!
        private string titel;

        public void SetTitel(string titel)
        {
            this.titel = titel;
        }
        public string GetTitel()
        {
            return titel;
        }
    }
}
