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
    public partial class Form1 : Form
        //N.B: Le code est coupé en deux! En fait Visual Studio utilise un fichier pour le concepteur visuel, et un autre a éditer soi même (celui ci)
    {
        public Form1()
        {
            //initialise la fenêtre
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //inutilisé
        }

        private void button1_Click(object sender, EventArgs e)
            //gestionnaire d'events du bouton Ajouter un contact
        {
            //Cliquer sur le bouton Ajouter un contact ouvre la classe Add qui est la fenêtre "Ajouter un contact"
            new Add().Show();
            // la liste de contacts n'est pas encore gérée
            // à terme, la liste ListBox1 listera les contacts répertoriés dans le fichier de sauvegarde name.txt avec nom, n° de tel et trigramme
        }
    }
}
