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

        string[] functions = new string[11]{"sqrt","pow","sin","cos","tan","asin","acos","atan","pi","e","ln"};
        foreach (var f in functions)
        {
           this.comboFunction.Items.Add(f);
        }

    }

}

