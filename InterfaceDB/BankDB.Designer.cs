
namespace InterfaceDB
{
    partial class BankDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpname = new Button();
            btnStorting = new Button();
            txtBedrag = new TextBox();
            lblSaldo = new Label();
            lblNaam = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNieuweRekening = new Button();
            txtAN = new TextBox();
            txtVN = new TextBox();
            label1 = new Label();
            label5 = new Label();
            btnNieuweKlant = new Button();
            lstKlanten = new ListBox();
            lstRekeningen = new ListBox();
            label6 = new Label();
            txtRekening = new TextBox();
            lstBanken = new ListBox();
            btnNieuweBank = new Button();
            label7 = new Label();
            txtBank = new TextBox();
            SuspendLayout();
            // 
            // btnOpname
            // 
            btnOpname.Location = new Point(1052, 303);
            btnOpname.Margin = new Padding(4, 3, 4, 3);
            btnOpname.Name = "btnOpname";
            btnOpname.Size = new Size(88, 27);
            btnOpname.TabIndex = 23;
            btnOpname.Text = "Opname";
            btnOpname.UseVisualStyleBackColor = true;
            // 
            // btnStorting
            // 
            btnStorting.Location = new Point(859, 303);
            btnStorting.Margin = new Padding(4, 3, 4, 3);
            btnStorting.Name = "btnStorting";
            btnStorting.Size = new Size(88, 27);
            btnStorting.TabIndex = 22;
            btnStorting.Text = "Storting";
            btnStorting.UseVisualStyleBackColor = true;
            // 
            // txtBedrag
            // 
            txtBedrag.Location = new Point(1008, 243);
            txtBedrag.Margin = new Padding(4, 3, 4, 3);
            txtBedrag.Name = "txtBedrag";
            txtBedrag.Size = new Size(116, 23);
            txtBedrag.TabIndex = 21;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(1004, 211);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 15);
            lblSaldo.TabIndex = 20;
            // 
            // lblNaam
            // 
            lblNaam.AutoSize = true;
            lblNaam.Location = new Point(1004, 172);
            lblNaam.Margin = new Padding(4, 0, 4, 0);
            lblNaam.Name = "lblNaam";
            lblNaam.Size = new Size(0, 15);
            lblNaam.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(855, 253);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 18;
            label4.Text = "Bedrag";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(855, 211);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 17;
            label3.Text = "Saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(855, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Naam";
            // 
            // btnNieuweRekening
            // 
            btnNieuweRekening.Location = new Point(593, 127);
            btnNieuweRekening.Margin = new Padding(4, 3, 4, 3);
            btnNieuweRekening.Name = "btnNieuweRekening";
            btnNieuweRekening.Size = new Size(216, 27);
            btnNieuweRekening.TabIndex = 15;
            btnNieuweRekening.Text = "nieuwe rekening aanmaken";
            btnNieuweRekening.UseVisualStyleBackColor = true;
            // 
            // txtAN
            // 
            txtAN.Location = new Point(426, 84);
            txtAN.Margin = new Padding(4, 3, 4, 3);
            txtAN.Name = "txtAN";
            txtAN.Size = new Size(116, 23);
            txtAN.TabIndex = 14;
            // 
            // txtVN
            // 
            txtVN.Location = new Point(426, 47);
            txtVN.Margin = new Padding(4, 3, 4, 3);
            txtVN.Name = "txtVN";
            txtVN.Size = new Size(116, 23);
            txtVN.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "Voornaam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 88);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 24;
            label5.Text = "Familienaam";
            // 
            // btnNieuweKlant
            // 
            btnNieuweKlant.Location = new Point(346, 127);
            btnNieuweKlant.Margin = new Padding(4, 3, 4, 3);
            btnNieuweKlant.Name = "btnNieuweKlant";
            btnNieuweKlant.Size = new Size(196, 27);
            btnNieuweKlant.TabIndex = 25;
            btnNieuweKlant.Text = "nieuwe klant toevoegen";
            btnNieuweKlant.UseVisualStyleBackColor = true;
            // 
            // lstKlanten
            // 
            lstKlanten.FormattingEnabled = true;
            lstKlanten.ItemHeight = 15;
            lstKlanten.Location = new Point(346, 172);
            lstKlanten.Margin = new Padding(4, 3, 4, 3);
            lstKlanten.Name = "lstKlanten";
            lstKlanten.Size = new Size(195, 229);
            lstKlanten.TabIndex = 26;
            // 
            // lstRekeningen
            // 
            lstRekeningen.FormattingEnabled = true;
            lstRekeningen.ItemHeight = 15;
            lstRekeningen.Location = new Point(593, 172);
            lstRekeningen.Margin = new Padding(4, 3, 4, 3);
            lstRekeningen.Name = "lstRekeningen";
            lstRekeningen.Size = new Size(215, 229);
            lstRekeningen.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(593, 88);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 28;
            label6.Text = "Naam rekening";
            // 
            // txtRekening
            // 
            txtRekening.Location = new Point(692, 84);
            txtRekening.Margin = new Padding(4, 3, 4, 3);
            txtRekening.Name = "txtRekening";
            txtRekening.Size = new Size(116, 23);
            txtRekening.TabIndex = 29;
            // 
            // lstBanken
            // 
            lstBanken.FormattingEnabled = true;
            lstBanken.ItemHeight = 15;
            lstBanken.Location = new Point(85, 172);
            lstBanken.Margin = new Padding(4, 3, 4, 3);
            lstBanken.Name = "lstBanken";
            lstBanken.Size = new Size(195, 229);
            lstBanken.TabIndex = 35;
            // 
            // btnNieuweBank
            // 
            btnNieuweBank.Location = new Point(85, 127);
            btnNieuweBank.Margin = new Padding(4, 3, 4, 3);
            btnNieuweBank.Name = "btnNieuweBank";
            btnNieuweBank.Size = new Size(196, 27);
            btnNieuweBank.TabIndex = 34;
            btnNieuweBank.Text = "nieuwe bank toevoegen";
            btnNieuweBank.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 88);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 33;
            label7.Text = "Bank";
            // 
            // txtBank
            // 
            txtBank.Location = new Point(165, 84);
            txtBank.Margin = new Padding(4, 3, 4, 3);
            txtBank.Name = "txtBank";
            txtBank.Size = new Size(116, 23);
            txtBank.TabIndex = 32;
            // 
            // BankDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 479);
            Controls.Add(lstBanken);
            Controls.Add(btnNieuweBank);
            Controls.Add(label7);
            Controls.Add(txtBank);
            Controls.Add(txtRekening);
            Controls.Add(label6);
            Controls.Add(lstRekeningen);
            Controls.Add(lstKlanten);
            Controls.Add(btnNieuweKlant);
            Controls.Add(label5);
            Controls.Add(btnOpname);
            Controls.Add(btnStorting);
            Controls.Add(txtBedrag);
            Controls.Add(lblSaldo);
            Controls.Add(lblNaam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNieuweRekening);
            Controls.Add(txtAN);
            Controls.Add(txtVN);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BankDB";
            Text = "InterfaceUitbreiding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOpname;
        private System.Windows.Forms.Button btnStorting;
        private System.Windows.Forms.TextBox txtBedrag;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNieuweRekening;
        private System.Windows.Forms.TextBox txtAN;
        private System.Windows.Forms.TextBox txtVN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNieuweKlant;
        private System.Windows.Forms.ListBox lstKlanten;
        private System.Windows.Forms.ListBox lstRekeningen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRekening;
        private ListBox lstBanken;
        private Button btnNieuweBank;
        private Label label7;
        private TextBox txtBank;
    }
}