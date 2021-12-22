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
                     textAffichage.Text = "❌écran vide❌";
                }
                break;
            case "Y Mode":
                b.Click += ymode_Click;
                break;
            //efface affichage
            case "Cancel":
                textAffichage.Clear();
                break;
            //clear memory
            case "Clear":
                i.Reset();
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

}