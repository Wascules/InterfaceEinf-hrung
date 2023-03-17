namespace InterfaceEinführung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            ExcelDokument ed = new ExcelDokument();
            ed.SetTitel("Interface und Du");

            WordDokument wd = new WordDokument();
            wd.SetTitel("Wörd ist so schön");

            ExotischesDokument exd = new ExotischesDokument();
            
            //variablen deklaration      Objekt erstellung vom typ List
            //Heterogener Container
            List<IDruckbar> liste = new List<IDruckbar>();
            //liste füllen
            liste.Add(ed);
            liste.Add(wd);
            liste.Add(exd);

           /* Wirft einen fehler aus denn die liste wird über IDruckbar zusammengeführt
            foreach(WordDokument item in liste)
            {
                Console.WriteLine(item.GetTitel());
            }
            GetTitel läuft auf einen fehler da Exotisches Dokument kein GetTitel hat!
            wird oben in der listen füllung das Exotische Dokument auskommentiert ->
            funktioniert GetTitel nicht da die liste immer noch über IDruckbar zusammengeführt wird
            und IDruckbar hat KEIN GetTitel!!!!!!!!
            foreach (IDruckbar item in liste)
            {
                Console.WriteLine(item.GetTitel());

            } */
            foreach(IDruckbar item in liste)
            {
                if(item is WordDokument) //bist du ein WordDokument? Wenn ja dann tue dies:
                {
                    //Hier kann GetTitel ausgelesen werden in der IF abfrage fragt er ob es ein
                    //WordDokument ist und wenn es eins ist Setzt er es für den MOMENT auf den Datentyp WordDokument NICHT IDruckbar
                   
                    string d = ((WordDokument)item).GetTitel(); //expliziertes convertieren!
                    Console.WriteLine(d);
                    //holt sich die infos und speicher sie in d zwischen
                }
                if (item is ExcelDokument) //bist du ein ExcelDokument? Wenn ja tue dies: 
                {
                    //Hier kann GetTitel ausgelesen werden in der IF abfrage fragt er ob es ein
                    //ExcelDokument ist und wenn es eins ist Setzt er es für den MOMENT auf den Datentyp WordDokument NICHT IDruckbar
                    
                    string e = ((ExcelDokument)item).GetTitel(); //expliziertes convertieren!
                    Console.WriteLine(e);
                    //holt sich die infos und speichert sie in E zwischen
                }
                else
                {
                    Console.WriteLine("Ich bin exotisch");
                }

            }


            Console.ReadLine();
        }
    }
}