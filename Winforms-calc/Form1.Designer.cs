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
        this.ClientSize = new System.Drawing.Size(1920, 1024);
        this.Text = "Form1";

        //déclaration
        //groupbox
        gbxCouleur = new GroupBox();
        gbComboBox = new GroupBox();
        gbText = new GroupBox();
        gbPhrase = new GroupBox();
        gbMelangeur = new GroupBox();
        gbVitesseMelangeur = new GroupBox();
        gbTempMelangeur = new GroupBox();
        //listbox
        listCible = new ListBox();
        //combo box
        cbxSource = new ComboBox();
        //radio button
        rbRouge = new RadioButton();
        rbVert = new RadioButton();
        rbBleu = new RadioButton();
        rbPhrase1 = new RadioButton();
        rbPhrase2 = new RadioButton();
        rbPhrase3 = new RadioButton();
        rbVitesse1 = new RadioButton();
        rbVitesse2 = new RadioButton();
        rbVitesse3 = new RadioButton();
        rbVitesse4 = new RadioButton();
        rbTemp1 = new RadioButton();
        rbTemp2 = new RadioButton();
        rbTemp3 = new RadioButton();
        //label
        lblOriginal = new Label();
        lblCopie = new Label();
        lblResultat = new Label();
        lblColor = new Label();
        lblPhrase1 = new Label();
        lblPhrase2 = new Label();
        lblPhrase3 = new Label();
        lblSearch = new Label();
        lblOccurence = new Label();
        //checkbox
        chkModifier = new CheckBox();
        //textbox
        input = new TextBox();
        inputPhrase1 = new TextBox();
        inputPhrase2 = new TextBox();
        inputPhrase3 = new TextBox();
        inputSearch = new TextBox();
        inputOccurence = new TextBox();
        //buttons
        btnRecopier = new Button();
        btnEffacer = new Button();
        btnQuitter = new Button();
        btnSearch = new Button();
        btnAjoute = new Button();
        btnAjouteTout = new Button();
        btnSupprime = new Button();
        btnSupprimeTout = new Button();
        btnHaut = new Button();
        btnBas = new Button();
        btnOk = new Button();
        btnRetablir = new Button();
        btnQuitMelangeur = new Button();





        //gbMelangeur
        gbMelangeur.Controls.AddRange(new Control[] { btnOk, btnRetablir, btnQuitMelangeur, gbVitesseMelangeur, gbTempMelangeur });
        gbMelangeur.Text = "Mélangeur";
        gbMelangeur.Visible = true;
        gbMelangeur.Location = new System.Drawing.Point(750, 50);
        gbMelangeur.Size = new System.Drawing.Size(600, 300);

        gbTempMelangeur.Controls.AddRange(new Control[] { rbTemp1, rbTemp2, rbTemp3 });
        gbTempMelangeur.Text = "Température du mélangeur";
        gbTempMelangeur.Location = new System.Drawing.Point(300, 50);
        gbTempMelangeur.Size = new System.Drawing.Size(200, 120);

        rbTemp1.Text = "50";
        rbTemp1.Location = new System.Drawing.Point(20, 20);
        rbTemp2.Text = "80";
        rbTemp2.Location = new System.Drawing.Point(20, 40);
        rbTemp3.Text = "100";
        rbTemp3.Location = new System.Drawing.Point(20, 60);

        gbVitesseMelangeur.Controls.AddRange(new Control[] { rbVitesse1, rbVitesse2, rbVitesse3, rbVitesse4 });
        gbVitesseMelangeur.Text = "Vitesse Mélangeur";
        gbVitesseMelangeur.Visible = true;
        gbVitesseMelangeur.Location = new System.Drawing.Point(50, 50);
        gbVitesseMelangeur.Size = new System.Drawing.Size(200, 120);

        rbVitesse1.Text = "100";
        rbVitesse1.Location = new System.Drawing.Point(20, 20);

        rbVitesse2.Text = "200";
        rbVitesse2.Location = new System.Drawing.Point(20, 40);

        rbVitesse3.Text = "300";
        rbVitesse3.Location = new System.Drawing.Point(20, 60);

        rbVitesse4.Text = "500";
        rbVitesse4.Location = new System.Drawing.Point(20, 80);

        btnOk.Text = "OK";
        btnOk.Location = new System.Drawing.Point(500, 200);
        btnRetablir.Text = "Rétablir";
        btnRetablir.Location = new System.Drawing.Point(500, 230);
        btnQuitMelangeur.Text = "Quitter";
        btnQuitMelangeur.Location = new System.Drawing.Point(500, 260);










        //gbComboBox
        gbComboBox.Controls.AddRange(new Control[] { listCible, cbxSource, btnAjoute, btnAjouteTout, btnSupprime, btnSupprimeTout, btnHaut, btnBas });
        gbComboBox.Text = "Les listes";
        gbComboBox.Visible = true;
        gbComboBox.Location = new System.Drawing.Point(50, 650);
        gbComboBox.Size = new System.Drawing.Size(600, 300);

        cbxSource.Location = new System.Drawing.Point(50, 50);
        listCible.Location = new System.Drawing.Point(300, 50);
        btnAjoute.Text = ">";
        btnAjoute.Location = new System.Drawing.Point(200, 50);

        btnAjouteTout.Text = ">>";
        btnAjouteTout.Location = new System.Drawing.Point(200, 80);

        btnSupprime.Text = "<";
        btnSupprime.Location = new System.Drawing.Point(200, 170);

        btnSupprimeTout.Text = "<<";
        btnSupprimeTout.Location = new System.Drawing.Point(200, 200);

        btnHaut.Text = "↑";
        btnHaut.Location = new System.Drawing.Point(300, 200);

        btnBas.Text = "↓";
        btnBas.Location = new System.Drawing.Point(400, 200);

        //gbxcouleur
        gbxCouleur.Controls.AddRange(new Control[] { rbRouge, rbVert, rbBleu, lblColor });
        gbxCouleur.Text = "Radio buttons";
        gbxCouleur.Visible = false;
        gbxCouleur.Location = new System.Drawing.Point(50, 250);
        gbxCouleur.Size = new System.Drawing.Size(600, 200);

        //rouge 
        rbRouge.Text = "&Rouge";
        rbRouge.Checked = true;
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
        rbBleu.Checked = false;
        rbBleu.Location = new System.Drawing.Point(31, 60);
        rbBleu.Size = new System.Drawing.Size(67, 20);
        this.rbBleu.CheckedChanged += new EventHandler(rbColor_CheckedChanged);

        //gbText
        gbText.Controls.AddRange(new Control[] { lblOriginal, lblCopie, lblResultat, input, btnRecopier, btnEffacer, btnQuitter, chkModifier });
        gbText.Visible = true;
        gbText.Location = new System.Drawing.Point(50, 50);
        gbText.Size = new System.Drawing.Size(600, 200);

        //gbPhrase
        gbPhrase.Controls.AddRange(new Control[] { rbPhrase1, rbPhrase2, rbPhrase3, lblPhrase1, lblPhrase2, lblPhrase3, inputPhrase1, inputPhrase2, inputPhrase3, inputSearch, inputOccurence, lblSearch, lblOccurence, btnSearch });
        gbPhrase.Text = "Rechercher dans";
        gbPhrase.Visible = true;
        gbPhrase.Location = new System.Drawing.Point(50, 450);
        gbPhrase.Size = new System.Drawing.Size(600, 200);

        //rbPhrase1 
        rbPhrase1.Text = "Phrase 1";
        rbPhrase1.Checked = true;
        rbPhrase1.Location = new System.Drawing.Point(30, 100);
        rbPhrase1.Size = new System.Drawing.Size(100, 20);

        //rbPhrase2
        rbPhrase2.Text = "Phrase 2";
        rbPhrase2.Checked = false;
        rbPhrase2.Location = new System.Drawing.Point(30, 130);
        rbPhrase2.Size = new System.Drawing.Size(100, 20);

        //rbPhrase3
        rbPhrase3.Text = "Phrase 3";
        rbPhrase3.Checked = false;
        rbPhrase3.Location = new System.Drawing.Point(30, 160);
        rbPhrase3.Size = new System.Drawing.Size(100, 20);

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
        lblColor.Location = new System.Drawing.Point(300, 50);
        lblColor.Size = new System.Drawing.Size(100, 100);

        //lblPhrase1
        lblPhrase1.Name = "lblPhrase1";
        lblPhrase1.Text = "Phrase 1 ";
        lblPhrase1.Location = new System.Drawing.Point(30, 20);
        lblPhrase1.Size = new System.Drawing.Size(67, 20);

        //lblPhrase2
        lblPhrase2.Name = "lblPhrase2";
        lblPhrase2.Text = "Phrase 2 ";
        lblPhrase2.Location = new System.Drawing.Point(30, 40);
        lblPhrase2.Size = new System.Drawing.Size(67, 20);

        //lblPhrase3
        lblPhrase3.Name = "lblPhrase3";
        lblPhrase3.Text = "Phrase 3 ";
        lblPhrase3.Location = new System.Drawing.Point(30, 60);
        lblPhrase3.Size = new System.Drawing.Size(67, 20);

        //lblSearch
        lblSearch.Name = "lblSearch";
        lblSearch.Text = "Lettre à rechercher";
        lblSearch.Location = new System.Drawing.Point(150, 100);
        lblSearch.Size = new System.Drawing.Size(150, 20);

        //lblOccurence
        lblOccurence.Name = "lblOccurence";
        lblOccurence.Text = "Nombre d'occurences";
        lblOccurence.Location = new System.Drawing.Point(150, 125);
        lblOccurence.Size = new System.Drawing.Size(150, 20);

        //input
        input.Name = "input";
        input.Text = "Entrer le texte initial";
        input.Location = new System.Drawing.Point(200, 50);
        input.Size = new System.Drawing.Size(150, 20);

        //inputPhrase1
        inputPhrase1.Name = "inputPhrase1";
        inputPhrase1.Text = "";
        inputPhrase1.Location = new System.Drawing.Point(150, 25);
        inputPhrase1.Size = new System.Drawing.Size(200, 20);

        //inputPhrase2
        inputPhrase2.Name = "inputPhrase2";
        inputPhrase2.Text = "";
        inputPhrase2.Location = new System.Drawing.Point(150, 50);
        inputPhrase2.Size = new System.Drawing.Size(200, 20);

        //inputPhrase3
        inputPhrase3.Name = "inputPhrase3";
        inputPhrase3.Text = "";
        inputPhrase3.Location = new System.Drawing.Point(150, 75);
        inputPhrase3.Size = new System.Drawing.Size(200, 20);

        //inputSearch
        inputSearch.Name = "inputSearch";
        inputSearch.Text = "";
        inputSearch.Location = new System.Drawing.Point(300, 100);
        inputSearch.Size = new System.Drawing.Size(100, 20);
        //inputOccurence
        inputOccurence.Name = "inputOccurence";
        inputOccurence.Text = "";
        inputOccurence.Location = new System.Drawing.Point(300, 125);
        inputOccurence.Size = new System.Drawing.Size(100, 20);

        //button recopier
        btnRecopier.Name = "btnRecopier";
        btnRecopier.Text = "Recopier";
        btnRecopier.Location = new System.Drawing.Point(500, 50);

        //button effacer
        btnEffacer.Name = "btnEffacer";
        btnEffacer.Text = "Effacer";
        btnEffacer.Location = new System.Drawing.Point(500, 80);

        //button quitter
        btnQuitter.Name = "btnQuitter";
        btnQuitter.Text = "Quitter";
        btnQuitter.Location = new System.Drawing.Point(500, 110);

        //btnSearch
        btnSearch.Name = "btnSearch";
        btnSearch.Text = "Lancer recherche";
        btnSearch.Location = new System.Drawing.Point(425, 100);
        btnSearch.Size = new System.Drawing.Size(130, 20);
        //checkbox
        chkModifier.Name = "chkModifier";
        chkModifier.Text = "Modifier la couleur";
        chkModifier.Location = new System.Drawing.Point(50, 120);
        chkModifier.Size = new System.Drawing.Size(200, 20);
        // this.chkModifier.CheckedChanged += new EventHandler(chkModifier_CheckedChanged);

        //add
        this.Controls.Add(gbxCouleur);
        this.Controls.Add(gbPhrase);
        this.Controls.Add(gbText);
        this.Controls.Add(gbComboBox);
        this.Controls.Add(gbMelangeur);
        // // this.Controls.Add(lblOriginal);
        // // this.Controls.Add(lblCopie);
        // // this.Controls.Add(lblResultat);
        // // this.Controls.Add(lblColor);
        // // this.Controls.Add(chkModifier);
        // // this.Controls.Add(input);
        // // this.Controls.Add(btnRecopier);
        // // this.Controls.Add(btnEffacer);
        // // this.Controls.Add(btnQuitter);
        // // this.Controls.Add(lblPhrase1);
        // // this.Controls.Add(lblPhrase2);
        // // this.Controls.Add(lblPhrase3);
        // // this.Controls.Add(inputPhrase1);
        // // this.Controls.Add(inputPhrase2);
        // // this.Controls.Add(inputPhrase3);
        // // this.Controls.Add(lblSearch);
        // // this.Controls.Add(lblOccurence);
        // // this.Controls.Add(inputSearch);
        // // this.Controls.Add(inputOccurence);
        // // this.Controls.Add(btnSearch);

    }
    private Button btnRecopier, btnEffacer, btnQuitter, btnSearch, btnAjoute, btnAjouteTout, btnSupprime, btnSupprimeTout, btnHaut, btnBas, btnOk, btnRetablir, btnQuitMelangeur;
    private Label lblOriginal, lblCopie, lblResultat, lblColor, lblPhrase1, lblPhrase2, lblPhrase3, lblSearch, lblOccurence;
    private TextBox input, inputPhrase1, inputPhrase2, inputPhrase3, inputSearch, inputOccurence;
    private CheckBox chkModifier;
    private GroupBox gbxCouleur, gbPhrase, gbText, gbComboBox, gbMelangeur, gbVitesseMelangeur, gbTempMelangeur;
    private RadioButton rbRouge, rbVert, rbBleu, rbPhrase1, rbPhrase2, rbPhrase3, rbVitesse1, rbVitesse2, rbVitesse3, rbVitesse4, rbTemp1, rbTemp2, rbTemp3;
    private ListBox listCible;
    private ComboBox cbxSource;
    #endregion
}
