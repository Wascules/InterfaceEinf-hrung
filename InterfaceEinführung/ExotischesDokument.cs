﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEinführung
{
    internal class ExotischesDokument: IDruckbar
    {
        //wird IDruckbar hier nicht als public void Drucken() deklariert spuckt er in der:
        //internal class einen fehler bei IDruckbar aus!!!!!!
        public void Drucken()
        {
            Console.WriteLine("Drucke Exotisches Nicht Dokument");
        }
    }
}
