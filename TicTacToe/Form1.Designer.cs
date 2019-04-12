namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuovaPartitaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.griglia = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griglia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaPartitaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(230, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuovaPartitaToolStripMenuItem1
            // 
            this.nuovaPartitaToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.nuovaPartitaToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nuovaPartitaToolStripMenuItem1.Name = "nuovaPartitaToolStripMenuItem1";
            this.nuovaPartitaToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.nuovaPartitaToolStripMenuItem1.Text = "New Game";
            this.nuovaPartitaToolStripMenuItem1.Click += new System.EventHandler(this.nuovaPartitaToolStripMenuItem_Click);
            // 
            // griglia
            // 
            this.griglia.Image = global::TicTacToe.Properties.Resources.Grid;
            this.griglia.Location = new System.Drawing.Point(0, 24);
            this.griglia.Name = "griglia";
            this.griglia.Size = new System.Drawing.Size(230, 230);
            this.griglia.TabIndex = 1;
            this.griglia.TabStop = false;
            this.griglia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.griglia_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 253);
            this.Controls.Add(this.griglia);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griglia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox griglia;
        private System.Windows.Forms.ToolStripMenuItem nuovaPartitaToolStripMenuItem1;
    }
}

