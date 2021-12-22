using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Winforms_calc;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    public class ButtonCalc : Button
    {
        public ButtonCalc(string name, int xPos, int yPos)
        {
            this.Name = name;
            this.Text = name;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Size = new System.Drawing.Size(50, 50);

        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 20))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.Gray, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
    private GroupBox gbAffichage = new GroupBox(), gbNumber = new GroupBox();
    private ComboBox comboVariable = new ComboBox();
    private ComboBox comboFunction = new ComboBox();

    private int xPos = 0, yPos = 10;
    private TextBox textAffichage = new TextBox();
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 650);
        this.Text = "Form1";

        string[] mesButtons = new string[28] {"Exit", "RPN", "Lisp", "Y Mode", "Memory", "Clear", "Reset", "Return", ".", "(", ")", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "Affect", "0", ",", "=" };


        for (int i = 0; i < mesButtons.Length; i++)
        {
            this.xPos = this.xPos + 60;
            if (this.xPos == 300)
            {
                this.xPos = 60;
                this.yPos = this.yPos + 60;
            }
            ButtonCalc item = new ButtonCalc(mesButtons[i], this.xPos, this.yPos);

            item.Click += button_Click;
            gbNumber.Controls.Add(item);

        }


        this.comboFunction.SelectedIndexChanged += new System.EventHandler(this.comboFunction_SelectedIndexChanged);
        string[] functions = new string[11] { "sqrt", "pow", "sin", "cos", "tan", "asin", "acos", "atan", "pi", "e", "ln" };

        foreach (var f in functions)
        {
            this.comboFunction.Items.Add(f);
        }



        this.comboVariable.SelectedIndexChanged += new System.EventHandler(this.comboVariable_SelectedIndexChanged);
        this.comboVariable.Items.Clear();
     
        string variables = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        foreach (var c in variables)
        {
            this.comboVariable.Items.Add(Char.ToLower(c));
        }
        foreach (var c in variables)
        {
            this.comboVariable.Items.Add(c);
        }



        gbNumber.Location = new System.Drawing.Point(-50, 220);
        gbNumber.Size = new System.Drawing.Size(450, 450);
        gbNumber.Controls.AddRange(new Control[] { comboVariable, comboFunction });

        gbAffichage.Controls.AddRange(new Control[] { textAffichage });
        gbAffichage.Text = "Affichage";
        gbAffichage.Location = new System.Drawing.Point(0, 20);
        gbAffichage.Size = new System.Drawing.Size(400, 200);
        gbAffichage.BackColor = Color.FromArgb(32, 32, 32);
        gbAffichage.ForeColor = Color.LightGray;

        textAffichage.Location = new System.Drawing.Point(0, 20);
        textAffichage.Multiline = true;
        textAffichage.Size = new System.Drawing.Size(400, 180);
        textAffichage.Font = new Font("Microsoft sans serif", 20);
        textAffichage.BackColor = Color.FromArgb(32, 32, 32);
        textAffichage.ForeColor = Color.GreenYellow;


        comboVariable.Text = "Variables";
        comboVariable.Location = new System.Drawing.Point(310, 11);
        comboFunction.Text = "Fonctions";
        comboFunction.Location = new System.Drawing.Point(310, 51);


        this.Controls.AddRange(new Control[] { gbAffichage, gbNumber });
    }
    #endregion
}