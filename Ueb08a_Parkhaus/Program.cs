using System;
using System.Collections.Generic;
using System.Linq;

namespace Ueb08a_Parkhaus
{
    class Program
    {

        // Im Program kann man max. 5 Autos unterbringen(List).
        // Bei Start des Programms wird ein Menü angezeigt:
        // „Anzahl Autos: "
        // „Einfahrt: e“
        // "Ausfahrt: a"
        // "Programmende: x"

        // •	Die Anzahl Autos wird immer angezeigt
        // •	Mit e kann der Benutzer den Namen und die Autonummer(nur Zahlen) eingeben.
        // •	Mit a werden alle Autos im Parkhaus angezeigt und der Benutzer kann ein
        //      Auto auswählen und dieses wird dann aus dem Parkhaus entfernt.
        // •	Mit x wird das Programm beendet.

        // Erstellen Sie im main() ein Menu worin man Autos ein – und ausfahren lassen 
        // kann und wo man immer sieht, wie viele Autos im gerade Parkhaus sind.

        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>();
            autos.Add(new Auto() { Name = "BMW", Kennzeichen = 123456 });
            autos.Add(new Auto() { Name = "VW", Kennzeichen = 112233 });
            autos.Add(new Auto() { Name = "Jaguar", Kennzeichen = 777888 });
            autos.Add(new Auto() { Name = "Opel", Kennzeichen = 607609 });

            string sEingabe = "";

            while (sEingabe != "x")
            {
                Console.WriteLine("Parkaus Anz. Autos: " + autos.Count());
                Console.WriteLine("Einfahrt = e");
                Console.WriteLine("Ausfahrt = a");
                Console.WriteLine("Programende = x");
                sEingabe = Console.ReadLine();

                switch (sEingabe.ToLower())
                {
                    case "x":
                        break;
                    case "e":
                        {
                            if (autos.Count() > 5)
                            {
                                Console.WriteLine("Parkhaus ist voll");
                                continue;
                            }

                            Console.WriteLine("Automarke eingeben");
                            string sAutoMarke = Console.ReadLine();
                            Console.WriteLine("Autonummer eingeben (nur Zahlen");
                            string sAutoNr = Console.ReadLine();

                            int nAutoNr = -1;
                            if (int.TryParse(sAutoNr, out nAutoNr))
                            {
                                Auto auto = new Auto() { Name = sAutoMarke, Kennzeichen = nAutoNr };
                                autos.Add(auto);
                            }
                            break;
                        }
                    case "a":
                        {
                            if (autos.Count() < 1)
                            {
                                Console.WriteLine("Parkhaus ist leer");
                                continue;
                            }
                            for (int i = 0; i < autos.Count(); ++i)
                            {
                                Console.WriteLine(i + " " + autos[i].Name + " " + autos[i].Kennzeichen);
                            }

                            Console.WriteLine("Welches Auto 'rausfahren? ");
                            string sAuto = Console.ReadLine();
                            int iWahl = -1;
                            if (int.TryParse(sAuto, out iWahl))
                            {
                                try
                                {
                                    autos.RemoveAt(iWahl);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Dieses Auto gibt es nicht" + ex.Message);
                                }
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                }
            }
        }
    }
    
}
