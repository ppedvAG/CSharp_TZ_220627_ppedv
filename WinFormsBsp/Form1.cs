using OOP;

namespace WinFormsBsp
{
    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MeinFenster : Form
    {
        //Bsp-Enum
        enum BspEnum { Item1, Item2, Item3 }

        //Konstruktor für das Form (Fenster)
        public MeinFenster()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Zuweisung eines weiteren EventHandlers zu einem Event
            Btn_KlickMich.Click += Btn_KlickMich_Click_02;

            for (int i = 0; i < Enum.GetValues(typeof(BspEnum)).Length; i++)
            {
                //Befüllung der ComboBox mit Enum-Elementen
                Cbb_Auswahl.Items.Add((BspEnum)i);
            }

            //Bsp-Verwendung eines Klassenobjekts (OOP-Namespace wurde über die Projekt-Dependencies hinzugefügt)
            Mensch mensch = new OOP.Mensch("Anna", "Nass", "Spagetti", new DateTime());
            Lbl_TextboxAusgabe.Text = mensch.ToString();
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'OK# reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Neuzuweisung einer Property eines Buttons
            this.Btn_KlickMich.Text = "Button wurde geklickt";

            //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.DarkOrange;

            //Prüfung, ob die Checkbox abgehakt wurde
            if (Cbx_Haken.Checked)
                Lbl_Output.Text = "HALLO";

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //Übertrag des Elements in den Fenstertitel
                this.Text = ((BspEnum)Cbb_Auswahl.SelectedItem).ToString();

            //Prüfung, ob in der Listbox mindestens ein Element ausgewählt wurde
            if (Lbx_Auswahl.SelectedItems.Count > 0)
                Lbl_Output.Text = Lbx_Auswahl.SelectedItems[0].ToString();

            string input = Tbx_Input.Text;
            Lbl_TextboxAusgabe.Text = input;
        }

        private void Btn_KlickMich_Click_02(object sender, EventArgs e)
        {
            //Verschieben des Elements in der sender-Variablen um 100 Pixel nach rechts
            (sender as Button).Left += 100;
        }

        private void neuesFensterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            MeinFenster neuesFenster = new MeinFenster();
            //Öffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void neuesDialogfensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            MeinFenster neuesFenster = new MeinFenster();
            //Öffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und Überprüfung des DialogResults
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_TextboxAusgabe.Text = "OK";
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Prüfung des geklickten Buttons
            if (MessageBox.Show("Möchtest du das Fenster wirklich schließen?", "Fenster schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Setzen des Dialogresults (Rückgabewert, wenn Fenster über ShowDialog geöffnet wurde)
                this.DialogResult = DialogResult.OK;
                //Schließend des Fensters
                this.Close(); 
            }

            //Schließend der Applikation (alle Fenster)
            //Application.Exit();
        }
    }
}