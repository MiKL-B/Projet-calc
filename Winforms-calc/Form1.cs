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

        string[] functions = new string[11] { "sqrt", "pow", "sin", "cos", "tan", "asin", "acos", "atan", "pi", "e", "ln" };
        foreach (var f in functions)
        {
            this.comboFunction.Items.Add(f);
        }
    }

    private void button_Click(object sender, EventArgs e)
    {
        ButtonCalc b = sender as ButtonCalc;
        Index i = sender as Index;
        switch (b.Text)
        {
            case "Return":
                textAffichage.Text = textAffichage.Text.Remove(textAffichage.Text.Length - 1);
                break;
            case "Y Mode":
                b.Click += ymode_Click;
                break;
            case "C" or "CE":
                textAffichage.Clear();
                break;
            case "Memory":
         
                break;
            default:
                textAffichage.Text += b.Text;
                break;
        }
    }
    private void ymode_Click(object sender, EventArgs e)
    {
        textAffichage.Font = new Font("Microsoft sans serif", 100);
    }

}