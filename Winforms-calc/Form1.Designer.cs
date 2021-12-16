using System.Windows.Forms;
using System.Drawing;
namespace Winforms_calc;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>

    public class ButtonCalc : Button
    {


        public ButtonCalc(string name, string text, int xPos, int yPos, int xSiz, int ySiz)
        {
            this.Name = Name;
            this.Text = text;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Size = new System.Drawing.Size(xSiz, ySiz);
        }
    }
    private GroupBox gbAffichage, gbNumber;
    // private ComboBox comboVariable;
    // private ComboBox comboFunction;
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 600);
        this.Text = "Form1";


        ButtonCalc Modulo = new ButtonCalc("Unary", "%", 0, 80, 100, 50);
        ButtonCalc CE = new ButtonCalc("CE", "CE", 100, 80, 100, 50);
        ButtonCalc C = new ButtonCalc("C", "CE", 200, 80, 100, 50);
        ButtonCalc Return = new ButtonCalc("Return", "Return", 300, 80, 100, 50);
        ButtonCalc FunctionInverse = new ButtonCalc("FunctionInverse", "1/x", 0, 130, 100, 50);
        ButtonCalc Square = new ButtonCalc("Square", "x²", 100, 130, 100, 50);
        ButtonCalc Sqrt = new ButtonCalc("Sqrt", "²√x", 200, 130, 100, 50);
        ButtonCalc Division = new ButtonCalc("Division", "/", 300, 130, 100, 50);
        ButtonCalc Seven = new ButtonCalc("Seven", "7", 0, 180, 100, 50);
        ButtonCalc Eight = new ButtonCalc("Eight", "8", 100, 180, 100, 50);
        ButtonCalc Nine = new ButtonCalc("Nine", "9", 200, 180, 100, 50);
        ButtonCalc Multiply = new ButtonCalc("Multiply", "*", 300, 180, 100, 50);
        ButtonCalc Four = new ButtonCalc("Four", "4", 0, 230, 100, 50);
        ButtonCalc Five = new ButtonCalc("Five", "5", 100, 230, 100, 50);
        ButtonCalc Six = new ButtonCalc("Six", "6", 200, 230, 100, 50);
        ButtonCalc Minus = new ButtonCalc("Minus", "-", 300, 230, 100, 50);
        ButtonCalc One = new ButtonCalc("One", "1", 0, 280, 100, 50);
        ButtonCalc Two = new ButtonCalc("Two", "2", 100, 280, 100, 50);
        ButtonCalc Three = new ButtonCalc("Three", "3", 200, 280, 100, 50);
        ButtonCalc Plus = new ButtonCalc("Plus", "+", 300, 280, 100, 50);
        ButtonCalc Unary = new ButtonCalc("Unary", "+/-", 0, 330, 100, 50);
        ButtonCalc Zero = new ButtonCalc("Zero", "0", 100, 330, 100, 50);
        ButtonCalc Comma = new ButtonCalc("Comma", ",", 200, 330, 100, 50);
        ButtonCalc Equal = new ButtonCalc("Equal", "=", 300, 330, 100, 50);


        Button[] mesButtons = new Button[24];
        mesButtons[0] = Modulo;
        mesButtons[1] = CE;
        mesButtons[2] = C;
        mesButtons[3] = Return;
        mesButtons[4] = FunctionInverse;
        mesButtons[5] = Square;
        mesButtons[6] = Sqrt;
        mesButtons[7] = Division;
        mesButtons[8] = Seven;
        mesButtons[9] = Eight;
        mesButtons[10] = Nine;
        mesButtons[11] = Multiply;
        mesButtons[12] = Four;
        mesButtons[13] = Five;
        mesButtons[14] = Six;
        mesButtons[15] = Minus;
        mesButtons[16] = One;
        mesButtons[17] = Two;
        mesButtons[18] = Three;
        mesButtons[19] = Plus;
        mesButtons[20] = Unary;
        mesButtons[21] = Zero;
        mesButtons[22] = Comma;
        mesButtons[23] = Equal;


        //
        //déclaration
        //
        gbAffichage = new GroupBox();
        gbNumber = new GroupBox();
        foreach (var item in mesButtons)
        {
            gbNumber.Controls.Add(item);
        }
        gbNumber.Location = new System.Drawing.Point(0, 220);
        gbNumber.Size = new System.Drawing.Size(400, 380);
        // gbNumber.BackColor = Color.FromArgb(32, 32, 32);

        // comboVariable = new ComboBox();
        // comboFunction = new ComboBox();
        // buttonLisp = new Button();
        // buttonRPN = new Button();
        // buttonMemory = new Button();
        // buttonAffect = new Button();
        //
        //GROUP BOX//
        //

        //group box affichage
        // gbAffichage.Controls.AddRange(new Control[] { });
        // gbAffichage.Text = "Affichage";
        // gbAffichage.Location = new System.Drawing.Point(0, 20);
        // gbAffichage.Size = new System.Drawing.Size(400, 200);
        // gbAffichage.BackColor = Color.FromArgb(32, 32, 32);
        // gbAffichage.ForeColor = Color.LightGray;


        //
        //COMBOBOX
        //
        // comboVariable.Text = "Variables";
        // comboVariable.Location = new System.Drawing.Point(0, 10);
        // comboVariable.Size = new System.Drawing.Size(100, 50);
        // comboFunction.Text = "Fonctions";
        // comboFunction.Location = new System.Drawing.Point(0, 40);
        // comboFunction.Size = new System.Drawing.Size(100, 50);
        // //
        // //BUTTONS
        // //





        // //button lisp
        // buttonLisp.Text = "LISP";
        // buttonLisp.Location = new System.Drawing.Point(130, 10);
        // buttonLisp.Size = new System.Drawing.Size(50, 25);
        // buttonLisp.BackColor = Color.LightGray;

        // //button RPN
        // buttonRPN.Text = "RPN";
        // buttonRPN.Location = new System.Drawing.Point(180, 10);
        // buttonRPN.Size = new System.Drawing.Size(50, 25);
        // buttonRPN.BackColor = Color.LightGray;

        // //button affect
        // buttonAffect.Text = "←";
        // buttonAffect.Location = new System.Drawing.Point(230, 10);
        // buttonAffect.Size = new System.Drawing.Size(50, 25);
        // buttonAffect.BackColor = Color.LightGray;

        // //button memory
        // buttonMemory.Text = "Memory";
        // buttonMemory.Location = new System.Drawing.Point(280, 10);
        // buttonMemory.Size = new System.Drawing.Size(75, 25);
        // buttonMemory.BackColor = Color.LightGray;



        //add
        this.Controls.Add(gbAffichage);
        this.Controls.Add(gbNumber);

    }



    #endregion
}
