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
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Text = "Form1";

        //déclaration
        gbxCouleur = new GroupBox();
        rbRouge = new RadioButton();
        rbVert = new RadioButton();
        rbBleu = new RadioButton();
        lblOriginal = new Label();
        lblCopie = new Label();
        lblResultat = new Label();
        lblColor = new Label();
        lblPhrase1 = new Label();
        lblPhrase2 = new Label();
        lblPhrase3 = new Label();
        chkModifier = new CheckBox();
        input = new TextBox();
        inputPhrase1 = new TextBox();
        inputPhrase2 = new TextBox();
        inputPhrase3 = new TextBox();
        btnRecopier = new Button();
        btnEffacer = new Button();
        btnQuitter = new Button();

        //gbxcouleur
        gbxCouleur.Controls.AddRange(new Control[] { rbRouge, rbVert, rbBleu });
        gbxCouleur.Text = "Radio buttons";
        gbxCouleur.Visible = false;
        gbxCouleur.Location = new System.Drawing.Point(50, 200);
        gbxCouleur.Size = new System.Drawing.Size(200, 100);

        //rouge 
        rbRouge.Text = "&Rouge";
        rbVert.Checked = true;
        rbRouge.Location = new System.Drawing.Point(31, 20);
        rbRouge.Size = new System.Drawing.Size(67, 20);
        this.rbRouge.CheckedChanged += new EventHandler(rbColor_CheckedChanged);

        //vert
        rbVert.Text = "&Vert";
        rbVert.Checked = false;
        rbVert.Location = new System.Drawing.Point(31, 40);
        rbVert.Size = new System.Drawing.Size(67, 20);
        this.rbVert.CheckedChanged += new EventHandler(rbColor_CheckedChanged);

        //bleu
        rbBleu.Text = "&Bleu";
        rbVert.Checked = false;
        rbBleu.Location = new System.Drawing.Point(31, 60);
        rbBleu.Size = new System.Drawing.Size(67, 20);
        this.rbBleu.CheckedChanged += new EventHandler(rbColor_CheckedChanged);

        //lblOriginal
        lblOriginal.Name = "lblOriginal";
        lblOriginal.Text = "Original : ";
        lblOriginal.Location = new System.Drawing.Point(50, 50);

        //lblCopie
        lblCopie.Name = "lblCopie";
        lblCopie.Text = "Copie : ";
        lblCopie.Location = new System.Drawing.Point(50, 80);

        //lblResultat
        lblResultat.Name = "lblResultat";
        lblResultat.Text = "Resultat";
        lblResultat.Location = new System.Drawing.Point(200, 80);

        //lblColor
        lblColor.Name = "lblColor";
        lblColor.Text = "La couleur choisie";
        lblColor.BackColor = Color.Red;
        lblColor.AutoSize = false;
        lblColor.Location = new System.Drawing.Point(300, 200);
        lblColor.Size = new System.Drawing.Size(200, 100);

        //lblPhrase1
        lblPhrase1.Name = "lblPhrase1";
        lblPhrase1.Text = "Phrase 1 ";
        lblPhrase1.Location = new System.Drawing.Point(50, 310);
        lblPhrase1.Size = new System.Drawing.Size(67, 20);
        //lblPhrase2
        lblPhrase2.Name = "lblPhrase2";
        lblPhrase2.Text = "Phrase 2 ";
        lblPhrase2.Location = new System.Drawing.Point(50, 330);
        lblPhrase2.Size = new System.Drawing.Size(67, 20);
        //lblPhrase3
        lblPhrase3.Name = "lblPhrase3";
        lblPhrase3.Text = "Phrase 3 ";
        lblPhrase3.Location = new System.Drawing.Point(50, 350);
        lblPhrase3.Size = new System.Drawing.Size(67, 20);

        //input
        input.Name = "input";
        input.Text = "Entrer le texte initial";
        input.Location = new System.Drawing.Point(200, 50);
        input.Size = new System.Drawing.Size(150, 20);
        //inputPhrase1
        inputPhrase1.Name = "inputPhrase1";
        inputPhrase1.Text = "";
        inputPhrase1.Location = new System.Drawing.Point(300, 310);
        inputPhrase1.Size = new System.Drawing.Size(200, 20);
        //inputPhrase2
        inputPhrase2.Name = "inputPhrase2";
        inputPhrase2.Text = "";
        inputPhrase2.Location = new System.Drawing.Point(300, 330);
        inputPhrase2.Size = new System.Drawing.Size(200, 20);
        //inputPhrase3
        inputPhrase3.Name = "inputPhrase3";
        inputPhrase3.Text = "";
        inputPhrase3.Location = new System.Drawing.Point(300, 350);
        inputPhrase3.Size = new System.Drawing.Size(200, 20);
        //button recopier
        btnRecopier.Name = "btnRecopier";
        btnRecopier.Text = "Recopier";
        btnRecopier.Location = new System.Drawing.Point(600, 50);

        //button effacer
        btnEffacer.Name = "btnEffacer";
        btnEffacer.Text = "Effacer";
        btnEffacer.Location = new System.Drawing.Point(600, 80);

        //button quitter
        btnQuitter.Name = "btnQuitter";
        btnQuitter.Text = "Quitter";
        btnQuitter.Location = new System.Drawing.Point(600, 110);

        //checkbox
        chkModifier.Name = "chkModifier";
        chkModifier.Text = "Modifier la couleur";
        chkModifier.Location = new System.Drawing.Point(50, 120);
        chkModifier.Size = new System.Drawing.Size(200, 20);
        this.chkModifier.CheckedChanged += new EventHandler(chkModifier_CheckedChanged);

        //add
        this.Controls.Add(gbxCouleur);
        this.Controls.Add(lblOriginal);
        this.Controls.Add(lblCopie);
        this.Controls.Add(lblResultat);
        this.Controls.Add(lblColor);
        this.Controls.Add(chkModifier);
        this.Controls.Add(input);
        this.Controls.Add(btnRecopier);
        this.Controls.Add(btnEffacer);
        this.Controls.Add(btnQuitter);
        this.Controls.Add(lblPhrase1);
        this.Controls.Add(lblPhrase2);
        this.Controls.Add(lblPhrase3);
        this.Controls.Add(inputPhrase1);
        this.Controls.Add(inputPhrase2);
        this.Controls.Add(inputPhrase3);
    }
    private Button btnRecopier, btnEffacer, btnQuitter;
    private Label lblOriginal, lblCopie, lblResultat, lblColor, lblPhrase1, lblPhrase2, lblPhrase3;
    private TextBox input, inputPhrase1, inputPhrase2, inputPhrase3;
    private CheckBox chkModifier;
    private GroupBox gbxCouleur;
    private RadioButton rbRouge, rbVert, rbBleu;
    #endregion
}
