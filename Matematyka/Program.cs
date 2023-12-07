using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tymczasowe zmienne
            int wybor_menu = 0;
            bool valid = false;
            int dobra_odp = 0;  
            int zla_odp = 0;
            int ilosc_pytan = 0;

            // tytuł konsoli
            Console.Title = "Matematyka - nauka"; 

            // menu główne
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Witaj w programie do nauki matematyki!");
            Console.WriteLine("--------------------------------------\n\n");
            Console.WriteLine("Wybierz dział matematyki:");
            Console.WriteLine("1. Dodawanie            3. Mnożenie");
            Console.WriteLine("2. Odejmowanie          4. Dzielenie");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("5. Wyjście");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();

            // wybór działu matematyki
            valid = int.TryParse(Console.ReadLine(), out wybor_menu);
            if (valid)
            {
                if (wybor_menu == 1)
                {
                    Dodawanie();
                }
                else if (wybor_menu == 2)
                {
                    Odejmowanie();
                }
                else if (wybor_menu == 3)
                {
                    Mnozenie();
                }
                else if (wybor_menu == 4)
                {
                    Dzielenie();
                }
                else if (wybor_menu == 5)
                {
                    Wyjscie();
                }
                else
                {
                    ostrzezenie("Nie ma takiej opcji w menu!");
                }   
            }


        }

        static void Dodawanie()
        {
            Console.Clear();
            
            Console.ReadKey();
        }   

        static void Odejmowanie()
        {
            Console.Clear();

            Console.ReadKey();
        }

        static void Mnozenie()
        {
            Console.Clear();

            Console.ReadKey();
        }

        static void Dzielenie()
        {
            Console.Clear();

            Console.ReadKey();
        }

        static void Wyjscie()
        {
            Console.Clear();

            Console.ReadKey();
        }

        static void ostrzezenie(string tekst)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }
    }
}
