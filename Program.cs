﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie wykonywane jest bez liczb zespolonych
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Menu Główne");
            Console.WriteLine("1. Miejsca zerowe równania kwadratowego.");
            Console.WriteLine("2. Wyjście");

            string result = Console.ReadLine();
            if (result == "1")
            {
                Form();
                return true;
            }
            else if (result == "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static void Form()
        {
            Console.Clear();
            Console.WriteLine("Wpisz współczynniki liczbowe a, b i c." + Environment.NewLine +
                "Pamiętaj, aby współczynnik a był wartością niezerową." + Environment.NewLine); //zmiana z: "Pamiętaj, aby współczynnik a był równy lub większy 0."

            Console.Write("Wpisz współczynnik a: ");
            double valueA;

            if (!Double.TryParse(Console.ReadLine(), out valueA))
            {
                Console.WriteLine("Wprowadzono nieprawidłowy znak." + Environment.NewLine);
                return; // return wraca do metody Main()? odp.: return nie wraca do funkcji main tylko zakańcza działanie funkcji form()
            }
            else if (valueA == 0)
            {
                //Console.Beep();
                Console.WriteLine("Równanie ze współczynnikiem a równym 0 " +
                    "nie jest równaniem kwadratowym." + Environment.NewLine);
                return;
            }

            Console.Write("Wpisz współczynnik b: ");
            double valueB;
            if (!Double.TryParse(Console.ReadLine(), out valueB))
            {
                Console.WriteLine("Wprowadzono nieprawidłowy znak." + Environment.NewLine);
                return; // jak wrócić do poprzedniego user inputu? odp.: stworzyć osobną metodę dla
                        // wprowadzania współczynnika (jedna metoda dla wszystkich wspolczynnikow)
                        // i wywolywac w pętli dopoki wprowadzony wspolczynnik nie bedzie poprawny
            }

            Console.Write("Wpisz współczynnik c: ");
            double valueC;
            if (!Double.TryParse(Console.ReadLine(), out valueC))
            {
                Console.WriteLine("Wprowadzono nieprawidłowy znak." + Environment.NewLine);
                return;
            }

            Console.Clear();
            Root(valueA, valueB, valueC);
        }

        public static void Root(double valueA, double valueB, double valueC) // dlaczego konieczne jest
                                                                             // zadeklarowanie zmiennych
                                                                             // w argumencie tworzonej
                                                                             // metody?
        {
            double delta = (valueB * valueB) - (4 * valueA * valueC);

            double firstRoot = (-1 * valueB - Math.Sqrt(delta)) / (2 * valueA);
            double secondRoot = (-1 * valueB + Math.Sqrt(delta)) / (2 * valueA);
            double zeroRoot = (-1 * valueB) / (2 * valueA);

            if (delta > 0)
            {
                Console.WriteLine("Pierwiastki x1 i x2 wynoszą kolejno: {0} {1}",
                    firstRoot, secondRoot);
                Console.ReadLine();
            }
            if (delta < 0)
            {
                Console.WriteLine("Pierwiastek x wynosi: {0}", zeroRoot);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Wynik należy do zbioru liczb zespolonych");
                Console.ReadLine();

            }
        }
    }
}