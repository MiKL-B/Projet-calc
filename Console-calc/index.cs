using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace myApp
{
    public class index : IMemory
    {
        protected Dictionary<string, double> memory;

        index()
        {
            this.memory = new Dictionary<string, double>();
            // this.Reset();
        }

        /* METHODES */
        public void PrintMemory()
        {
            foreach (KeyValuePair<string, double> item in this.memory)
            {
                System.Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
        public void Memorize(string k, double v)
        {

        }
        public double Recall(string k)
        {
            return 0.0f;
        }
        public (bool Success, double Value, string Error) Calculate(string expr)
        {
            if (!Parser.Parse(expr))
            {
                return (false, 0, $"Syntax Error in '{expr}'");
            }
            if (Parser.LastExpression == null)
            {
                return (false, 0, $"Syntax Error in '{expr}'");
            }
            ASTree t = Parser.LastExpression ?? new ASTree();
            try
            {
                double res = t.Evaluate(this);
                return (true, res, "");
            }
            catch (Exception)
            {
                return (false, 0, $"Evaluation Error in '{t}'");
            }
        }
        /* MAIN */
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            index i = new index();
            string expr = "";

            System.Console.WriteLine("calculatrice : ");
            System.Console.WriteLine("saisir 'quitter'  pour quitter !");
            System.Console.WriteLine("saisir 'memoire'  pour afficher la memoire !");
            /* APPEL DU PROGRAMME */
            while (expr != "quitter")
            {
                expr = Console.ReadLine() ?? "";
                switch (expr)
                {
                    case "quitter":
                        break;
                    case "memoire":
                        i.PrintMemory();
                        break;
                    default:
                        (bool Success, double Value, string Error) r = i.Calculate(expr);
                        System.Console.WriteLine(r.Value);
                        break;
                }
            }



            /* APPEL DES TESTS*/
            // Console.WriteLine("\n😁✅ Tests acceptés ✅😁\n");
            // Console.WriteLine("\n🤮❌💩 Tests refusés 💩❌🤮\n");
            // Console.WriteLine("Testing ASTree...");
            // tl1 -x + 2
            List<ASTree> t = new List<ASTree>();
            // List<ASTree> tl1 = new List<ASTree>();
            // tl1.Add(new ASTree(ASType.UNARYOP, "-"));
            // tl1.Add(new ASTree(ASType.VARIABLE, "x"));
            // tl1.Add(new ASTree(ASType.OPERATOR, "+"));
            // t.Add(new ASTree(ASType.NUMERIC, "2", tl1));
            ReversePolishNotationExporter rpn = new ReversePolishNotationExporter();
            TextExporter te = new TextExporter();
            LispExporter li = new LispExporter();
            Memory m = new Memory();

            foreach (ASTree ast in t)
            {
                DisplayTests(ast, m, rpn, te, li);
            }
            Console.WriteLine();
        }

        /* TEST */
        public static void DisplayTests(ASTree t, IMemory m, ReversePolishNotationExporter rpn, TextExporter te, LispExporter li)
        {
            Console.WriteLine("\n😎 Tests notations 😎\n");
            Console.WriteLine($"LISP  : {t.Serialize(li)}");
            Console.WriteLine($"RPN  : {t.Serialize(rpn)}");
            Console.WriteLine($"Text : {t.Serialize(te)}");
            Console.WriteLine($"Eval : {t.Evaluate(m)}");
        }




    }
}
