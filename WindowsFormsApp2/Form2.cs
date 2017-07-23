using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //inutilisé
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //inutilisé
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gestionnaire d'events du bouton Ajouter
            string[] lines = {textName.Text, textPhone.Text, text3Letter.Text };
            if (string.IsNullOrWhiteSpace(textName.Text)| string.IsNullOrWhiteSpace(textPhone.Text)| string.IsNullOrWhiteSpace(text3Letter.Text))
                //Si l'un des champs est nul, renvoie la boite de message suivant
            {
                MessageBox.Show("Le formulaire n'est pas complet. Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //sinon, les informations sont ajoutés dans le fichier de sauvegarde
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Environment.CurrentDirectory + "/name.txt", true))
                {
                    file.WriteLine(lines);
                }
               //puis ferme la fenêtre
                this.Close();
            }
        }
    }
}
