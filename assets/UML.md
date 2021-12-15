# public class ASTree
1. attributs
* public string Root
* public ASType Type
* public List<ASTree> Children
2. constructeurs
* public ASTree(ASType t=ASType.NUMERIC, string r="0", List<ASTree> c=null)
3. méthodes
* public void AddChild(ASTree t)
* public double Evaluate(Dictionary<string, double> m)
* public string Serialize(IExporter exporter)
* public override string ToString()

# public class Calculateur
1. attributs
2. méthodes
# public enum ASType{ NUMERIC, VARIABLE, FUNCTION, BINARYOP, UNARYOP }
# public interface IExporter
1. méthodes
* string Export(ASTree tree);
# public class ReversePolishNotation : IExporter
1. méthodes
* public string Export(ASTree t)
# public class TextExporter : IExporter
1. méthodes
* public string Export(ASTree t)
# public class LispExporter : IExporter
1. méthodes
* public string Export(ASTree t)

# class Parser
1. attributs

* protected string[] tokens;
* protected int pos;
* protected Stack<int> memory;
* protected bool debug { get; set; }
* protected Stack<ASTree> forest;
* protected Stack<int> forestMemory;
* public static ASTree LastExpression;
2. méthodes

* public static bool Parse(string expr, bool debug = false)
* public bool ParseCmds(string expr, bool debug = false)
* protected void d(string s)
* protected string token()
* protected void nextToken()
* protected void memorize()
* protected void recall()
* protected bool eos()
* protected bool script()
* protected bool end_script()
* protected bool affect_expr()
* protected bool affect_operator()
* protected bool end_affect_expr(bool isVar)
* protected bool arith_expr()
* protected bool end_arith_expr(bool isTerm)
* protected bool term()
* protected bool isOperator()
* protected bool end_term(bool isFactor)
* protected bool unaryMinus()
* protected bool end_unary_minus()
* protected bool factor()
* protected bool variable()
* protected bool numeric()
* protected bool function()
* protected bool end_function(bool isArgList)
* protected bool func_name()
* protected bool arg_list()
* protected bool end_arg_list(bool isArg)
* public static void SendMsg(string expr, bool debug = false)

# class Index
1. méthodes
* public static void Main(string[] args)
* public static void DisplayTests(ASTree t, Dictionary<string, double> m,ReversePolishNotationExporter rpn, TextExporter te, LispExporter li)