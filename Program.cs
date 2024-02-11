using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cezario_Sifras
{
    class Program
    {
        static char[] abecele = {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

        /*
        static char[] abecele = {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

        static char[] abecele = {
                'A', 'Ą', 'B', 'C', 'Č', 'D', 'E', 'Ę', 'Ė', 'F', 'G', 'H', 'I', 'Į', 'Y', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'R', 'S', 'Š', 'T', 'U', 'Ų', 'Ū', 'V', 'Z', 'Ž',
            };

        static char[] abecele = {
                'A', 'Ą', 'B', 'C', 'Č', 'D', 'E', 'Ę', 'Ė', 'F', 'G', 'H', 'I', 'Į', 'Y', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'R', 'S', 'Š', 'T', 'U', 'Ų', 'Ū', 'V', 'Z', 'Ž',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
        */
        public static char sifruotiRaide(char ch, int poslinkis, char[] abecele)
        {
            int abecelesIlgis = abecele.Length;

            if (!abecele.Contains(ch))
            {
                return ch;
            }

            int raidesPozicija = Array.IndexOf(abecele, ch);

            return abecele[(raidesPozicija + poslinkis) % abecelesIlgis];
        }

        public static char desifruotiRaide(char ch, int poslinkis, char[] abecele)
        {
            int abecelesIlgis = abecele.Length;

            return sifruotiRaide(ch, abecelesIlgis - poslinkis, abecele);
        }

        public static char sifruotiSimboli(char ch, int poslinkis)
        {
            int sifruotasASCII = ch + poslinkis;

            sifruotasASCII = (sifruotasASCII - 32) % (127 - 32) + 32;
            return (char)sifruotasASCII;
        }

        public static char desifruotiSimboli(char ch, int poslinkis)
        {
            int desifruotasASCII = ch - poslinkis;
            desifruotasASCII = (desifruotasASCII - 32 + (127 - 32)) % (127 - 32) + 32;

            return (char)desifruotasASCII;
        }

        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Pasirinkite:");
                Console.WriteLine("1. Šifravimas tik raidžių ir skaičių (Cezario metodu)");
                Console.WriteLine("2. Dešifravimas tik raidžių ir skaičių (Cezario metodu)");
                Console.WriteLine("3. Šifravimas bet kokių simbolių (Cezario metodu)");
                Console.WriteLine("4. Dešifravimas bet kokių simbolių (Cezario metodu)");
                Console.WriteLine("5. Baigti");
                char pasirinkimas = char.Parse(Console.ReadLine());
                //int pasirinkimas = int.Parse(Console.ReadLine());

                switch (pasirinkimas)
                {
                    case '1': // Šifravimas Cezario metodu tik raides ir skaičius

                        Console.Write("Ivesktite tekstą, kurį norite užšifruoti: ");
                        string nesifruotasTekstas = Console.ReadLine();
                        Console.Write("Iveskite poslinkį: ");
                        int poslinkis = int.Parse(Console.ReadLine());

                        string sifruotasAtsakymas = "";
                        foreach(char ch in nesifruotasTekstas)
                        {
                            sifruotasAtsakymas += sifruotiRaide(ch, poslinkis, abecele);
                        }

                        Console.WriteLine($"Užšifruotas tekstas: {sifruotasAtsakymas}");
                        Console.WriteLine();

                        break;

                    case '2': // Dešifravimas Cezario metodu tik raides ir skaicius

                        Console.Write("Iveskite testą, kurį norite dešifruoti: ");
                        string sifruotasTekstas = Console.ReadLine();
                        Console.Write("Iveskite poslinki: ");
                        int poslinkis2 = int.Parse(Console.ReadLine());

                        string desifruotasAtsakymas = "";
                        foreach(char ch in sifruotasTekstas)
                        {
                            desifruotasAtsakymas += desifruotiRaide(ch, poslinkis2, abecele);
                        }

                        Console.WriteLine($"Dešifruotas tekstas: {desifruotasAtsakymas}");
                        Console.WriteLine();

                        break;

                    case '3': // Šifravimas bet kokių simbolių Cezario metodu

                        Console.Write("Ivesktite tekstą, kurį norite užšifruoti: ");
                        string nesifruotasTekstas2 = Console.ReadLine();
                        Console.Write("Iveskite poslinkį: ");
                        int poslinkis3 = int.Parse(Console.ReadLine());

                        string sifruotasAtsakymas2 = "";
                        foreach(char ch in nesifruotasTekstas2)
                        {
                            sifruotasAtsakymas2 += sifruotiSimboli(ch, poslinkis3);
                        }

                        Console.WriteLine($"Užšifruotas tekstas: {sifruotasAtsakymas2}");
                        Console.WriteLine();

                        break;

                    case '4': // Dešifravimas bet kokių simbolių Cezario metodu

                        Console.Write("Iveskite testą, kurį norite dešifruoti: ");
                        string sifruotasTekstas2 = Console.ReadLine();
                        Console.Write("Iveskite poslinki: ");
                        int poslinkis4 = int.Parse(Console.ReadLine());

                        string desifruotasAtsakymas2 = "";
                        foreach(char ch in sifruotasTekstas2)
                        {
                            desifruotasAtsakymas2 += desifruotiSimboli(ch, poslinkis4);
                        }

                        Console.WriteLine($"Dešifruotas tekstas: {desifruotasAtsakymas2}");
                        Console.WriteLine();

                        break;

                    case '5':
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Tokio pasirinkimo nėra!");
                        break;
                }
            }

        }
    }
}