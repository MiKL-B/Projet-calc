using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace myApp
{

    public class Calculateur
    {
        public string Nom
        {
            get;
            set;
        }
        public int Valeur
        {
            get;
            set;
        }
        public Calculateur(string n = "", int v = 0)
        {
            this.Nom = n;
            this.Valeur = v;
        }
        public static void memorizeVar(string expr)
        {
            Dictionary<string, double> memovar = new Dictionary<string, double>();


            // int val = 0;
            // string pattern = "[0-9]";
            // System.Console.WriteLine(Regex.Match(expr,pattern));
            // memovar.Add();
            foreach (KeyValuePair<string, double> item in memovar)
            {
                System.Console.WriteLine("key = {0}, value = {1}", item.Key, item.Value);
            }

        }
        //recevoir les demandes de calcul
        //retourner les résultats
    }
}