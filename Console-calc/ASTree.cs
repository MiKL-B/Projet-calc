using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace myApp
{

    public enum ASType
    {
        NUMERIC,
        VARIABLE,
        FUNCTION,
        OPERATOR,
        UNARYOP
    };
    public interface IExporter
    {
        string Export(ASTree tree);
    }
    public class ReversePolishNotationExporter : IExporter
    {
        public string Export(ASTree t)
        {

            string retour = "";
            if (t.Children != null && t.Children.Count > 0)
            {
                foreach (ASTree child in t.Children)
                {
                    retour += child.Serialize(this) + " ";
                }
            }
            retour += t.Root;
            if (t.Type == ASType.FUNCTION)
            {
                retour += "()";
            }
            return retour;
        }
    }
    public class TextExporter : IExporter
    {
        public string Export(ASTree t)
        {
            string retour = "";
            switch (t.Type)
            {
                case ASType.NUMERIC:
                case ASType.VARIABLE:
                    return t.Root;
                case ASType.FUNCTION:
                    retour = t.Root + "(";
                    bool first = true;

                    if (t.Children != null)
                    {
                        foreach (ASTree child in t.Children)
                        {
                            if (!first)
                            {
                                retour += ", ";
                            }
                            else
                            {
                                first = false;
                            }
                            retour += child.Serialize(this);
                        }
                    }
                    retour += ")";
                    break;
                case ASType.OPERATOR:
                    //left side
                    if ((t.Root == "*" || t.Root == "/" || t.Root == "%") && (t.Children[0].Root == "+" || t.Children[0].Root == "-"))
                    {
                        retour += "(" + t.Children[0].Serialize(this) + ")";
                    }
                    else
                    {
                        retour = t.Children[0].Serialize(this);
                    }

                    for (int i = 1; i < t.Children.Count; i++)
                    {
                        retour += " " + t.Root + " ";
                        //right side
                        if ((t.Root == "*" || t.Root == "/" || t.Root == "%") && (t.Children[i].Root == "+" || t.Children[i].Root == "-"))
                        {
                            retour += "(" + t.Children[i].Serialize(this) + ")";
                        }
                        else
                        {
                            retour +=
                                t.Children[i].Serialize(this);
                        }
                    }
                    break;
                case ASType.UNARYOP:
                    retour = t.Root + t.Children[0].Serialize(this);
                    break;
                default:
                    Console.Error.WriteLine($"Unknown type {t.Type}");
                    break;
            }
            return retour;

        }
    }

    public class LispExporter : IExporter
    {
        public string Export(ASTree t)
        {

            string retour = "";

            if (t.Type == ASType.NUMERIC || t.Type == ASType.VARIABLE)
            {
                retour = t.Root;
            }
            else if (t.Children != null)
            {

                if (t.Children.Count == 1)
                {
                    retour = "( " + t.Root + " " + t.Children[0].Serialize(this) + " )";
                }
                else
                {
                    retour = "(" + t.Root + " " + t.Children[0].Serialize(this) + " " + t.Children[1].Serialize(this) + ")";
                }
            }

            return retour;
        }
    }
    /*MEMORY*/
    public interface IMemory
    {
        public void Memorize(string k, double v);
        public double Recall(string k);
    }

    public class Memory : IMemory
    {
        public Dictionary<string, double> memory;

        public Memory()
        {
            this.memory = new Dictionary<string, double>();
        }

        public void Memorize(string k, double v)
        {
            this.memory[k] = v;
        }

        public double Recall(string k)
        {
            if (this.memory.ContainsKey(k))
            {
                return this.memory[k];
            }
            return 0;
        }
    }

    //class ASTree
    public class ASTree
    {
        //attributs
        public string Root
        {
            get;
            set;
        }
        public List<ASTree> Children
        {
            get;
            set;
        }
        public ASType Type
        {
            get;
            set;
        }
        public ASTree(ASType t = ASType.NUMERIC, string r = "0", List<ASTree>? c = null)
        {
            this.Root = r;
            this.Type = t;
            this.Children = c;
        }
        public void AddChild(ASTree t)
        {
            if (Children == null)
            {
                Children = new List<ASTree>();
            }
            Children.Add(t);
        }
        public double Evaluate(IMemory m)
        {
            double retour = 0.0f;
            switch (this.Type)
            {
                case ASType.NUMERIC:
                    double.TryParse(
                        this.Root, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-GB"), out retour
                    );
                    break;
                case ASType.VARIABLE:
                    retour = m.Recall(this.Root);
                    break;

                case ASType.FUNCTION:
                    switch (this.Root)
                    {
                        case "sqrt":
                            retour = Math.Sqrt(this.Children[0].Evaluate(m));
                            break;
                        case "pow":
                            retour = Math.Pow(this.Children[0].Evaluate(m), this.Children[1].Evaluate(m));
                            break;
                        case "sin":
                            retour = Math.Sin(this.Children[0].Evaluate(m));
                            break;
                        case "cos":
                            retour = Math.Cos(this.Children[0].Evaluate(m));
                            break;
                        case "tan":
                            retour = Math.Tan(this.Children[0].Evaluate(m));
                            break;
                        case "asin":
                            retour = Math.Asin(this.Children[0].Evaluate(m));
                            break;
                        case "acos":
                            retour = Math.Acos(this.Children[0].Evaluate(m));
                            break;
                        case "atan":
                            retour = Math.Atan(this.Children[0].Evaluate(m));
                            break;
                        case "pi":
                            retour = Math.PI;
                            break;
                        case "e":
                            retour = Math.E;
                            break;
                        case "ln":
                            retour = Math.Log(this.Children[0].Evaluate(m));
                            break;
                        default:
                            Console.Error.WriteLine("error function" + this.Root);
                            break;
                    }
                    break;
                case ASType.OPERATOR:
                    if (this.Children != null)
                    {
                        switch (this.Root)
                        {
                            case "+":
                                retour = this.Children[0].Evaluate(m) + this.Children[1].Evaluate(m);
                                break;
                            case "-":
                                retour = this.Children[0].Evaluate(m) - this.Children[1].Evaluate(m);
                                break;
                            case "*":
                                retour = this.Children[0].Evaluate(m) * this.Children[1].Evaluate(m);
                                break;
                            case "/":
                                retour = this.Children[0].Evaluate(m) / this.Children[1].Evaluate(m);
                                break;
                            case "%":
                                retour = this.Children[0].Evaluate(m) % this.Children[1].Evaluate(m);
                                break;
                            case "←":
                            case "<-":
                                retour = this.Children[1].Evaluate(m);
                                m.Memorize(this.Children[0].Root, retour);
                                break;
                            case ";":
                                foreach (ASTree child in this.Children)
                                {
                                    retour = child.Evaluate(m);
                                }
                                break;
                            default:
                                Console.Error.WriteLine("error operator : " + this.Root);
                                break;
                        }
                    }
                    break;
                case ASType.UNARYOP:
                    switch (this.Root)
                    {
                        case "-":
                            return -1 * this.Children[0].Evaluate(m);

                        default:
                            Console.Error.WriteLine("unknown unary operator" + this.Root);
                            break;
                    }
                    break;
                default:
                    Console.Error.WriteLine("error type : " + this.Type);
                    break;
            }
            return retour;
        }

        public override string ToString()
        {

            return this.Serialize(new TextExporter());
        }
    
        public string Serialize(IExporter exporter)
        {
             //conversion en notation voulue ( dans notre cas )
            return exporter.Export(this);
        }
     
           

    }


}