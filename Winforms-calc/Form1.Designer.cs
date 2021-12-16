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
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 600);
        this.Text = "Form1";
        //
        //déclaration
        //
        gbAffichage = new GroupBox();
        gbNumber = new GroupBox();
        comboVariable = new ComboBox();
        comboFunction = new ComboBox();
        buttonUnary = new Button();
        buttonZero = new Button();
        buttonComma = new Button();
        buttonEqual = new Button();
        buttonOne = new Button();
        buttonTwo = new Button();
        buttonThree = new Button();
        buttonPlus = new Button();
        buttonFour = new Button();
        buttonFive = new Button();
        buttonSix = new Button();
        buttonMinus = new Button();
        buttonSeven = new Button();
        buttonEight = new Button();
        buttonNine = new Button();
        buttonMultiply = new Button();
        buttonFunctionInverse = new Button();
        buttonSquare = new Button();
        buttonSqrt = new Button();
        buttonDivision = new Button();
        buttonModulo = new Button();
        buttonCE = new Button();
        buttonC = new Button();
        buttonReturn = new Button();
        //
        //GROUP BOX//
        //

        //group box affichage
        gbAffichage.Controls.AddRange(new Control[] { });
        gbAffichage.Text = "Affichage";
        gbAffichage.Location = new System.Drawing.Point(0, 20);
        gbAffichage.Size = new System.Drawing.Size(400, 200);
        gbAffichage.BackColor = Color.Gray;

        //group box number
        gbNumber.Controls.Add(buttonUnary);
        gbNumber.Controls.Add(buttonZero);
        gbNumber.Controls.Add(buttonComma);
        gbNumber.Controls.Add(buttonEqual);
        gbNumber.Controls.Add(buttonOne);
        gbNumber.Controls.Add(buttonTwo);
        gbNumber.Controls.Add(buttonThree);
        gbNumber.Controls.Add(buttonPlus);
        gbNumber.Controls.Add(buttonFour);
        gbNumber.Controls.Add(buttonFive);
        gbNumber.Controls.Add(buttonSix);
        gbNumber.Controls.Add(buttonMinus);
        gbNumber.Controls.Add(buttonSeven);
        gbNumber.Controls.Add(buttonEight);
        gbNumber.Controls.Add(buttonNine);
        gbNumber.Controls.Add(buttonMultiply);
        gbNumber.Controls.Add(buttonFunctionInverse);
        gbNumber.Controls.Add(buttonSquare);
        gbNumber.Controls.Add(buttonSqrt);
        gbNumber.Controls.Add(buttonDivision);
        gbNumber.Controls.Add(buttonModulo);
        gbNumber.Controls.Add(buttonCE);
        gbNumber.Controls.Add(buttonC);
        gbNumber.Controls.Add(buttonReturn);
        gbNumber.Controls.Add(comboVariable);
        gbNumber.Controls.Add(comboFunction);
        gbNumber.Location = new System.Drawing.Point(0, 220);
        gbNumber.Size = new System.Drawing.Size(400, 380);
        gbNumber.BackColor = Color.Gray;
        //
        //COMBOBOX
        //
        comboVariable.Text = "Variables";
        comboVariable.Location = new System.Drawing.Point(0, 10);
        comboFunction.Text = "Fonctions";
        comboFunction.Location = new System.Drawing.Point(0, 40);
        //
        //BUTTONS
        //

        //button unary
        buttonUnary.Text = "+/-";
        buttonUnary.Location = new System.Drawing.Point(0, 330);
        buttonUnary.Size = new System.Drawing.Size(100, 50);
        buttonUnary.BackColor = Color.White;

        //button zero
        buttonZero.Text = "0";
        buttonZero.Location = new System.Drawing.Point(100, 330);
        buttonZero.Size = new System.Drawing.Size(100, 50);
        buttonZero.BackColor = Color.White;

        //button comma
        buttonComma.Text = ",";
        buttonComma.Location = new System.Drawing.Point(200, 330);
        buttonComma.Size = new System.Drawing.Size(100, 50);
        buttonComma.BackColor = Color.White;

        //button equal
        buttonEqual.Text = "=";
        buttonEqual.Location = new System.Drawing.Point(300, 330);
        buttonEqual.Size = new System.Drawing.Size(100, 50);
        buttonEqual.BackColor = Color.SkyBlue;

        //button one
        buttonOne.Text = "1";
        buttonOne.Location = new System.Drawing.Point(0, 280);
        buttonOne.Size = new System.Drawing.Size(100, 50);
        buttonOne.BackColor = Color.White;

        //button two
        buttonTwo.Text = "2";
        buttonTwo.Location = new System.Drawing.Point(100, 280);
        buttonTwo.Size = new System.Drawing.Size(100, 50);
        buttonTwo.BackColor = Color.White;

        //button three
        buttonThree.Text = "3";
        buttonThree.Location = new System.Drawing.Point(200, 280);
        buttonThree.Size = new System.Drawing.Size(100, 50);
        buttonThree.BackColor = Color.White;

        //button plus
        buttonPlus.Text = "+";
        buttonPlus.Location = new System.Drawing.Point(300, 280);
        buttonPlus.Size = new System.Drawing.Size(100, 50);
        buttonPlus.BackColor = Color.LightGray;

        //button four
        buttonFour.Text = "4";
        buttonFour.Location = new System.Drawing.Point(0, 230);
        buttonFour.Size = new System.Drawing.Size(100, 50);
        buttonFour.BackColor = Color.White;

        //button five
        buttonFive.Text = "5";
        buttonFive.Location = new System.Drawing.Point(100, 230);
        buttonFive.Size = new System.Drawing.Size(100, 50);
        buttonFive.BackColor = Color.White;

        //button six
        buttonSix.Text = "6";
        buttonSix.Location = new System.Drawing.Point(200, 230);
        buttonSix.Size = new System.Drawing.Size(100, 50);
        buttonSix.BackColor = Color.White;

        //button minus
        buttonMinus.Text = "-";
        buttonMinus.Location = new System.Drawing.Point(300, 230);
        buttonMinus.Size = new System.Drawing.Size(100, 50);
        buttonMinus.BackColor = Color.LightGray;

        //button seven
        buttonSeven.Text = "7";
        buttonSeven.Location = new System.Drawing.Point(0, 180);
        buttonSeven.Size = new System.Drawing.Size(100, 50);
        buttonSeven.BackColor = Color.White;

        //button eight
        buttonEight.Text = "8";
        buttonEight.Location = new System.Drawing.Point(100, 180);
        buttonEight.Size = new System.Drawing.Size(100, 50);
        buttonEight.BackColor = Color.White;

        //button nine
        buttonNine.Text = "9";
        buttonNine.Location = new System.Drawing.Point(200, 180);
        buttonNine.Size = new System.Drawing.Size(100, 50);
        buttonNine.BackColor = Color.White;

        //button multiply
        buttonMultiply.Text = "*";
        buttonMultiply.Location = new System.Drawing.Point(300, 180);
        buttonMultiply.Size = new System.Drawing.Size(100, 50);
        buttonMultiply.BackColor = Color.LightGray;

        //button function inverse
        buttonFunctionInverse.Text = "1/x";
        buttonFunctionInverse.Location = new System.Drawing.Point(0, 130);
        buttonFunctionInverse.Size = new System.Drawing.Size(100, 50);
        buttonFunctionInverse.BackColor = Color.LightGray;

        //button carré
        buttonSquare.Text = "x²";
        buttonSquare.Location = new System.Drawing.Point(100, 130);
        buttonSquare.Size = new System.Drawing.Size(100, 50);
        buttonSquare.BackColor = Color.LightGray;

        //button sqrt
        buttonSqrt.Text = "²√x";
        buttonSqrt.Location = new System.Drawing.Point(200, 130);
        buttonSqrt.Size = new System.Drawing.Size(100, 50);
        buttonSqrt.BackColor = Color.LightGray;

        //button division
        buttonDivision.Text = "/";
        buttonDivision.Location = new System.Drawing.Point(300, 130);
        buttonDivision.Size = new System.Drawing.Size(100, 50);
        buttonDivision.BackColor = Color.LightGray;

        //button modulo
        buttonModulo.Text = "%";
        buttonModulo.Location = new System.Drawing.Point(0, 80);
        buttonModulo.Size = new System.Drawing.Size(100, 50);
        buttonModulo.BackColor = Color.LightGray;

        //button CE
        buttonCE.Text = "CE";
        buttonCE.Location = new System.Drawing.Point(100, 80);
        buttonCE.Size = new System.Drawing.Size(100, 50);
        buttonCE.BackColor = Color.LightGray;

        //button C
        buttonC.Text = "C";
        buttonC.Location = new System.Drawing.Point(200, 80);
        buttonC.Size = new System.Drawing.Size(100, 50);
        buttonC.BackColor = Color.LightGray;

        //button return
        buttonReturn.Text = "Return";
        buttonReturn.Location = new System.Drawing.Point(300, 80);
        buttonReturn.Size = new System.Drawing.Size(100, 50);
        buttonReturn.BackColor = Color.LightGray;



        //add
        this.Controls.Add(gbAffichage);
        this.Controls.Add(gbNumber);

    }
    private GroupBox gbAffichage, gbNumber;
    private ComboBox comboVariable;
    private ComboBox comboFunction;
    private Button buttonUnary;
    private Button buttonZero;
    private Button buttonComma;
    private Button buttonEqual;
    private Button buttonOne;
    private Button buttonTwo;
    private Button buttonThree;
    private Button buttonPlus;
    private Button buttonFour;
    private Button buttonFive;
    private Button buttonSix;
    private Button buttonMinus;
    private Button buttonSeven;
    private Button buttonEight;
    private Button buttonNine;
    private Button buttonMultiply;
    private Button buttonFunctionInverse;
    private Button buttonSquare;
    private Button buttonSqrt;
    private Button buttonDivision;
    private Button buttonModulo;
    private Button buttonCE;
    private Button buttonC;
    private Button buttonReturn;
    #endregion
}
