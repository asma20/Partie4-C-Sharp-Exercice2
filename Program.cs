using System;
using System.Collections.Generic;

namespace Partie4Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> langague = new List<String>();
            langague.Add("HTML");
            langague.Add("CSS");
            langague.Add("javascript");
            langague.Add("jquery");
            langague.Add("php");
            langague.Add("boostarp");
            langague.Add("java");
            foreach (String l in langague) {
                Console.WriteLine(l);
            }

            Console.WriteLine("le 4 éme élement "+langague[3]); 
            Console.WriteLine("l'élement à l'index 4 " + langague[4]);
            langague.RemoveAt(5);
            langague[2] = "javascript";

            langague.Add("c");

            foreach (String l in langague)
            {
                Console.WriteLine(l);
            }



        }
    }
}
