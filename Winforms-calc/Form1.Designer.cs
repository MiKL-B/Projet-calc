using System.Windows.Forms;
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
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        //button 1
        btn1 = new Button();
        btn1.Name = "btn1";
        btn1.Text = "Recopier";
        btn1.Location = new System.Drawing.Point(600, 20);
        btn1.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(btn1);
        //button 2
        btnDelete = new Button();
        btnDelete.Name = "btn1";
        btnDelete.Text = "Effacer";
        btnDelete.Location = new System.Drawing.Point(600, 120);
        btnDelete.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(btnDelete);
        //button 3
        btnQuit = new Button();
        btnQuit.Name = "btn1";
        btnQuit.Text = "Quitter";
        btnQuit.Location = new System.Drawing.Point(600, 240);
        btnQuit.Size = new System.Drawing.Size(100, 50);
        this.Controls.Add(btnQuit);
    }
    private Button btn1;
    private Button btnDelete;
    private Button btnQuit;

    #endregion
}
