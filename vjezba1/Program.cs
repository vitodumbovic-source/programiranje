using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    internal class Program
    {
        static double PovrsinaPravokutnika(double a, double b) 
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {

                Console.WriteLine("1. Zadatak");
                Console.WriteLine("2. Zadatak");
                Console.WriteLine("4. Zadatak");
                Console.WriteLine("0. Kraj");

                Console.WriteLine("Unesite broj zadatka: ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        Zad01();
                        break;
                    case "2":
                        Zad02();
                        break;
                    case "3":
                        Zad03();
                        break;
                    case "4":
                        Zad04(); 
                        break;
                   
                    default:
                        Console.WriteLine("Nepoznat izbor");
                        break;
                }

            } while (izbor != "0");
        }

        static void Zad01()
        {


        }

        static void Zad02()
        {
            

        }
        static void Zad03()
        {
            Console.WriteLine("Zadatak 3");
            Console.WriteLine("Unesite stranicu Pravokutnika a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite stranicu Pravokutnika b: ");
            double b = double.Parse(Console.ReadLine());
            double povrsina = PovrsinaPravokutnika(a, b);
            Console.WriteLine($"Povrsina pravokutnika je: {povrsina}");
            Console.WriteLine($"Povrsina pravokutnika je: {PovrsinaPravokutnika(a, b)} ");
        }
        static void Zad04() 
        {
             
        }
    }
}

