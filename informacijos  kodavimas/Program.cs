using System;
using System.Security.Cryptography;
using System.IO;

namespace crypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var key = "b14ca5898a4e4133bbce2ea2315a1916";  
            while (i != 1) {
                Console.WriteLine("Pasirinkite ka norite daryti:");
                Console.WriteLine("1 - uzsifruoti teksta");
                Console.WriteLine("2 - desifruoti teksta");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    int j = 0;

                    while(j != 1) {

                        Console.Clear();
                        Console.WriteLine("pasirinkite sifravimo metoda");
                        Console.WriteLine("1 - AES");
                        Console.WriteLine("2 - 3DES");
                        string pasirinkimas = Console.ReadLine();
                        if (pasirinkimas == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Irasykite ka norite uzsifruoti: ");
                            var str = Console.ReadLine();
                            Console.Clear();
                            var sifruojamas = Kodavimas.AESSifravimas(key, str);
                            Console.WriteLine($"uzsifruotas tekstas = {sifruojamas}");
                            j = 1;
                        }
                        if (pasirinkimas == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Irasykite ka norite uzsifruoti: ");
                            var tekstas = Console.ReadLine();
                            Console.Clear();
                            var sifruoju = Kodavimas.SSifravimas(key, tekstas);
                            Console.WriteLine($"uzsifruotas tekstas = {sifruoju}");
                            j = 1;

                        }
                        else if (pasirinkimas != "1" && pasirinkimas != "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Irasykite teisinga pasirinkima");
                            
                        }

                    }

                    i = 1;

                }
                if (choice == "2")
                {
                    int j = 0;

                    while (j != 1) {
                        Console.Clear();
                        Console.WriteLine("pasirinkite sifravimo metoda");
                        Console.WriteLine("1 - AES");
                        Console.WriteLine("2 - 3DES");
                        string pasirinkimas = Console.ReadLine();

                        if (pasirinkimas == "1") {

                            Console.Clear();
                            Console.WriteLine("Irasykite teksta kuri norite desifruoti");
                            string sifruotas = Console.ReadLine();
                            Console.Clear();
                            var desifruojamas = Kodavimas.AESDesifravimas(key, sifruotas);
                            Console.WriteLine($"Desifruotas tekstas = {desifruojamas}");
                            Console.ReadKey();
                            File.WriteAllText("AESDesifruotas.txt", desifruojamas);
                            j = 1;

                        }

                        if (pasirinkimas == "2")
                        {

                            Console.Clear();
                            Console.WriteLine("Irasykite ka norite desifruoti: ");
                            var tekstas = Console.ReadLine();
                            Console.Clear();
                            var sifruoju = Kodavimas.SDesifravimas(key, tekstas);
                            Console.WriteLine($"Desifruotas tekstas = {sifruoju}");
                            j = 1;

                        }
                        else if (pasirinkimas != "1" && pasirinkimas != "2") {
                            Console.Clear();
                            Console.WriteLine("Irasykite teisinga pasirinkima");
                        }

                    }   

                    i = 1;

                }
                else if(choice != "1" && choice != "2")
                {
                    Console.Clear();
                    Console.WriteLine("Irasykite teisinga pasirinkima");
                }

            }

            while (true) ;

        }
    }
}

