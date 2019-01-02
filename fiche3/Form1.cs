using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiche3
{
    public partial class Fm_principal : Form
    {
        private string fichierCourant = "";

        public Fm_principal()
        {
            InitializeComponent();
        }
        private void Fm_principal_Load(object sender, EventArgs e)
        {

        }

        private void rt_text_Resize(object sender, EventArgs e)
        {

        }

        private void ms_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ficherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog() == DialogResult.OK)
            {
                rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void od_ouvrir_FileOk(object sender, CancelEventArgs e)
        {

            rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
        }
        private void mi_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void mi_enregistrer_Click(object sender, EventArgs e)
        {
            if (fichierCourant != "")
            {
                rt_texte.SaveFile(fichierCourant, RichTextBoxStreamType.PlainText);
            }
        }

        private void mi_eregistrerSous_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                fichierCourant = saveFileDialog1.FileName;
            } 
        }
                
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Clear();
            fichierCourant = "";
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Undo();
        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Redo();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Copy();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Cut();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Paste();
        }
    }
}
