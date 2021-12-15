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

        // //labelOriginal
        // lblOriginal = new Label();
        // lblOriginal.Name = "lblOriginal";
        // lblOriginal.Text = "Original :";
        // lblOriginal.Location = new System.Drawing.Point(20, 20);
        // this.Controls.Add(lblOriginal);

        // //labelCopie
        // lblCopie = new Label();
        // lblCopie.Name = "lblCopie";
        // lblCopie.Text = "Copie :";
        // lblCopie.Location = new System.Drawing.Point(20, 50);
        // this.Controls.Add(lblCopie);

        // //labelResultat
        // lblResultat = new Label();
        // lblResultat.Name = "lblResultat";
        // lblResultat.Text = "Resultat";
        // lblResultat.Location = new System.Drawing.Point(200, 50);
        // lblResultat.Size = new System.Drawing.Size(200, 50);
        // this.Controls.Add(lblResultat);

        // //label coloré
        // lblColor = new Label();
        // lblColor.Name = "lblColor";
        // lblColor.Text = "La couleur choisie";
        // lblColor.BackColor = Color.Red;
        // lblColor.AutoSize = false;
        // lblColor.Location = new System.Drawing.Point(20, 70);
        // lblColor.Size = new System.Drawing.Size(200, 50);
        // this.Controls.Add(lblColor);

        // //textbox or input
        // input = new TextBox();
        // input.Name = "input";
        // // input.Text;
        // input.Location = new System.Drawing.Point(200, 20);
        // input.Size = new System.Drawing.Size(200, 50);
        // this.Controls.Add(input);

        // //button Recopie
        // btnRecopie = new Button();
        // btnRecopie.Name = "btnRecopie";
        // btnRecopie.Text = "Recopier";
        // // btn1.ForeColor = Color.FromArgb(255, 76, 41);
        // // btn1.BackColor = Color.FromArgb(8, 32, 50);
        // btnRecopie.Location = new System.Drawing.Point(600, 20);
        // // btn1.Size = new System.Drawing.Size(100, 50);
        // this.Controls.Add(btnRecopie);

        // //button Delete
        // btnDelete = new Button();
        // btnDelete.Name = "btnDelete";
        // btnDelete.Text = "Effacer";
        // btnDelete.Location = new System.Drawing.Point(600, 50);
        // // btnDelete.Size = new System.Drawing.Size(100, 50);
        // this.Controls.Add(btnDelete);

        // //button Quit
        // btnQuit = new Button();
        // btnQuit.Name = "btnQuit";
        // btnQuit.Text = "Quitter";
        // btnQuit.Location = new System.Drawing.Point(600, 80);
        // // btnQuit.Size = new System.Drawing.Size(100, 50);
        // this.Controls.Add(btnQuit);



        // //radio button rouge
        // rbRouge = new RadioButton();
        // rbRouge.Name = "rbRouge";
        // rbRouge.Text = "&Rouge";
        // rbRouge.Checked = true;
        // this.Controls.Add(rbRouge);



        // //radio button bleu
        // rbBleu = new RadioButton();
        // rbBleu.Name = "rbBleu";
        // rbBleu.Text = "&Bleu";
        // rbBleu.Checked = false;
        // this.Controls.Add(rbBleu);


        // //groupbox
        // gbxCouleur = new GroupBox();
        // gbxCouleur.Name = "gbxCouleur";
        // gbxCouleur.Text = "Couleur";
        // gbxCouleur.Visible = false;
        // gbxCouleur.Controls.Add(rbVert);
        // gbxCouleur.Location = new System.Drawing.Point(100, 200);
        // gbxCouleur.Size = new System.Drawing.Size(300, 100);
        // this.Controls.Add(gbxCouleur);




        // //checkbox
        // chkModifier = new CheckBox();
        // chkModifier.Name = "chkModifier";
        // chkModifier.Text = "Modifier la couleur";
        // chkModifier.Location = new System.Drawing.Point(200, 100);
        // chkModifier.Size = new System.Drawing.Size(100, 50);
        // this.chkModifier.CheckedChanged += new EventHandler(chkModifier_CheckedChanged);
        // this.Controls.Add(chkModifier);

        //déclaration des boutons etc

        gbxCouleur = new GroupBox();
        rbRouge = new RadioButton();
        rbVert = new RadioButton();
        rbBleu = new RadioButton();
        lblOriginal = new Label();
        lblCopie = new Label();
        lblResultat = new Label();
        lblColor = new Label();
        chkModifier = new CheckBox();
        input = new TextBox();
        btnRecopier = new Button();
        btnEffacer = new Button();
        btnQuitter = new Button();

        //gbxcouleur
        gbxCouleur.Controls.Add(rbRouge);
        gbxCouleur.Controls.Add(rbVert);
        gbxCouleur.Controls.Add(rbBleu);
        gbxCouleur.Location = new System.Drawing.Point(50, 400);
        gbxCouleur.Size = new System.Drawing.Size(200, 100);
        gbxCouleur.Text = "Radio buttons";
        //rouge 
        rbRouge.Text = "&Rouge";
        rbVert.Checked = true;
        rbRouge.Location = new System.Drawing.Point(31, 20);
        rbRouge.Size = new System.Drawing.Size(67, 20);
        //vert
        rbVert.Text = "&Vert";
        rbVert.Checked = false;
        rbVert.Location = new System.Drawing.Point(31, 40);
        rbVert.Size = new System.Drawing.Size(67, 20);
        // this.rbVert.CheckedChanged += new EventHandler(rbVert_CheckedChanged);
        //bleu
        rbBleu.Text = "&Bleu";
        rbVert.Checked = false;
        rbBleu.Location = new System.Drawing.Point(31, 60);
        rbBleu.Size = new System.Drawing.Size(67, 20);
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
        lblColor.Location = new System.Drawing.Point(300, 400);
        lblColor.Size = new System.Drawing.Size(200, 100);
        //input
        input.Name = "input";
        input.Text = "Entrer le texte initial";
        input.Location = new System.Drawing.Point(200, 50);
        input.Size = new System.Drawing.Size(150, 20);
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
        chkModifier.Location = new System.Drawing.Point(50, 350);
        chkModifier.Size = new System.Drawing.Size(200, 20);

        //add
        this.Controls.AddRange(new Control[] { gbxCouleur, lblOriginal, lblCopie, lblResultat, lblColor, chkModifier, input, btnRecopier, btnEffacer, btnQuitter });


    }
    private Button btnRecopier, btnEffacer, btnQuitter;
    private Label lblOriginal, lblCopie, lblResultat, lblColor;
    private TextBox input;
    private CheckBox chkModifier;
    private GroupBox gbxCouleur;
    private RadioButton rbRouge, rbVert, rbBleu;
    #endregion
}
