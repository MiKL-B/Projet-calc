using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Text.RegularExpressions;
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
        public ButtonCalc(string name, int xPos, int yPos)
        {
            this.Name = name;
            this.Text = name;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Size = new System.Drawing.Size(50, 50);
        }
    }
    private GroupBox gbAffichage = new GroupBox(), gbNumber = new GroupBox();
    private ComboBox comboVariable = new ComboBox(), comboFunction = new ComboBox();
    private int xPos = 50, yPos = 10;
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 650);
        this.Text = "Form1";

        string[] mesButtons = new string[31] { "(", ")", ";", "Lisp", "RPN", "Memory", "Affect", "Unary", "CE", "C", "Return", "1/x", "x²", "²√x", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "+/-", "0", ",", "=" };

        for (int i = 0; i < mesButtons.Length; i++)
        {
            this.xPos = this.xPos + 50;
            if (this.xPos == 250)
            {
                this.xPos = 50;
                this.yPos = this.yPos + 50;
            }
            gbNumber.Controls.Add(new ButtonCalc(mesButtons[i], this.xPos, this.yPos));
        }

        gbNumber.Location = new System.Drawing.Point(0, 220);
        gbNumber.Size = new System.Drawing.Size(400, 450);
        gbNumber.Controls.AddRange(new Control[] { comboVariable, comboFunction });

        //group box affichage
        gbAffichage.Text = "Affichage";
        gbAffichage.Location = new System.Drawing.Point(0, 20);
        gbAffichage.Size = new System.Drawing.Size(400, 200);
        gbAffichage.BackColor = Color.FromArgb(32, 32, 32);
        gbAffichage.ForeColor = Color.LightGray;

        //COMBOBOX
        comboVariable.Text = "Variables";
        comboVariable.Location = new System.Drawing.Point(250, 0);
        comboFunction.Text = "Fonctions";
        comboFunction.Location = new System.Drawing.Point(250, 40);

        //ADD
        this.Controls.AddRange(new Control[] { gbAffichage, gbNumber });
    }
    #endregion
}
