using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Winforms_calc
{
    public class Parser
    {
        protected string[] tokens;
        protected int pos { get; set; }
        protected Stack<int> memory;
        protected bool debug { get; set; }
        protected Stack<ASTree> forest { get; set; }
        protected Stack<int> forestMemory;
        public static ASTree LastExpression;

        //PARSE//
        public static bool Parse(string expr, bool debug = false)
        {
            //création d'un objet Parser qui s'appelle pars
            Parser pars = new Parser();
            pars.debug = debug;
            bool res = pars.ParseCmds(expr, debug);
            if (!res)
            {
                Console.Error.WriteLine($"Error at token {pars.pos}='{pars.token()}' in {expr}");
            }

            return res;

        }

        //PARSECMDS//
        public bool ParseCmds(string expr, bool debug = false)
        {
            bool result;
            //définir une regex
            string regexp = "\\s*(\\+|\\*|-|/|%|\\(|\\)|;|<|←|,)\\s*";
            //on retire les espaces au début et a la fin de chaines
            //on découpe la chaine selon la regex et on insère les "mots" dans un tableau
            this.tokens = Regex.Split(expr.Trim(), regexp).Where(c => c != String.Empty).ToArray();
            this.pos = 0; // On définis la position par défaut dans notre tableau
            this.memory = new Stack<int>();
            this.forestMemory = new Stack<int>();
            this.forest = new Stack<ASTree>();
            result = this.script();

            if (debug)
            {
                Console.WriteLine(expr);
                foreach (string e in tokens)
                {
                    Console.Write($"'{e}' ");
                }
                Console.WriteLine("");
            }
            if (result)
            {
                Parser.LastExpression = this.forest.Pop();
            }
            return result;
        }

        protected void d(string s)
        {
            if (this.debug)
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrames()[1];
                Console.WriteLine($"[{stackFrame.GetMethod().Name}] {this.pos} {s}");
            }
        }

        //TOKEN//
        protected string token()
        {
            if (!this.eos())
                return this.tokens[this.pos];
            return "";// On retourne le mot qui se trouve à notre position
        }

        //NEXTTOKEN//
        protected void nextToken()
        {
            if (!this.eos())
            {
                this.pos++; // On avance notre position de 1
            }
        }

        //MEMORIZE//
        protected void memorize()
        {     // On empile notre position dans memory (on l'enregistre)
            this.memory.Push(this.pos);
            this.forestMemory.Push(this.forest.Count);

        }

        //RECALL//
        protected void recall()
        {
            // On redéfinis pos égale à la dernière insertion au sein de la pile et on supprime ce résultat (tout est fait pas Pop)
            this.pos = this.memory.Pop();
            int nbElements = this.forestMemory.Pop();
            while (this.forest.Count > nbElements)
            {
                this.forest.Pop();
            }
        }

        //EOS//
        protected bool eos()
        {
            return this.pos == this.tokens.Length; // On renvoie un bool pour savoir si on arrive à la fin de notre script
        }

        //SCRIPT//
        protected bool script()
        {
            d(this.token());
            this.memorize(); // On enregistre notre position au sein d'un string
            if (this.affect_expr())
            {
                // Si on a une expression d'affectation qui est correct (true)
                return this.end_script(); // Alors je retourne la valeur booléenne de la fin du script afin de savoir si elle est correct (si j'ai une fin ou non) (true/false)
            }
            this.recall(); // On reviens à notre première position

            if (this.arith_expr())
            {
                // Si on a une expression arithmétique qui est correct (true)
                return this.end_script(); // Alors je retourne la valeur booléenne de la fin du script afin de savoir si elle est correct (si j'ai une fin ou non) (true/false)
            }

            return false; // Par défaut on retourne faux (false) car aucune expression arith_expr() n'est trouvé.
        }

        //END_SCRIPT//
        protected bool end_script()
        {

            d(this.token());
            if (this.eos())
            {
                return true;
            }

            if (this.token() == ";")
            {

                this.nextToken();
                if (this.eos())
                {
                    return true;
                }
                if (this.script())
                {
                    ASTree rc = this.forest.Pop();
                    ASTree lc = this.forest.Pop();
                    this.forest.Push(new ASTree(ASType.OPERATOR, ";", new List<ASTree> { lc, rc }));
                    return true;
                }
            }
            return false;
        }

        //AFFECT_EXPR//
        protected bool affect_expr()
        {
            d(this.token());

            return this.end_affect_expr(this.variable()); // On regarde si on c'est une expression d'affectation (une variable)
        }
        //AFFECT OPERATOR
        protected bool affect_operator()
        {
            if (this.token() == "←") return true;
            if (this.token() != "<") return false;
            this.nextToken();
            return this.token() == "-";
        }

        //END_AFFECT_EXPR//
        protected bool end_affect_expr(bool isVar)
        {

            d($"{this.token()} {isVar}");
            d(this.token());
            if (!isVar)
            {
                return false;
            }

            if (this.affect_operator())
            {

                this.nextToken();

                if (this.arith_expr())
                {

                    ASTree rc = this.forest.Pop();
                    ASTree lc = this.forest.Pop();
                    this.forest.Push(new ASTree(ASType.OPERATOR, "←", new List<ASTree> { lc, rc }));
                    return true;
                }
            }

            return false;
        }
        //ARITH_EXPR//
        protected bool arith_expr()
        {
            d(this.token());

            return this.end_arith_expr(this.term());
        }

        //END_ARITH_EXPR//
        protected bool end_arith_expr(bool isTerm)
        {
            d($"{this.token()} {isTerm}");
            if (!isTerm)
            {
                return false;
            }
            string op = this.token();

            if (op == "+" || op == "-")
            {
                this.nextToken();
                if (this.arith_expr())
                {
                    ASTree rc = this.forest.Pop();
                    ASTree lc = this.forest.Pop();
                    this.forest.Push(new ASTree(ASType.OPERATOR, op, new List<ASTree> { lc, rc }));
                    return true;
                }
            }
            return true;
        }

        //TERM//
        protected bool term()
        {
            d(this.token());
            return this.end_term(this.unaryMinus());
        }



        //ENDTERM//
        protected bool end_term(bool isFactor)
        {
            d($"{this.token()} {isFactor}");
            if (!isFactor)
            {
                return false;
            }

            // * ? ou / ? ou % ?
            string op = this.token();
            if (op == "*" || op == "/" || op == "%")
            {
                this.nextToken();
                if (this.term())
                {
                    ASTree rc = this.forest.Pop();
                    ASTree lc = this.forest.Pop();
                    this.forest.Push(
                      new ASTree(ASType.OPERATOR, op, new List<ASTree> { lc, rc })
                    );
                    return true;
                }
            }
            return true;
        }

        //UNARY MINUS //
        protected bool unaryMinus()
        {
            this.memorize();
            if (this.token() == "-")
            {
                this.nextToken();
                if (this.token() == "-")
                {
                    return false;
                }
                if (this.end_unary_minus())
                {
                    this.forest.Push(new ASTree(ASType.UNARYOP, "-", new List<ASTree>() { this.forest.Pop() }));
                    return true;
                }
            }
            this.recall();
            return this.factor();
        }
        //END UNARY MINUS//
        protected bool end_unary_minus()
        {

            return this.unaryMinus();
        }

        //FACTOR//
        protected bool factor()
        {
            d(this.token());
            if (this.eos())
            {
                return true;
            }
            if (this.token() == "(")
            {
                this.nextToken();

                if (this.arith_expr() && this.token() == ")")
                {
                    this.nextToken();
                    return true;
                }
                return false;
            }

            if (this.numeric())
            {
                return true;
            }

            this.memorize();
            if (this.function())
            {
                return true;
            }
            this.recall();
            if (this.variable())
            {
                return true;
            }
            return false;
        }


        protected bool variable()
        {

            if (Regex.IsMatch(this.token(), @"[a-zA-Z]+"))
            {

                this.forest.Push(new ASTree(ASType.VARIABLE, this.token()));
                this.nextToken();

                return true;
            }

            return false;
        }
        //NUMERIC//
        protected bool numeric()
        {
            d(this.token());
            //on utilise une regex pour nous dire si le token est sur un nombre réel
            if (this.token() == ".")
            {
                return false;
            }
            if (Regex.IsMatch(this.token(), @"^([0-9]+)?(\.[0-9]*)?$"))
            {
                // regex yannick   @"^[0-9]+(\.([0-9]*)?)?|\.([0-9]*)?$"
                // new regex      @"^([0-9]+)?(\.[0-9]*)?$"
                this.forest.Push(new ASTree(ASType.NUMERIC, this.token()));
                this.nextToken();
                return true;
            }

            return false;
        }

        //FUNCTION//
        protected bool function()
        {
            d(this.token());
            return this.end_function(this.func_name());
        }

        //END_FUNCTION//
        protected bool end_function(bool isArgList)
        {
            d($"{this.token()} {isArgList}");
            if (!isArgList)
            {
                return false;
            }
            this.memorize();
            if (this.token() == "(")
            {
                this.nextToken();
                if (this.arg_list() && this.token() == ")")
                {
                    this.nextToken();
                    return true;
                }
            }
            this.recall();
            return false;
        }

        //FUNC_NAME//
        protected bool func_name()
        {
            d(this.token());
            string re = @"^sqrt|pow|sin|cos|tan|asin|acos|atan|pi|e|ln$";
            if (Regex.IsMatch(this.token(), re))
            {
                this.forest.Push(new ASTree(ASType.FUNCTION, this.token()));
                this.nextToken();
                return true;
            }
            return false;

        }

        //ARG_LIST//
        protected bool arg_list()
        {
            d(this.token());
            if (this.token() == ")")
            {
                return true;
            }
            if (this.arith_expr())
            {
                ASTree arg = this.forest.Pop();
                this.forest.Peek().AddChild(arg);
                return this.end_arg_list(true);
            }
            return true;
        }

        //END_ARG_LIST//
        protected bool end_arg_list(bool isArg)
        {
            d($"{this.token()} {isArg}");
            if (!isArg)
            {
                return false;
            }

            if (this.token() == ",")
            {
                this.nextToken();
                return this.arg_list();
            }
            if (this.token() == ")")
            {
                return true;
            }
            return false;
        }

        //   SEND_MSG//
        public static bool SendMsg(string expr, bool debug = false)
        {
            string msg;
            if (!Parser.Parse(expr, debug))
            {
                return false;
            }
            Memory m = new Memory();
            //Console.WriteLine(Parser.LastExpression.ToString());
            //Console.WriteLine("text : " + Parser.LastExpression.Serialize(new TextExporter()));
            //Console.WriteLine("lisp : " + Parser.LastExpression.Serialize(new LispExporter()));
            //Console.WriteLine("rpn : " + Parser.LastExpression.Serialize(new ReversePolishNotationExporter()));
            Console.WriteLine("eval : " + Parser.LastExpression.Evaluate(m));

            return true;

        }
        public static void test(string expr, bool debug = false)
        {
            string msg;
            if (!Parser.Parse(expr, debug))
            {

                msg = "❌ Expression non valide :  " + expr;

            }
            else
            {
                msg = "✅ Expression valide     :  " + expr;
            }
            Console.WriteLine(msg);
        }

        public static bool testExport(string expr, string attendu, string formatExport)
        {

            Parse(expr);
            string resultat = "";

            switch (formatExport)
            {
                case "te":
                    // text  
                    // x←42 =  x ← 42
                    resultat = LastExpression.Serialize(new TextExporter());
                    break;
                case "li":
                    // lisp réponse attendue  ( ← x 42 )
                    // text = lisp
                    // x←42 = ( ← x 42 )
                    resultat = LastExpression.Serialize(new LispExporter());
                    break;
                case "rpn":
                    // rpn réponse attendue x 42 ←
                    // text   = rpn
                    //  x←42 = x 42 ←
                    resultat = LastExpression.Serialize(new ReversePolishNotationExporter());
                    break;

                default:
                    break;
            }

            if (resultat == attendu)
            {
                Console.WriteLine($"entrée : {expr} \nattendu : {attendu} \nresultat : {resultat}\n");
                return true;
            }
            Console.WriteLine("pas text : " + expr);

            return false;
        }
        // public static bool calculExport(string expr, double attendu)
        // {
        //     Parse(expr);

        //     Dictionary<string, double> m = new Dictionary<string, double>();
        //     double resultat = LastExpression.Evaluate(m);
        //     if (resultat == attendu)
        //     {
        //         System.Console.WriteLine($"entrée : {expr} \nattendu : {attendu} \nresultat : {resultat}\n");
        //         return true;
        //     }
        //     System.Console.WriteLine($"tu sais pas compter !  {expr} ça fait {resultat} et pas {attendu}");
        //     return false;
        // }


        public static void verifExprExport(string expr)
        {
            //expr A                                 exprB                                 exprC
            // x←42 --parse --> treeA--toString()--> x ← 42 --parse-->treeB--toString()--> x ← 42
            Parse(expr);

            string resultatA = "";
            Console.WriteLine("entrée : " + expr);

            resultatA = LastExpression.Serialize(new TextExporter());

            Console.WriteLine("sérializé  : " + resultatA);

            Parse(resultatA);

            string resultatB = LastExpression.Serialize(new TextExporter());
            Console.WriteLine("retour en text : " + resultatB);
            if (resultatA == resultatB)
            {
                System.Console.WriteLine("true");
            }
            else
            {
                System.Console.WriteLine("false");
            }
        }



    }


}

