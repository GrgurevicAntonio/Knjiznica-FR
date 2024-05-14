
namespace KnjiznicaFR.Forme
{
    partial class frmKnjiznicaFR
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
            this.lbPosudbe = new System.Windows.Forms.ListBox();
            this.lPosuđeneKnjige = new System.Windows.Forms.Label();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uceniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPosudbe
            // 
            this.lbPosudbe.FormattingEnabled = true;
            this.lbPosudbe.ItemHeight = 16;
            this.lbPosudbe.Location = new System.Drawing.Point(22, 77);
            this.lbPosudbe.Name = "lbPosudbe";
            this.lbPosudbe.Size = new System.Drawing.Size(328, 292);
            this.lbPosudbe.TabIndex = 0;
            // 
            // lPosuđeneKnjige
            // 
            this.lPosuđeneKnjige.AutoSize = true;
            this.lPosuđeneKnjige.Location = new System.Drawing.Point(19, 43);
            this.lPosuđeneKnjige.Name = "lPosuđeneKnjige";
            this.lPosuđeneKnjige.Size = new System.Drawing.Size(113, 17);
            this.lPosuđeneKnjige.TabIndex = 1;
            this.lPosuđeneKnjige.Text = "Posuđene knjige";
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(421, 77);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(100, 49);
            this.btnPosudi.TabIndex = 2;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(421, 170);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(100, 51);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(421, 257);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(100, 51);
            this.btnVrati.TabIndex = 4;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uceniciToolStripMenuItem,
            this.knjigeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // uceniciToolStripMenuItem
            // 
            this.uceniciToolStripMenuItem.Name = "uceniciToolStripMenuItem";
            this.uceniciToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.uceniciToolStripMenuItem.Text = "Ucenici";
            this.uceniciToolStripMenuItem.Click += new System.EventHandler(this.uceniciToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // frmKnjiznicaFR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lPosuđeneKnjige);
            this.Controls.Add(this.lbPosudbe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmKnjiznicaFR";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.frmKnjiznicaFR_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPosudbe;
        private System.Windows.Forms.Label lPosuđeneKnjige;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uceniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
    }
}