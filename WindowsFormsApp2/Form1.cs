using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
        //N.B: Le code est coupé en deux! En fait Visual Studio utilise un fichier pour le concepteur visuel, et un autre a éditer soi même (celui ci)

    {
        string savefile = Environment.CurrentDirectory + "/name.txt";


        public Form1()
        {
            //initialise la fenêtre
            InitializeComponent();

            
            if (File.Exists(savefile))
            {
                Debug.WriteLine("Savefile exists!");
            }
            else
            {
                File.Create(savefile);
                MessageBox.Show("Un fichier de sauvegarde à été créé.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            var refresh = File.ReadAllLines(savefile);
            foreach (var s in refresh) listBox1.Items.Add(refresh);
        }
    }
}
