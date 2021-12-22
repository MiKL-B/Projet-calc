namespace Winforms_calc;

public partial class Form1 : Form
{
    public Index i = new Index();
    public Form1()
    {
        InitializeComponent();
        this.Init();

    }

    private void Init()
    {
        // this.comboVariable.Items.Clear();

        // char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
        // foreach (var c in az)
        // {
        //     this.comboVariable.Items.Add(c);
        // }
    }

    private void button_Click(object sender, EventArgs e)
    {
        ButtonCalc b = sender as ButtonCalc;
        // Index i = sender as Index;
        string textglobal = textAffichage.Text;
        switch (b.Text)
        {
            //efface un caractere
            case "Return":
                try
                {
                    textAffichage.Text = textAffichage.Text.Remove(textAffichage.Text.Length - 1);
                }
                catch
                {
                    textAffichage.Text = "[écran vide]";
                }
                break;

            case "Y Mode":
                b.Click += ymode_Click;
                b.Text = "N Mode";
                break;
            case "N Mode":
                b.Click += nmode_Click;
                b.Text = "Y Mode";
                break;
            //efface affichage
            case "Clear":
                textAffichage.Clear();

                break;
            case "Exit":
            Application.Exit();
            break;

            //Reset memory
            case "Reset":
                i.Reset();
                textAffichage.Text = "[mémoire reset]";
                break;

            case "Memory":
                List<string> m = i.PrintMemory();
                string retour = "";
                foreach (var item in m)
                {
                    retour += item + "\n";
                }
                MessageBox.Show(retour);
                break;

            case "RPN":
                string textRPN = textAffichage.Text;
                if (textRPN.Length == 0)
                {
                    textRPN = "error";
                }
                if (Parser.Parse(textRPN))
                {
                    textAffichage.Text = Parser.LastExpression.Serialize(new ReversePolishNotationExporter());
                    b.Text = "TextRPN";
                }
                else
                {
                    textAffichage.Text = textRPN;
                }
                break;

            case "TextRPN":
                textAffichage.Text = Parser.LastExpression.Serialize(new SwitchExporter());
                b.Text = "RPN";
                break;
                
            case "Lisp":
                string text = textAffichage.Text;

                if (text.Length == 0)
                {
                    text = "error";
                }
                if (Parser.Parse(text))
                {
                    textAffichage.Text = Parser.LastExpression.Serialize(new LispExporter());
                    b.Text = "Text";
                }
                else
                {
                    textAffichage.Text = "error lisp";
                }

                break;

            case "Text":
                textAffichage.Text = Parser.LastExpression.Serialize(new SwitchExporter());
                b.Text = "Lisp";

                break;

            case "Affect":
                textAffichage.Text += "←";
                break;

            case "=":
                (bool success, double val, string error) resultat = i.Calculate(textAffichage.Text);
                if (resultat.success)
                {
                    textAffichage.Text = resultat.val.ToString();
                }
                else
                {
                    textAffichage.Text = resultat.error;
                }
                break;

            default:
                textAffichage.Text += b.Text;
                break;
        }
    }

    private void comboFunction_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboFunction.SelectedIndex != -1)
        {
            textAffichage.Text = comboFunction.SelectedItem.ToString();
        }

    }
    private void comboVariable_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboVariable.SelectedIndex != -1)
        {
            textAffichage.Text += comboVariable.SelectedItem.ToString();
        }

    }
    private void ymode_Click(object sender, EventArgs e)
    {
        textAffichage.Font = new Font("Microsoft sans serif", 100);

    }
    private void nmode_Click(object sender, EventArgs e)
    {
        textAffichage.Font = new Font("Microsoft sans serif", 20);
    }

}