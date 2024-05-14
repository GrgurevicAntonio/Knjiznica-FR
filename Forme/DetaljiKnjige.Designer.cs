
namespace KnjiznicaFR.Forme
{
    partial class DetaljiKnjige
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.nudGodinaIzdanja = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.cbBrojPrimjeraka = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(100, 33);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(154, 22);
            this.tbISBN.TabIndex = 1;
            // 
            // nudGodinaIzdanja
            // 
            this.nudGodinaIzdanja.Location = new System.Drawing.Point(134, 179);
            this.nudGodinaIzdanja.Name = "nudGodinaIzdanja";
            this.nudGodinaIzdanja.Size = new System.Drawing.Size(120, 22);
            this.nudGodinaIzdanja.TabIndex = 2;
            this.nudGodinaIzdanja.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj primjeraka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godina izdanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Naslov";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(100, 129);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(154, 22);
            this.tbAutor.TabIndex = 7;
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(100, 82);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(154, 22);
            this.tbNaslov.TabIndex = 8;
            // 
            // cbBrojPrimjeraka
            // 
            this.cbBrojPrimjeraka.FormattingEnabled = true;
            this.cbBrojPrimjeraka.Items.AddRange(new object[] {
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
            "20"});
            this.cbBrojPrimjeraka.Location = new System.Drawing.Point(134, 230);
            this.cbBrojPrimjeraka.Name = "cbBrojPrimjeraka";
            this.cbBrojPrimjeraka.Size = new System.Drawing.Size(61, 24);
            this.cbBrojPrimjeraka.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(70, 294);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 76);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // DetaljiKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbBrojPrimjeraka);
            this.Controls.Add(this.tbNaslov);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudGodinaIzdanja);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiKnjige";
            this.Text = "DetaljiKnjige";
            this.Load += new System.EventHandler(this.DetaljiKnjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGodinaIzdanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.NumericUpDown nudGodinaIzdanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.ComboBox cbBrojPrimjeraka;
        private System.Windows.Forms.Button btnOK;
    }
}