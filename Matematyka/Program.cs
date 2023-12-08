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
            bool valid_ilosc = false;
            bool valid_dodawanie = false;
            int wybor_dodawanie = 0;
            int ilosc_pytan = 0;
            int liczba1 = 0;
            int liczba2 = 0;
            int wynik = 0;
            int odp = 0;
            int dobra_odp = 0;
            int zla_odp = 0;
            int licznik = 0;
            string dzial = "";
            Random rnd = new Random();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Witaj w dziale matematycznym - dodawanie");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------\n\n");
            Console.ResetColor();

            // wybór ilości pytań
            Console.Write("Ile razy chcesz zagrać? ");
            valid_ilosc = int.TryParse(Console.ReadLine(), out ilosc_pytan);
            if (valid_ilosc)
            {
                if (ilosc_pytan > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wybrałeś ilość pytań: " + ilosc_pytan);
                    Console.WriteLine("\n");
                }
                else
                {
                    ostrzezenie("Wybrałeś liczbę mniejszą od 0!");
                }
            }
            else
            {
                ostrzezenie("Nie podałeś liczby!");
            }

            // wybór zakresu liczb
            Console.Clear();
            Console.Write("Podaj liczbę od 0 do jakiej chcesz ćwiczyć dodawanie: ");
            valid_dodawanie = int.TryParse(Console.ReadLine(), out wybor_dodawanie);

            do
            {
                if (valid_dodawanie)
                {
                    Console.WriteLine("Wybrałeś liczbę: " + wybor_dodawanie);
                    Console.WriteLine("\n");
                    if (wybor_dodawanie > 0)
                    {
                        licznik++;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Zadanie numer {licznik}");
                        Console.WriteLine("---------------------------------\n");
                        
                        liczba1 = rnd.Next(1, wybor_dodawanie+1);
                        liczba2 = rnd.Next(1, wybor_dodawanie+1);
                        wynik = liczba1 + liczba2;

                        Console.Write("Ile jest: " + liczba1 + " + " + liczba2 + " = ?  ");
                        valid_dodawanie = int.TryParse(Console.ReadLine(), out odp);
                        
                        if (valid_dodawanie)
                        {
                            if (odp == wynik)
                            {
                                Console.WriteLine("Dobra odpowiedź!");
                                Console.WriteLine("\n");
                                dobra_odp++;
                            }
                            else
                            {
                                Console.WriteLine("Zła odpowiedź!");
                                Console.WriteLine("\n");
                                zla_odp++;
                            }
                        }
                        else
                        {
                            ostrzezenie("Nie podałeś liczby!");
                        }
                    }
                    else
                    {
                        ostrzezenie("Wybrałeś liczbę mniejszą od 0!");
                    }
                }
                else
                {
                    ostrzezenie("Nie podałeś liczby!");
                } 
            } while (!valid_dodawanie || wybor_dodawanie <= 0 || ilosc_pytan != licznik);
            // przejscie do wyswietlenia statystyki
            statystyka(dobra_odp, zla_odp, ilosc_pytan, "dodawanie");

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

        static void statystyka(int dobra_odp, int zla_odp, int ilosc_pytan, string dzial)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Statystyka działu - {dzial}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("----------------------------------------\n\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ilość dobrych odpowiedzi: " + dobra_odp);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ilość złych odpowiedzi: " + zla_odp);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ilość pytań: " + ilosc_pytan);
            Console.ResetColor();

            Console.WriteLine("\n");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Procent dobrych odpowiedzi: " + (dobra_odp * 100) / ilosc_pytan + "%");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Procent złych odpowiedzi: " + (zla_odp * 100) / ilosc_pytan + "%");
            Console.ResetColor();

            Console.WriteLine("\n");

            Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do menu głównego...");
            Console.ReadKey();
            Console.Clear();  
            Main(null);
        }
    }
}
