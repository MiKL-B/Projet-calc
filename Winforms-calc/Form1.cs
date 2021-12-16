namespace Winforms_calc;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        this.Init();
    }

    private void Init()
    {

        this.comboVariable.Items.Clear();

        char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        foreach (var c in az)
        {
            this.comboVariable.Items.Add(c);
        }


        string[] functions = new string[11];
        functions[0] = "sqrt";
        functions[1] = "pow";
        functions[2] = "sin";
        functions[3] = "cos";
        functions[4] = "tan";
        functions[5] = "asin";
        functions[6] = "acos";
        functions[7] = "atan";
        functions[8] = "pi";
        functions[9] = "e";
        functions[10] = "ln";
        foreach (var f in functions)
        {
           this.comboFunction.Items.Add(f);
        }

    }

}

