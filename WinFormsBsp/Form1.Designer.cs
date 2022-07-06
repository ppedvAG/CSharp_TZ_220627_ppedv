namespace WinFormsBsp
{
    partial class MeinFenster
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
            this.Btn_KlickMich = new System.Windows.Forms.Button();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.Cbx_Haken = new System.Windows.Forms.CheckBox();
            this.Cbb_Auswahl = new System.Windows.Forms.ComboBox();
            this.Lbx_Auswahl = new System.Windows.Forms.ListBox();
            this.Tbx_Input = new System.Windows.Forms.TextBox();
            this.Lbl_TextboxAusgabe = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesDialogfensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            this.Btn_KlickMich.Location = new System.Drawing.Point(12, 53);
            this.Btn_KlickMich.Name = "Btn_KlickMich";
            this.Btn_KlickMich.Size = new System.Drawing.Size(388, 68);
            this.Btn_KlickMich.TabIndex = 0;
            this.Btn_KlickMich.Text = "Klick Mich";
            this.Btn_KlickMich.UseVisualStyleBackColor = true;
            this.Btn_KlickMich.Click += new System.EventHandler(this.Btn_KlickMich_Click);
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Location = new System.Drawing.Point(63, 149);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(195, 32);
            this.Lbl_Output.TabIndex = 1;
            this.Lbl_Output.Text = "Ich bin ein String";
            // 
            // Cbx_Haken
            // 
            this.Cbx_Haken.AutoSize = true;
            this.Cbx_Haken.Location = new System.Drawing.Point(63, 267);
            this.Cbx_Haken.Name = "Cbx_Haken";
            this.Cbx_Haken.Size = new System.Drawing.Size(152, 36);
            this.Cbx_Haken.TabIndex = 2;
            this.Cbx_Haken.Text = "Ist korrekt";
            this.Cbx_Haken.UseVisualStyleBackColor = true;
            // 
            // Cbb_Auswahl
            // 
            this.Cbb_Auswahl.FormattingEnabled = true;
            this.Cbb_Auswahl.Location = new System.Drawing.Point(428, 314);
            this.Cbb_Auswahl.Name = "Cbb_Auswahl";
            this.Cbb_Auswahl.Size = new System.Drawing.Size(242, 40);
            this.Cbb_Auswahl.TabIndex = 3;
            // 
            // Lbx_Auswahl
            // 
            this.Lbx_Auswahl.FormattingEnabled = true;
            this.Lbx_Auswahl.ItemHeight = 32;
            this.Lbx_Auswahl.Items.AddRange(new object[] {
            "Auswahl1",
            "Auswahl2",
            "Auswahl3"});
            this.Lbx_Auswahl.Location = new System.Drawing.Point(49, 379);
            this.Lbx_Auswahl.Name = "Lbx_Auswahl";
            this.Lbx_Auswahl.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lbx_Auswahl.Size = new System.Drawing.Size(240, 260);
            this.Lbx_Auswahl.TabIndex = 4;
            // 
            // Tbx_Input
            // 
            this.Tbx_Input.AcceptsReturn = true;
            this.Tbx_Input.AcceptsTab = true;
            this.Tbx_Input.Location = new System.Drawing.Point(428, 388);
            this.Tbx_Input.Multiline = true;
            this.Tbx_Input.Name = "Tbx_Input";
            this.Tbx_Input.Size = new System.Drawing.Size(419, 106);
            this.Tbx_Input.TabIndex = 5;
            // 
            // Lbl_TextboxAusgabe
            // 
            this.Lbl_TextboxAusgabe.AutoSize = true;
            this.Lbl_TextboxAusgabe.Location = new System.Drawing.Point(428, 537);
            this.Lbl_TextboxAusgabe.Name = "Lbl_TextboxAusgabe";
            this.Lbl_TextboxAusgabe.Size = new System.Drawing.Size(78, 32);
            this.Lbl_TextboxAusgabe.TabIndex = 6;
            this.Lbl_TextboxAusgabe.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(579, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(184, 36);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(579, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 36);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(579, 149);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(184, 36);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(422, 704);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 200);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(88, 113);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(184, 36);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(85, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(184, 36);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(123, 770);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 39);
            this.numericUpDown1.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 42);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesFensterToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(90, 38);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuesFensterToolStripMenuItem
            // 
            this.neuesFensterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesFensterToolStripMenuItem1,
            this.neuesDialogfensterToolStripMenuItem});
            this.neuesFensterToolStripMenuItem.Name = "neuesFensterToolStripMenuItem";
            this.neuesFensterToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.neuesFensterToolStripMenuItem.Text = "Neues Fenster";
            // 
            // neuesFensterToolStripMenuItem1
            // 
            this.neuesFensterToolStripMenuItem1.Name = "neuesFensterToolStripMenuItem1";
            this.neuesFensterToolStripMenuItem1.Size = new System.Drawing.Size(365, 44);
            this.neuesFensterToolStripMenuItem1.Text = "Neues Fenster";
            this.neuesFensterToolStripMenuItem1.Click += new System.EventHandler(this.neuesFensterToolStripMenuItem1_Click);
            // 
            // neuesDialogfensterToolStripMenuItem
            // 
            this.neuesDialogfensterToolStripMenuItem.Name = "neuesDialogfensterToolStripMenuItem";
            this.neuesDialogfensterToolStripMenuItem.Size = new System.Drawing.Size(365, 44);
            this.neuesDialogfensterToolStripMenuItem.Text = "Neues Dialogfenster";
            this.neuesDialogfensterToolStripMenuItem.Click += new System.EventHandler(this.neuesDialogfensterToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // MeinFenster
            // 
            this.AcceptButton = this.Btn_KlickMich;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(974, 929);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Lbl_TextboxAusgabe);
            this.Controls.Add(this.Tbx_Input);
            this.Controls.Add(this.Lbx_Auswahl);
            this.Controls.Add(this.Cbb_Auswahl);
            this.Controls.Add(this.Cbx_Haken);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Btn_KlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MeinFenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mein Fenster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_KlickMich;
        private Label Lbl_Output;
        private CheckBox Cbx_Haken;
        private ComboBox Cbb_Auswahl;
        private ListBox Lbx_Auswahl;
        private TextBox Tbx_Input;
        private Label Lbl_TextboxAusgabe;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private NumericUpDown numericUpDown1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuesFensterToolStripMenuItem;
        private ToolStripMenuItem neuesFensterToolStripMenuItem1;
        private ToolStripMenuItem neuesDialogfensterToolStripMenuItem;
        private ToolStripMenuItem schließenToolStripMenuItem;
    }
}