using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOef1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 08/01/2024
            // Array's oef 1

            // Velden 
            // Manier 1:
            //String[] _voornamen = new string[] {"Mohamed", "Robbe", "Loewie", "Patrick", "Niels", "Maks", "Kylian" };
            // Manier :
            String[] _voornamen = new string[7];
            _voornamen[0] = "Mohamed";
            _voornamen[1] = "Robbe"; 
            _voornamen[2] = "Loewie";
            _voornamen[3] = "Patrick"; 
            _voornamen[4] = "Niels"; 
            _voornamen[5] = "Maks"; 
            _voornamen[6] = "Kylian";

            byte _keuze = 0;

            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                // Toon menu
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Toon allen namen \n   2) Afsluiten");
                Console.Write("\n\n: uw keuze: ");

                // Scherm leegmaken 
                Console.Clear();

                try
                {
                    // Keuze opslaan
                    _keuze = byte.Parse(Console.ReadLine());

                    // als 1: Toon de namen 
                    if (_keuze == 1 )
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine(_voornamen[i]);
                        }

                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    else if (_keuze == 2 )
                    {
                        // afsluiten
                        Console.WriteLine("Dag en tot een volgende keer.");
                        Console.WriteLine("Druk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    else
                    {
                       
                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }
                    
                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }
                
            } while (_keuze != 2);
            
           

        }
    }
}
