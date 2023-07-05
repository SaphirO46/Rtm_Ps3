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
        bool button4Activation = false;
        public string TexteAEnvoyer { get; set; }
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
                Form2 form2 = new Form2("                   YOU ARE CONNECTED !"); form2.Show(); ;
            }
            else
            {
              
                Form2 form2 = new Form2("                   ERROR\n Not Connected"); form2.Show();  //connexion
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "CONNECTED");
            }
            else { Form2 form2 = new Form2("                   ERROR"); form2.Show(); } //Attach
        }

        private void button3_Click(object sender, EventArgs e)
        {

            switch (trackBarKnockback.Value)
            {
                case 1:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x01 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 2:
                    try
                    {

                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x10 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 3:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x20 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 4:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x30 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 5:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x40 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 6:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x60 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 7:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0x90 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 8:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0xA5 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 9:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0xC5 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 10:

                    try
                    {

                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0xFF });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;


                default:
                    try
                    {
                        MessageBox.Show("you need a select value ");

                        PS3.SetMemory(0x003A4018, new byte[] { 0x40, 0xE5 });
                        string MessageKn = Convert.ToString(trackBarKnockback.Value);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void trackBarKnockback_Scroll(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!button4Activation) {
                try {

                    PS3.SetMemory(0x004B2021, new byte[] { 0x80 });

                }
                catch { Form2 form2 = new Form2("                   ERROR"); form2.Show(); }
            }
            else if (button4Activation)
            {
                try
                {

                    PS3.SetMemory(0x004B2021, new byte[] { 0x20 });

                }
                catch { Form2 form2 = new Form2("                   ERROR"); form2.Show(); }
            }
            else
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (trackBarFov.Value)
            {
                case 1:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0xC5 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 2:
                    try
                    {

                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0xA5 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 3:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x95 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 4:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x80 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 5:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x70 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 6:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x60 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 7:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x45 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 8:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x30 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 9:
                    try
                    {
                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x20 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 10:

                    try
                    {

                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x10 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;


                default:
                    try
                    {
                        MessageBox.Show("you need a select value ");

                        PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x80 });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2("info"); form2.Show();

        }
    }
    }

