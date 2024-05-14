
namespace KnjiznicaFR.Forme
{
    partial class DetaljiPosudbe
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.cbBrojDana = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lUcenik = new System.Windows.Forms.Label();
            this.lKnjiga = new System.Windows.Forms.Label();
            this.lDatumPosudbe = new System.Windows.Forms.Label();
            this.lBrojDana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.ItemHeight = 16;
            this.lbUcenici.Location = new System.Drawing.Point(43, 50);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(206, 148);
            this.lbUcenici.TabIndex = 1;
            // 
            // lbKnjige
            // 
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.ItemHeight = 16;
            this.lbKnjige.Location = new System.Drawing.Point(364, 50);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(206, 148);
            this.lbKnjige.TabIndex = 2;
            // 
            // cbBrojDana
            // 
            this.cbBrojDana.FormattingEnabled = true;
            this.cbBrojDana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbBrojDana.Location = new System.Drawing.Point(364, 253);
            this.cbBrojDana.Name = "cbBrojDana";
            this.cbBrojDana.Size = new System.Drawing.Size(66, 24);
            this.cbBrojDana.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(255, 334);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 63);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lUcenik
            // 
            this.lUcenik.AutoSize = true;
            this.lUcenik.Location = new System.Drawing.Point(40, 30);
            this.lUcenik.Name = "lUcenik";
            this.lUcenik.Size = new System.Drawing.Size(51, 17);
            this.lUcenik.TabIndex = 5;
            this.lUcenik.Text = "Učenik";
            // 
            // lKnjiga
            // 
            this.lKnjiga.AutoSize = true;
            this.lKnjiga.Location = new System.Drawing.Point(361, 30);
            this.lKnjiga.Name = "lKnjiga";
            this.lKnjiga.Size = new System.Drawing.Size(47, 17);
            this.lKnjiga.TabIndex = 6;
            this.lKnjiga.Text = "Knjiga";
            // 
            // lDatumPosudbe
            // 
            this.lDatumPosudbe.AutoSize = true;
            this.lDatumPosudbe.Location = new System.Drawing.Point(43, 232);
            this.lDatumPosudbe.Name = "lDatumPosudbe";
            this.lDatumPosudbe.Size = new System.Drawing.Size(108, 17);
            this.lDatumPosudbe.TabIndex = 7;
            this.lDatumPosudbe.Text = "Datum posudbe";
            // 
            // lBrojDana
            // 
            this.lBrojDana.AutoSize = true;
            this.lBrojDana.Location = new System.Drawing.Point(361, 232);
            this.lBrojDana.Name = "lBrojDana";
            this.lBrojDana.Size = new System.Drawing.Size(69, 17);
            this.lBrojDana.TabIndex = 8;
            this.lBrojDana.Text = "Broj dana";
            // 
            // DetaljiPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBrojDana);
            this.Controls.Add(this.lDatumPosudbe);
            this.Controls.Add(this.lKnjiga);
            this.Controls.Add(this.lUcenik);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbBrojDana);
            this.Controls.Add(this.lbKnjige);
            this.Controls.Add(this.lbUcenici);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DetaljiPosudbe";
            this.Text = "DetaljiPosudbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.ComboBox cbBrojDana;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lUcenik;
        private System.Windows.Forms.Label lKnjiga;
        private System.Windows.Forms.Label lDatumPosudbe;
        private System.Windows.Forms.Label lBrojDana;
    }
}