using System;
using System.ComponentModel.Design;

namespace ExercisePetle8
{
    class Program
    {
        private static void Main(string[] args)
        {
            string a = "";
            string b = "";
            Console.WriteLine("Wpisz dowolny tekst");
            a = Console.ReadLine();
            //Creating inverted string
            for (int i = a.Length-1; i >= 0; i--)
            {
                b = b + a[i];               
            }
            Console.WriteLine(b);
        }
    }
}
