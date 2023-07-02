using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace Rtm_Ps3
{

    public partial class Form1 : Form
    {
        private PS3API PS3 = new PS3API();
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PS3.ChangeAPI(SelectAPI.ControlConsole);
            if (PS3.ConnectTarget())
            {
                string Message = "tu est conectée avec le SimplyLife by Paranctiss v1  ";
                MessageBox.Show(Message, "Connecté !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string Message = "Connexion échouée :(";
                MessageBox.Show(Message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error); //connexion
            }



            if (PS3.AttachProcess())
            {
                MessageBox.Show("Attaché avec succé !.", "Parfait !", MessageBoxButtons.OK, MessageBoxIcon.Question);
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, "PS3 Prête !");
            }
            else { MessageBox.Show("Probleme lors de l'attachement", "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error); } //Attach

        }
    }
    }

