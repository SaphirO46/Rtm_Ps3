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
using System.Net.Http;
using System.Net
using Discord;
using Discord.WebSocket;
using Discord.Net;
using Newtonsoft.Json.Linq;
using System.Runtime.Remoting.Contexts;
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rtm_Ps3
{

    public partial class Form1 : Form
    {

     

        /*
        DiscordSocketClient client = new DiscordSocketClient();
        */
       
        bool button4Activation = false;

        string urlApiChat = "https://saphiro46.com/lastMessage.php?message";



        public string TexteAEnvoyer { get; set; }
        private PS3API PS3 = new PS3API();
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2("\n\t\t\t INFO \n\n  This is a demo RTM tool for minecraft ps3"); form2.Show();

            /*       // Connexion Discord
                   client.MessageReceived += HandleMessageReceived;

                   Start();
            */

           

        }
        
            /*

            public async Task Start()
            {
                await client.LoginAsync(TokenType.Bot, token);
                await client.StartAsync();

                // Attendez indéfiniment pour écouter les nouveaux messages
                await Task.Delay(-1);
            }
            private Task HandleMessageReceived(SocketMessage message)
            {
                Console.WriteLine(Convert.ToString(message));
                // Vérifier si le message provient du serveur souhaité
                if (message.Channel is SocketTextChannel channel && channel.Guild.Id == ulong.Parse("710245976249598032"))
                {
                    // Vérifier si le message provient du salon souhaité
                    if (channel.Id == ulong.Parse("1126188227775180872"))
                    {
                        // Gérer le nouveau message ici
                        string msgDiscord = $"{message}";

                        string guyDiscord = $"{message.Author.Username}";


                        string temp = "";

                        for (int i = 0; i <4; i++)
                        {

                            temp += guyDiscord[i];
                        }
                        guyDiscord = temp;

                        string txtFinalMsg = guyDiscord + "[" + msgDiscord + "]";

                        temp = "";

                        // Débogage : Afficher la valeur de msgDiscord dans la console
                        Console.WriteLine("Message Discord : " + message.ToString());

                        // Mettre à jour le TextBox avec le nouveau message
                        textBox1.Invoke((MethodInvoker)(() =>
                        {
                            textBox1.AppendText(txtFinalMsg + Environment.NewLine);
                        }));


                    }
                }

                return Task.CompletedTask;
            }
            */


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
            try
            {
                if (PS3.AttachProcess())
                {

                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "CONNECTED");
                }
                else { Form2 form2 = new Form2("                   ERROR"); form2.Show(); } //Attach
            }
            catch { Form2 form2 = new Form2("\n\t\t\tERROR\n\n Not Attache"); form2.Show(); }
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

            Form2 form2 = new Form2("\t\t\tINFO\r\n\r\nThis is a design demonstration of what my rtm while be, so ther is just 3 mods you can try\r\nthis 3 mods work really good, i think...?\r\nccapi only sorry for tmapi.\r\n\r\n FAQ :\r\nQ : why only ccapi          | A : because nobody use tmapi\r\nQ : who created the rtm | A : SaphirO46 created this rtm, the 3 adresses come from misakii\r\nQ : why just 3 mods | A : i want to search my own memory adresse and that just a designe demo"); form2.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

