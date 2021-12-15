namespace Winforms_calc;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btn1.Click += btnRecopier_Click;
        btnDelete.Click += btnEffacer_Click;
        btnQuit.Click += btnQuitter_Click;
    }

    private void btnRecopier_Click(object sender, EventArgs e)
    {
        btn1.Text = this.Text;
    }
    private void btnEffacer_Click(object sender, EventArgs e)
    {
        btnDelete.Text = "";
    }
    private void btnQuitter_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
}
