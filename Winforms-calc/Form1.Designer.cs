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

        public ButtonCalc(string name, string text, int xPos, int yPos, int xSiz, int ySiz)
        {
            this.Name = Name;
            this.Text = text;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Size = new System.Drawing.Size(xSiz, ySiz);

        }
    }
    private GroupBox gbAffichage, gbNumber;
    private ComboBox comboVariable;
    private ComboBox comboFunction;
    private int xPos
    {
        get;
        set;
    }
    private int yPos
    {
        get;
        set;
    }
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 600);
        this.Text = "Form1";

        xPos = 0;
        yPos = 0;

        string[] mesButtons = new string[28] { "Lisp", "RPN", "Memory", "Affect", "Unary" ,"CE", "C", "Return", "1/x", "x²","²√x","/","7","8","9","*","4","5","6","-","1","2","3","+","+/-","0",",","="};
           
        //déclaration
        gbAffichage = new GroupBox();
        gbNumber = new GroupBox();
        comboVariable = new ComboBox();
        comboFunction = new ComboBox();
        for (int i = 0; i < mesButtons.Length; i++)
        {
            this.xPos = this.xPos + 50;

            if (this.xPos == 250)
            {
                this.xPos = 50;
                this.yPos = this.yPos + 50;
            }
        
            gbNumber.Controls.Add(new ButtonCalc(mesButtons[i], mesButtons[i], this.xPos, this.yPos, 50, 50));
        }

        gbNumber.Location = new System.Drawing.Point(0, 220);
        gbNumber.Size = new System.Drawing.Size(400, 380);
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
        this.Controls.Add(gbAffichage);
        this.Controls.Add(gbNumber);
    }
    #endregion
}
