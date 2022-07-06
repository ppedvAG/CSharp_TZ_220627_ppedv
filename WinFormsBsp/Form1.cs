using OOP;

namespace WinFormsBsp
{
    public partial class MeinFenster : Form
    {
        enum BspEnum { Item1, Item2, Item3}

        public MeinFenster()
        {
            InitializeComponent();

            for (int i = 0; i < Enum.GetValues(typeof(BspEnum)).Length; i++)
            {
                Cbb_Auswahl.Items.Add((BspEnum)i);
            }

            Mensch mensch = new OOP.Mensch("Anna", "Nass", "Spagetti", new DateTime());

            Lbl_TextboxAusgabe.Text = mensch.ToString();
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            this.Btn_KlickMich.Text = "Button wurde geklickt";

            this.BackColor = Color.DarkOrange;

            (sender as Button).Left += 10;

            if(Cbx_Haken.Checked)
                Lbl_Output.Text = "HALLO";

            if(Cbb_Auswahl.SelectedItem != null)
                this.Text = ((BspEnum)Cbb_Auswahl.SelectedItem).ToString();

            if (Lbx_Auswahl.SelectedItems.Count > 0)
                Lbl_Output.Text = Lbx_Auswahl.SelectedItems[0].ToString();

            string input = Tbx_Input.Text;
            Lbl_TextboxAusgabe.Text = input;

            this.DialogResult = DialogResult.OK;
        }

        private void neuesFensterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MeinFenster neuesFenster = new MeinFenster();
            neuesFenster.Show();
        }

        private void neuesDialogfensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeinFenster neuesFenster = new MeinFenster();
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_TextboxAusgabe.Text = "OK";
        }

        private void schlieﬂenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Mˆchtest du das Fenster wirklich schlieﬂen?", "Fenster schlieﬂen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            //Application.Exit();
        }
    }
}