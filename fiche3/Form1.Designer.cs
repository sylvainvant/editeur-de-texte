namespace fiche3
{
    partial class Fm_principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_text = new System.Windows.Forms.RichTextBox();
            this.ms_principal = new System.Windows.Forms.MenuStrip();
            this.mi_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_eregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.mi = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_text
            // 
            this.rt_text.Location = new System.Drawing.Point(0, 26);
            this.rt_text.Name = "rt_text";
            this.rt_text.ReadOnly = true;
            this.rt_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_text.Size = new System.Drawing.Size(0, 0);
            this.rt_text.TabIndex = 0;
            this.rt_text.Text = "";
            this.rt_text.UseWaitCursor = true;
            this.rt_text.CursorChanged += new System.EventHandler(this.rt_text_Resize);
            this.rt_text.Move += new System.EventHandler(this.rt_text_Resize);
            this.rt_text.Resize += new System.EventHandler(this.rt_text_Resize);
            // 
            // ms_principal
            // 
            this.ms_principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ms_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_fichier,
            this.editionToolStripMenuItem});
            this.ms_principal.Location = new System.Drawing.Point(0, 0);
            this.ms_principal.Name = "ms_principal";
            this.ms_principal.Size = new System.Drawing.Size(329, 24);
            this.ms_principal.TabIndex = 1;
            this.ms_principal.Text = "menuStrip1";
            this.ms_principal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ms_principal_ItemClicked);
            // 
            // mi_fichier
            // 
            this.mi_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ouvrir,
            this.nouveauToolStripMenuItem,
            this.mi_enregistrer,
            this.mi_eregistrerSous,
            this.mi,
            this.mi_quitter});
            this.mi_fichier.Name = "mi_fichier";
            this.mi_fichier.Size = new System.Drawing.Size(51, 20);
            this.mi_fichier.Text = "Ficher";
            this.mi_fichier.Click += new System.EventHandler(this.ficherToolStripMenuItem_Click);
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_ouvrir.Size = new System.Drawing.Size(170, 22);
            this.mi_ouvrir.Text = "Ouvrir";
            this.mi_ouvrir.Click += new System.EventHandler(this.mi_ouvrir_Click);
            // 
            // mi_enregistrer
            // 
            this.mi_enregistrer.Name = "mi_enregistrer";
            this.mi_enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_enregistrer.Size = new System.Drawing.Size(170, 22);
            this.mi_enregistrer.Text = "Enregistrer";
            this.mi_enregistrer.Click += new System.EventHandler(this.mi_enregistrer_Click);
            // 
            // mi_eregistrerSous
            // 
            this.mi_eregistrerSous.Name = "mi_eregistrerSous";
            this.mi_eregistrerSous.Size = new System.Drawing.Size(152, 22);
            this.mi_eregistrerSous.Text = "Eregistrer sous";
            this.mi_eregistrerSous.Click += new System.EventHandler(this.mi_eregistrerSous_Click);
            // 
            // mi
            // 
            this.mi.Name = "mi";
            this.mi.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_quitter
            // 
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.Size = new System.Drawing.Size(152, 22);
            this.mi_quitter.Text = "Quitter";
            this.mi_quitter.Click += new System.EventHandler(this.mi_quitter_Click);
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            this.od_ouvrir.FileOk += new System.ComponentModel.CancelEventHandler(this.od_ouvrir_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // rt_texte
            // 
            this.rt_texte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_texte.Location = new System.Drawing.Point(0, 24);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(329, 269);
            this.rt_texte.TabIndex = 2;
            this.rt_texte.Text = "";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rétablirToolStripMenuItem.Text = "Rétablir";
            this.rétablirToolStripMenuItem.Click += new System.EventHandler(this.rétablirToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // Fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 293);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.rt_text);
            this.Controls.Add(this.ms_principal);
            this.MainMenuStrip = this.ms_principal;
            this.Name = "Fm_principal";
            this.Text = "petit éditeur";
            this.Load += new System.EventHandler(this.Fm_principal_Load);
            this.ms_principal.ResumeLayout(false);
            this.ms_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_text;
        private System.Windows.Forms.MenuStrip ms_principal;
        private System.Windows.Forms.ToolStripMenuItem mi_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem mi_eregistrerSous;
        private System.Windows.Forms.ToolStripSeparator mi;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    }
}

