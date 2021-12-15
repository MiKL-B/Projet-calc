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
        this.ClientSize = new System.Drawing.Size(800, 200);
        this.Text = "Form1";

        //labelOriginal
        lblOriginal = new Label();
        lblOriginal.Name = "lblOriginal";
        lblOriginal.Text = "Original :";
        lblOriginal.Location = new System.Drawing.Point(20, 20);
        this.Controls.Add(lblOriginal);

        //labelCopie
        lblCopie = new Label();
        lblCopie.Name = "lblCopie";
        lblCopie.Text = "Copie :";
        lblCopie.Location = new System.Drawing.Point(20, 50);
        this.Controls.Add(lblCopie);

        //labelResultat
        lblResultat = new Label();
        lblResultat.Name = "lblResultat";
        lblResultat.Text = "Resultat";
        lblResultat.Location = new System.Drawing.Point(200, 50);
        lblResultat.Size = new System.Drawing.Size(200, 50);
        this.Controls.Add(lblResultat);

        //textbox or input
        input = new TextBox();
        input.Name = "input";
        // input.Text;
        input.Location = new System.Drawing.Point(200, 20);
        input.Size = new System.Drawing.Size(200, 50);
        this.Controls.Add(input);

        //button Recopie
        btnRecopie = new Button();
        btnRecopie.Name = "btnRecopie";
        btnRecopie.Text = "Recopier";
        // btn1.ForeColor = Color.FromArgb(255, 76, 41);
        // btn1.BackColor = Color.FromArgb(8, 32, 50);
        btnRecopie.Location = new System.Drawing.Point(600, 20);
        // btn1.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(btnRecopie);

        //button Delete
        btnDelete = new Button();
        btnDelete.Name = "btnDelete";
        btnDelete.Text = "Effacer";
        btnDelete.Location = new System.Drawing.Point(600, 50);
        // btnDelete.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(btnDelete);

        //button Quit
        btnQuit = new Button();
        btnQuit.Name = "btnQuit";
        btnQuit.Text = "Quitter";
        btnQuit.Location = new System.Drawing.Point(600, 80);
        // btnQuit.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(btnQuit);
    }
    private Label lblOriginal, lblCopie, lblResultat;
    private TextBox input;
    private Button btnRecopie, btnDelete, btnQuit;


    #endregion
}
