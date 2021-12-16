namespace Winforms_calc;

public partial class Form1 : Form
{
     private string leTexte;
    public Form1()
    {
        InitializeComponent();
        btnRecopier.Click += btnRecopier_Click;
        btnEffacer.Click += btnEffacer_Click;
        btnQuitter.Click += btnQuitter_Click;
        this.input.GotFocus += new EventHandler(txtInput_GotFocus);
        this.leTexte = "Entrer le texte initial";
        this.input.Text = leTexte;
        // this.Height = 300;
        btnSearch.Click += btnChercher_Click;
        this.Init();
        btnAjoute.Click += btnAdd_Click;
        btnAjouteTout.Click += btnAddAll_Click;
        btnSupprime.Click += btnRemove_Click;
        btnSupprimeTout.Click += btnRemoveAll_Click;
        btnBas.Click += btnBas_Click;
   
    }

    private void btnRecopier_Click(object sender, EventArgs e)
    {
        this.lblResultat.Text = this.input.Text;
    }
    private void btnEffacer_Click(object sender, EventArgs e)
    {
        this.input.Text = this.leTexte;
        this.lblResultat.Text = "";
    }
    private void btnQuitter_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Voulez vous vraiment quitter", "Terminer ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            Application.Exit();
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        this.input.Text = "Entrer le texte initial";
    }
    private void txtInput_GotFocus(object sender, EventArgs e)
    {
        this.input.Text = "";
    }
    // private void chkModifier_CheckedChanged(object sender, EventArgs e)
    // {
    //     this.gbxCouleur.Visible = this.chkModifier.Checked;
    //     this.Height = this.chkModifier.Checked ? 1024 : 300;
    // }
    private void rbColor_CheckedChanged(object sender, EventArgs e)
    {
        if (this.rbVert.Checked)
        {
            this.lblColor.BackColor = System.Drawing.Color.Green;
        }
        else if (this.rbRouge.Checked)
        {
            this.lblColor.BackColor = System.Drawing.Color.Red;
        }
        else
        {
            this.lblColor.BackColor = System.Drawing.Color.Blue;
        }

    }
    private void btnChercher_Click(object sender, EventArgs e)
    {
        Int32 nombreOccurences = 0;
        if (this.inputSearch.Text.Length == 0)
        {
            MessageBox.Show("vous n'avez pas renseigné de caractère");
            this.inputSearch.Focus();
        }
        else
        {
            this.inputSearch.Text = this.inputSearch.Text.Substring(0, 1);
            if (this.rbPhrase1.Checked)
            {
                nombreOccurences += rechercheCaractere(this.inputPhrase1.Text, Char.Parse(this.inputSearch.Text));
            }
            if (this.rbPhrase2.Checked)
            {
                nombreOccurences += rechercheCaractere(this.inputPhrase2.Text, Char.Parse(this.inputSearch.Text));
            }
            if (this.rbPhrase3.Checked)
            {
                nombreOccurences += rechercheCaractere(this.inputPhrase3.Text, Char.Parse(this.inputSearch.Text));
            }
            this.inputOccurence.Text = nombreOccurences.ToString();
        }
    }
    private Int32 rechercheCaractere(string zone, Char caractereRecherche)
    {
        Int32 longZone;
        Char caractereElementaire;
        Int32 nbOccurences = 0;
        longZone = zone.Length;

        for (int i = 0; i < longZone; i++)
        {
            caractereElementaire = zone[i];
            if (caractereElementaire == caractereRecherche)
            {
                nbOccurences++;
            }

        }
        return nbOccurences;

    }
    private void Init()
    {
        this.cbxSource.Items.Clear();
        this.cbxSource.Items.Add("France");
        this.cbxSource.Items.Add("Belgique");

    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        this.listCible.Items.Add(this.cbxSource.SelectedItem);
        this.cbxSource.Items.Remove(this.cbxSource.SelectedItem);
        this.cbxSource.Text = null;

        if (this.cbxSource.Items.Count == 0)
        {
            this.btnAjouteTout.Enabled = false;
            this.btnAjoute.Enabled = false;
        }

        if (this.listCible.Items.Count > 0)
        {
            this.btnSupprime.Enabled = true;
            this.btnSupprimeTout.Enabled = true;
        }
    }
    private void btnAddAll_Click(object sender, EventArgs e)
    {
        foreach (var item in cbxSource.Items)
        {
            this.listCible.Items.Add(item);
        }
        this.cbxSource.Items.Clear();
        this.btnAjoute.Enabled = false;
        this.btnAjouteTout.Enabled = false;
        this.btnSupprime.Enabled = true;
        this.btnSupprimeTout.Enabled = true;

    }
    private void btnRemove_Click(object sender, EventArgs e)
    {
        this.cbxSource.Items.Add(this.listCible.SelectedItem);
        this.listCible.Items.Remove(this.listCible.SelectedItem);
        if (this.listCible.Items.Count == 0)
        {
            this.btnSupprime.Enabled = false;
            this.btnSupprimeTout.Enabled = false;
        }
        if (this.cbxSource.Items.Count > 0)
        {
            this.btnAjoute.Enabled = true;
            this.btnAjouteTout.Enabled = true;
        }
    }
    private void btnRemoveAll_Click(object sender, EventArgs e)
    {
        foreach (var item in listCible.Items)
        {
            this.cbxSource.Items.Add(item);
        }
        this.listCible.Items.Clear();
        this.btnSupprime.Enabled = false;
        this.btnSupprimeTout.Enabled = false;
        this.btnAjoute.Enabled = true;
        this.btnAjouteTout.Enabled = true;

    }
    private void btnBas_Click(object sender, EventArgs e)
    {
        Object temp;
        if (this.listCible.SelectedIndex != this.listCible.Items.Count - 1)
        {
            temp = this.listCible.SelectedItem;
            this.listCible.Items[this.listCible.SelectedIndex] = this.listCible.Items[this.listCible.SelectedIndex + 1];
            this.listCible.Items[this.listCible.SelectedIndex + 1] = temp;
            this.listCible.SelectedIndex++;
        }
    }

}

