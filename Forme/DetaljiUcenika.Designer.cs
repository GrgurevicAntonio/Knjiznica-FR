
namespace KnjiznicaFR.Forme
{
    partial class DetaljiUcenika
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
            this.cbRazred = new System.Windows.Forms.ComboBox();
            this.lOIB = new System.Windows.Forms.Label();
            this.tbOIB = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lIme = new System.Windows.Forms.Label();
            this.lPrezime = new System.Windows.Forms.Label();
            this.lAdresa = new System.Windows.Forms.Label();
            this.lTelefon = new System.Windows.Forms.Label();
            this.lRazred = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRazred
            // 
            this.cbRazred.FormattingEnabled = true;
            this.cbRazred.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbRazred.Location = new System.Drawing.Point(93, 290);
            this.cbRazred.Name = "cbRazred";
            this.cbRazred.Size = new System.Drawing.Size(58, 24);
            this.cbRazred.TabIndex = 0;
            // 
            // lOIB
            // 
            this.lOIB.AutoSize = true;
            this.lOIB.Location = new System.Drawing.Point(21, 41);
            this.lOIB.Name = "lOIB";
            this.lOIB.Size = new System.Drawing.Size(31, 17);
            this.lOIB.TabIndex = 1;
            this.lOIB.Text = "OIB";
            // 
            // tbOIB
            // 
            this.tbOIB.Location = new System.Drawing.Point(93, 41);
            this.tbOIB.Name = "tbOIB";
            this.tbOIB.Size = new System.Drawing.Size(166, 22);
            this.tbOIB.TabIndex = 2;
            this.tbOIB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(93, 91);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(166, 22);
            this.tbIme.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(93, 140);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(166, 22);
            this.tbPrezime.TabIndex = 4;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(93, 183);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(166, 22);
            this.tbAdresa.TabIndex = 5;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(93, 234);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(166, 22);
            this.tbTelefon.TabIndex = 6;
            // 
            // lIme
            // 
            this.lIme.AutoSize = true;
            this.lIme.Location = new System.Drawing.Point(21, 96);
            this.lIme.Name = "lIme";
            this.lIme.Size = new System.Drawing.Size(30, 17);
            this.lIme.TabIndex = 7;
            this.lIme.Text = "Ime";
            // 
            // lPrezime
            // 
            this.lPrezime.AutoSize = true;
            this.lPrezime.Location = new System.Drawing.Point(21, 140);
            this.lPrezime.Name = "lPrezime";
            this.lPrezime.Size = new System.Drawing.Size(59, 17);
            this.lPrezime.TabIndex = 8;
            this.lPrezime.Text = "Prezime";
            // 
            // lAdresa
            // 
            this.lAdresa.AutoSize = true;
            this.lAdresa.Location = new System.Drawing.Point(21, 183);
            this.lAdresa.Name = "lAdresa";
            this.lAdresa.Size = new System.Drawing.Size(53, 17);
            this.lAdresa.TabIndex = 9;
            this.lAdresa.Text = "Adresa";
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Location = new System.Drawing.Point(21, 237);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(56, 17);
            this.lTelefon.TabIndex = 10;
            this.lTelefon.Text = "Telefon";
            // 
            // lRazred
            // 
            this.lRazred.AutoSize = true;
            this.lRazred.Location = new System.Drawing.Point(21, 297);
            this.lRazred.Name = "lRazred";
            this.lRazred.Size = new System.Drawing.Size(54, 17);
            this.lRazred.TabIndex = 11;
            this.lRazred.Text = "Razred";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(93, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 70);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DetaljiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lRazred);
            this.Controls.Add(this.lTelefon);
            this.Controls.Add(this.lAdresa);
            this.Controls.Add(this.lPrezime);
            this.Controls.Add(this.lIme);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbOIB);
            this.Controls.Add(this.lOIB);
            this.Controls.Add(this.cbRazred);
            this.Name = "DetaljiUcenika";
            this.Text = "DetaljiUcenika";
            this.Load += new System.EventHandler(this.DetaljiUcenika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRazred;
        private System.Windows.Forms.Label lOIB;
        private System.Windows.Forms.TextBox tbOIB;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lIme;
        private System.Windows.Forms.Label lPrezime;
        private System.Windows.Forms.Label lAdresa;
        private System.Windows.Forms.Label lTelefon;
        private System.Windows.Forms.Label lRazred;
        private System.Windows.Forms.Button btnOK;
    }
}