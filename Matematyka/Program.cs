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
            // czyszczenie konsoli
            Console.Clear();

            // tytuł konsoli
            Console.Title = "Matematyka - nauka"; 

            // menu główne
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Witaj w programie do nauki matematyki!");
            Console.WriteLine("--------------------------------------\n\n");
            Console.WriteLine("Wybierz dział matematyki:");
            Console.WriteLine("1. Dodawanie            3. Mnożenie");
            Console.WriteLine("2. Odejmowanie          4. Test");
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
                    Mix();
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

// dodawanie
        static void Dodawanie()
        {
            // tymczasowe zmienne
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
            // wstep do dzialu dodawanie
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
            bool valid_ilosc = false;
            bool valid_odejmowanie = false;
            int wybor_odejmowanie = 0;
            int ilosc_pytan = 0;
            int liczba1 = 0;
            int liczba2 = 0;
            int wynik = 0;
            int odp = 0;
            int dobra_odp = 0;
            int zla_odp = 0;
            int licznik = 0;
            string dzial = "odejmowanie";
            Random rnd = new Random();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Witaj w dziale matematycznym - odejmowanie");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------\n\n");
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
            Console.ReadKey();
        }

// mnozenie
        static void Mnozenie()
        {
            // tymczasowe zmienne
            bool valid_ilosc = false;
            bool valid_mnozenie = false;
            int wybor_mnozenie = 0;
            int ilosc_pytan = 0;
            int liczba1 = 0;
            int liczba2 = 0;
            int wynik = 0;
            int odp = 0;
            int dobra_odp = 0;
            int zla_odp = 0;
            int licznik = 0;
            string dzial = "mnożenie";
            Random rnd = new Random();
            // wstep do dzialu mnożenie
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Witaj w dziale matematycznym - mnożenie");   
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------\n\n");
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
            Console.Write("Podaj liczbę od 0 do jakiej chcesz ćwiczyć mnożenie: ");
            valid_mnozenie = int.TryParse(Console.ReadLine(), out wybor_mnozenie);

            do
            {
                if (valid_mnozenie)
                {
                    Console.WriteLine("Wybrałeś liczbę: " + wybor_mnozenie);
                    Console.WriteLine("\n");
                    if (wybor_mnozenie > 0)
                    {
                        licznik++;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Zadanie numer {licznik}");
                        Console.WriteLine("---------------------------------\n");
                        
                        liczba1 = rnd.Next(1, 11);
                        liczba2 = rnd.Next(1, wybor_mnozenie+1);
                        wynik = liczba1 * liczba2;

                        Console.Write("Ile jest: " + liczba1 + " * " + liczba2 + " = ?  ");
                        valid_mnozenie = int.TryParse(Console.ReadLine(), out odp);
                        
                        if (valid_mnozenie)
                        {
                            if (odp == wynik)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dobra odpowiedź!!!");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                dobra_odp++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zła odpowiedź!");
                                Console.WriteLine("\n");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Prawidłowy wynik to: {liczba1} * {liczba2} = {wynik}.  Zapamiętaj!!!");
                                Console.ResetColor();
                                zla_odp++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
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
            } while (!valid_mnozenie || wybor_mnozenie <= 0 || ilosc_pytan != licznik);
            // przejscie do wyswietlenia statystyki
            statystyka(dobra_odp, zla_odp, ilosc_pytan, dzial);
        }

// wstep do testu matematycznego
        static void Mix()
        {
            // tymczasowe zmienne
            int ilosc_pytan = 0;           
            bool valid_mix1 = false;            
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Witaj w dziale matematycznym - test matematyczny");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------\n\n");
            Console.ResetColor();

            Console.WriteLine("Test umożliwi Ci sprawdzenie twojej wiedzy matematycznej z zakresu:");
            Console.WriteLine("- dodawanie");
            Console.WriteLine("- odejmowanie");
            Console.WriteLine("- mnożenie");
            Console.WriteLine("\n");
            Console.WriteLine("Potraktój ten test jak sprawdzian z matematyki, na końcu zostaniesz oceniony.");
            Console.WriteLine("Życzę Ci powodzenia!!!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nOkreśl ilość przeprowadzonych testów MIX (z dodawania, odejmowania, mnożenia).");
            Console.Write("Liczba musi zawierać się w przedziale od 10 do 100 ?: ");
            Console.ResetColor();

            // wybór ilości pytań
            valid_mix1 = int.TryParse(Console.ReadLine(), out ilosc_pytan);
            do
            {
                if (valid_mix1)
                {
                    if (ilosc_pytan >= 10)
                    {
                        Console.Clear();
                        Console.WriteLine("Wybrałeś ilość działań: " + ilosc_pytan);
                        Console.WriteLine("\n");
                        ProgramRun(ilosc_pytan);
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        ostrzezenie("Wybrałeś liczbę mniejszą od 0!");
                        Console.WriteLine("\n");
                        Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                        Console.ReadKey();
                        Mix();
                    }
                }
                else
                {
                    Console.WriteLine("\n");
                    ostrzezenie("Nie podałeś liczby!");
                    Console.WriteLine("\n");
                    Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                    Console.ReadKey();
                    Mix();
                }
            } while (!valid_mix1 );
            
        }

// funkcja wyjscia z programu
        static void Wyjscie()
        {
            Console.Beep();
            // zamkniecie konsoli
            Environment.Exit(0);
        }

        static void ostrzezenie(string tekst)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }

// statystyka dla dodawania, odejmowania, mnożenia
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

 // start testu matematycznego
        static void ProgramRun(int ilosc_pytan)
        {
            bool valid_mix = false;
            bool valid_wynik_usera = false;
            int liczba1 = 0;
            int x = 0;
            int y = 0;
            int wyb_dzialania = 0;
            int odp_dobra_dodawanie = 0;
            int odp_zla_dodawanie = 0;
            int odp_dobra_odejmowanie = 0;
            int odp_zla_odejmowanie = 0;
            int odp_dobra_mnozenie = 0;
            int odp_zla_mnozenie = 0;
            int licznik = 0;
            int liczba_licznik_usera = 0;
            int dzialanie_dodawanie = 0;
            int dzialanie_odejmowanie = 0;   
            int dzialanie_mnozenie = 0;
            int wynik_usera = 0;



            // 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nOkreśl najwyższą liczbę działań(od 3 do 100): ");

            // wybor najwyzszej liczby w działaniach (nie dotyczy wyniku działań)
            valid_mix = int.TryParse(Console.ReadLine(), out liczba1);

            
            Random rnd = new Random();
            
            

            do
            {
                wyb_dzialania = rnd.Next(1, 4);// losowy wybór działań 1- dodawanie, 2 - odejmowanie, 3 - mnożenie
                licznik++;

                if (wyb_dzialania == 1) // dodawanie
                {
                    x = rnd.Next(1, liczba1 + 1);
                    y = rnd.Next(1, liczba1 + 1);
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Zadanie numer {licznik}    zakres: dodawanie");
                    Console.WriteLine("----------------------------------------------\n");
                    Console.ResetColor();
                    dzialanie_dodawanie = x + y;
                    Console.Write($"Ile jest: {x} + {y} = ? ");
                    valid_wynik_usera = int.TryParse(Console.ReadLine(), out wynik_usera);

                    if (valid_wynik_usera)
                    {
                        if (wynik_usera == dzialanie_dodawanie)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Dobra odpowiedź!!!");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            odp_dobra_dodawanie++;
                            Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Zła odpowiedź!");
                            Console.WriteLine("\n");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Prawidłowy wynik to: {x} + {y} = {dzialanie_dodawanie}.  Zapamiętaj!!!");
                            Console.ResetColor();
                            odp_zla_dodawanie++;
                            Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        ostrzezenie("Nie podałeś liczby!");
                    }

                }
                else if (wyb_dzialania == 2) // odejmowanie
                {
                    x = rnd.Next(1, liczba1 + 1);
                    y = rnd.Next(1, liczba1 + 1);
                    if (x<y)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Zadanie numer {licznik}    zakres: odejmowanie");
                        Console.WriteLine("----------------------------------------------\n");
                        Console.ResetColor();
                        dzialanie_odejmowanie = y - x;
                        Console.Write($"Ile jest: {y} - {x} = ? ");
                        valid_wynik_usera = int.TryParse(Console.ReadLine(), out wynik_usera);

                        if (valid_wynik_usera)
                        {
                            if (wynik_usera == dzialanie_odejmowanie)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dobra odpowiedź!!!");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                odp_dobra_odejmowanie++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zła odpowiedź!");
                                Console.WriteLine("\n");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Prawidłowy wynik to: {y} - {x} = {dzialanie_odejmowanie}.  Zapamiętaj!!!");
                                Console.ResetColor();
                                odp_zla_odejmowanie++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            ostrzezenie("Nie podałeś liczby!");
                        }
                    }
                    else if (x == y)
                    {
                        x = x + 2;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Zadanie numer {licznik}    zakres: odejmowanie");
                        Console.WriteLine("----------------------------------------------\n");
                        Console.ResetColor();
                        dzialanie_odejmowanie = x - y;
                        Console.Write($"Ile jest: {x} - {y} = ? ");
                        valid_wynik_usera = int.TryParse(Console.ReadLine(), out wynik_usera);

                        if (valid_wynik_usera)
                        {
                            if (wynik_usera == dzialanie_odejmowanie)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dobra odpowiedź!!!");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                odp_dobra_odejmowanie++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zła odpowiedź!");
                                Console.WriteLine("\n");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Prawidłowy wynik to: {x} - {y} = {dzialanie_odejmowanie}.  Zapamiętaj!!!");
                                Console.ResetColor();
                                odp_zla_odejmowanie++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            ostrzezenie("Nie podałeś liczby!");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Zadanie numer {licznik}    zakres: odejmowanie");
                        Console.WriteLine("----------------------------------------------\n");
                        Console.ResetColor();
                        dzialanie_odejmowanie = x - y;
                        Console.Write($"Ile jest: {x} - {y} = ? ");
                        valid_wynik_usera = int.TryParse(Console.ReadLine(), out wynik_usera);

                        if (valid_wynik_usera)
                        {
                            if (wynik_usera == dzialanie_odejmowanie)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Dobra odpowiedź!!!");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                odp_dobra_odejmowanie++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zła odpowiedź!");
                                Console.WriteLine("\n");
                                Console.ResetColor();
                                Console.WriteLine("\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Prawidłowy wynik to: {x} - {y} = {dzialanie_odejmowanie}.  Zapamiętaj!!!");
                                Console.ResetColor();
                                odp_zla_odejmowanie++;
                                Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                                Console.ReadKey();
                            }
                        }
                    }

                    
                }
                else if (wyb_dzialania == 3) // mnożenie
                {
                    if (liczba1 > 10)
                    {
                        x = rnd.Next(1, 11);
                        y = rnd.Next(1, 11);
                    }
                    else
                    {
                        x = rnd.Next(1, liczba1 + 1);
                        y = rnd.Next(1, liczba1 + 1);
                    }
                    
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"Zadanie numer {licznik}    zakres: mnożenie");
                    Console.WriteLine("----------------------------------------------\n");
                    Console.ResetColor();
                    dzialanie_mnozenie = x * y;
                    Console.Write($"Ile jest: {x} * {y} = ? ");
                    valid_wynik_usera = int.TryParse(Console.ReadLine(), out wynik_usera);

                    if (valid_wynik_usera)
                    {
                        if (wynik_usera == dzialanie_mnozenie)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Dobra odpowiedź!!!");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            odp_dobra_mnozenie++;
                            Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Zła odpowiedź!");
                            Console.WriteLine("\n");
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Prawidłowy wynik to: {x} * {y} = {dzialanie_mnozenie}.  Zapamiętaj!!!");
                            Console.ResetColor();
                            odp_zla_mnozenie++;
                            Console.WriteLine("\n\nNaciśnij jakikolwiek klawisz aby kontynuować...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        ostrzezenie("Nie podałeś liczby!");
                    }
                }
                else
                {
                    ostrzezenie("Nie ma takiej opcji w menu!");
                    Console.WriteLine("\n");
                    Console.WriteLine("Naciśnij jakikolwiek klawisz aby kontynuować...");
                    Console.ReadKey();
                }
            } while (!valid_mix || ilosc_pytan != licznik || liczba1 < 3 || liczba1 >100);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Koniec testu!!!");
            Console.WriteLine("\n\nZobacz ststystykę testu i sprawdź w czym jesteś dobry a co musisz poprawić.\n\n");
            Console.ResetColor();

            Console.WriteLine("Naciśnij jakikolwiek klawisz aby kontynuować...");
            Console.ReadKey();
            StatystykaTestuMatematycznego(odp_dobra_dodawanie, odp_zla_dodawanie, odp_dobra_odejmowanie, odp_zla_odejmowanie, odp_dobra_mnozenie, odp_zla_mnozenie);
        }        
        
// statystyka dla testu matematycznego
        static void StatystykaTestuMatematycznego(int odp_dobra_dodawanie, int odp_zla_dodawanie, int odp_dobra_odejmowanie, int odp_zla_odejmowanie, int odp_dobra_mnozenie, int odp_zla_mnozenie)
        {
            Console.WriteLine("Statystyka testu matematycznego:");
            Console.WriteLine("--------------------------------\n\n");
            Console.WriteLine("Dodawanie:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ilość dobrych odpowiedzi: {odp_dobra_dodawanie}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ilość złych odpowiedzi: {odp_zla_dodawanie}");
            Console.ResetColor();
            
            Console.WriteLine("\n\nOdejmowanie:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ilość dobrych odpowiedzi: {odp_dobra_odejmowanie}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ilość złych odpowiedzi: {odp_zla_odejmowanie}");
            Console.ResetColor();
            
            Console.WriteLine("\n\nMnożenie:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ilość dobrych odpowiedzi: {odp_dobra_mnozenie}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ilość złych odpowiedzi: {odp_zla_mnozenie}");
            Console.ResetColor();
            
            Console.WriteLine("\n\nWynik ogólny:");
            Console.WriteLine("-------------\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ilość dobrych odpowiedzi: {odp_dobra_dodawanie + odp_dobra_odejmowanie + odp_dobra_mnozenie}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ilość złych odpowiedzi: {odp_zla_dodawanie + odp_zla_odejmowanie + odp_zla_mnozenie}");            
            Console.ResetColor();   

            Console.WriteLine("\nNaciśnij klawisz aby wrócić do menu głównego.......");
            Console.ReadKey();
            Main(null);
        }
    }
}
