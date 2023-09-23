//ENJOY MY SPAGHETTI CODE !
//MMMH LA PASTA !
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
using System.Net;
using Discord;
using Discord.WebSocket;
using Discord.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Runtime.Remoting.Contexts;
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.WebSockets;
using System.Threading;
using System.Web;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.IO;
using Rtm_Ps3.Classes;
using DiscordRPC;
using WebSocketSharp;

namespace Rtm_Ps3
{
    //overworld change to nether 0x00B22050   0x41
    public partial class Form1 : Form
    {
        string oldTextBox1 = "";
        string textToSent = "";
        string oldMessage = "";
        string skyInclinaison = "0";
        int testSucces = 0;
        bool button4Activation = false;
        private dynamic config;
        private WebSocketSharp.WebSocket ws;

        //variable de config user
        private string ip;
        private string defaultsPresets;

        //instance
        OffsetsYourPresets OffsetsYourPresets = new OffsetsYourPresets();



        //get all parametres from user -----------------------------------------------------------
        public dynamic connectionRecupParams()
        { 
            string jsonFilePath = "jsconfig1.json";
            string json = File.ReadAllText(jsonFilePath);

            dynamic config = JObject.Parse(json);
            return config;
        }

        

        //----------------------------------------------------------------------------------------


        public string TexteAEnvoyer { get; set; }
        private PS3API PS3 = new PS3API();
        private Random rand = new Random();
        private ClientWebSocket clientWebSocket;

        //function offset------------------------------------------

        //render distance 
        #region "fonction a la con"
        public void renderDistanceChange(int BarRender) {
            uint offset = 0x00B21C60;
            switch (BarRender)
            {
                case 1:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0xC0, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 2:
                    try
                    {

                        PS3.SetMemory(offset, new byte[] { 0xA0, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 3:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x80, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 4:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x60, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 5:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x30, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 6:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x20, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 7:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x15, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 8:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x10, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 9:
                    try
                    {
                        PS3.SetMemory(offset, new byte[] { 0x05, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x06, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
                case 10:

                    try
                    {

                        PS3.SetMemory(offset, new byte[] { 0x00, 0xC5 });
                        PS3.SetMemory(0x300136D3, new byte[] { 0x01, 0xFF });
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
            }
        }

        //fov
        public void fovChange(int BarFov) {
            switch (BarFov)
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


        //knockback 
        public void knockback(int BarKnockback) {
            switch (BarKnockback)
            {
                case 1:
                    try
                    {
                        PS3.SetMemory(0x003A4018, new byte[] { 0x39, 0x01 });
                        string MessageKn = Convert.ToString(BarKnockback);
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

                        PS3.SetMemory(0x003A4018, new byte[] { 0x39, 0x80 });
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        PS3.SetMemory(0x003A4018, new byte[] { 0x39, 0xBB });
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
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
                        string MessageKn = Convert.ToString(BarKnockback);
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Knockback level:" + MessageKn);
                    }
                    catch (Exception erreur)
                    {
                        Form2 form2 = new Form2("                   ERROR"); form2.Show();
                    }
                    break;
            }
        }
        public void customSky()
        {
            try
            {
                PS3.SetMemory(0x00B21F28, new byte[] { 0x41, 0x30 });//
                PS3.SetMemory(0x00B21F1C, new byte[] { 0x3F, 0xFF });//multiple sky //0xF8 for sky with moon
                PS3.SetMemory(0x00410738, new byte[] { 0x3F, 0x40 });//color sky
                PS3.SetMemory(0x00B21F24, new byte[] { 0x42, 0x00 });//
                PS3.SetMemory(0x00B21F5C, new byte[] { 0x84, 0x84 });//time sky


                // await MoveSunSky();


            }
            catch (Exception erreur) { Form2 form2 = new Form2("                   ERROR \n" + erreur); form2.Show(); }
        }
        #endregion
        //--------------------------------------------------
        //startApp
        public Form1()
        {
           
            InitializeComponent();
            Load += MainForm_Load;


            //get data from json
            config = connectionRecupParams();
            //define all value of param from json------------------------
            //IP
            string ip = config.ip;
            


            #region "connection ccapi"
            PS3.ChangeAPI(SelectAPI.ControlConsole);

            try
            {
                if (PS3.ConnectTarget(ip))
                {
                    try
                    {
                        if (PS3.AttachProcess())
                        {
                            //notif conection + attach
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "CONNECTED");
                            PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "WELCOME\n ON \n SAPHIRO \n RTM \n ENJOY");


                        }
                        else { Form2 form8 = new Form2("                   ERROR ATTACH : RESTART THE RTM IN GAME"); form8.Show(); } //Attach
                    }
                    catch { Form2 form4 = new Form2("\n\t\t\tERROR\n\n Not Attache"); form4.Show(); }
                    Form2 form5 = new Form2("                   YOU ARE CONNECTED !\n                   YOUR SETTINGS IS ON"); form5.Show(); 
                }
                else
                {

                    Form2 form8 = new Form2("                   ERROR\n Not Connected"); form8.Show();  //connexion
                }
            }catch{ }
            #endregion

            //your custom preset enabler
            OffsetsYourPresets.GODMODE(Convert.ToBoolean(config.godmode));
            OffsetsYourPresets.PRESETS(Convert.ToBoolean(config.defaultspresets));
            OffsetsYourPresets.FOV90(Convert.ToBoolean(config.fov90));
            OffsetsYourPresets.BETTERSKY(Convert.ToBoolean(config.bettersky), false, false);
            OffsetsYourPresets.BETTERLINE(Convert.ToBoolean(config.betterline));
            OffsetsYourPresets.BETTERSKY(Convert.ToBoolean(config.betterskyshottype), false, true);
            OffsetsYourPresets.BETTERLINE(Convert.ToBoolean(config.antikick));
            OffsetsYourPresets.BETTERLINE(Convert.ToBoolean(config.chunkopti));
            //-----------------------------------------------------------




            // Discord Rich Presence
            DiscordRpcClient client = new DiscordRpcClient("1126189107337510914");
            client.Initialize();

            RichPresence presence = new RichPresence
            {
                Details = "RTM MINECRAFT PS3 ",
                State = "modding",
               
            Assets = new Assets
                {
                    LargeImageKey = "large_image_key",
                    LargeImageText = "SAPHIRO RTM"
                }
            };
            

            client.SetPresence(presence);




        }
        public byte StrToByte(string strValue)
        {
            // Quitamos el prefijo "0x" del string
            if (strValue.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                strValue = strValue.Substring(2);

            // Convertimos el string a un número entero en base 16 (hexadecimal)
            int intValue1 = int.Parse(strValue, System.Globalization.NumberStyles.HexNumber);

            // Convertimos el número entero en un byte
            byte first = Convert.ToByte(intValue1);
            return first;
        }
        public async Task MoveSunSky()
        {
            while (true)
            {
                //ajoute 2 a la variable d'inclinaison du ciel.
               //PS3.SetMemory(0x00B21F24, new byte[] { 0x42 , StrToByte(skyInclinaison) });

                //skyInclinaison =  Convert.ToString(Convert.ToInt32(skyInclinaison) + 1);

                //Attendre 200 millisecondes avant la prochaine exécution
                //await Task.Delay(200);
            }
        }
        

        


        private void AfficherMessage(string message)
        {
            // Vérifier si nous sommes sur le thread principal pour mettre à jour l'interface utilisateur
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AfficherMessage), message);
            }
            else
            {
                // Ajouter le message à la TextBox
                textBox1.AppendText("Nouveau message reçu : " + message + Environment.NewLine);
            }
        }







        private void button1_Click(object sender, EventArgs e) //boutton de connection
        {

            PS3.ChangeAPI(SelectAPI.ControlConsole);
            if (PS3.ConnectTarget())
            {
                try
                {
                    if (PS3.AttachProcess())
                    {
                        //notif conection + attach
                        PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "CONNECTED");

                       


                    }
                    else { Form2 form3 = new Form2("                   ERROR"); form3.Show(); } //Attach
                }
                catch { Form2 form4 = new Form2("\n\t\t\tERROR\n\n Not Attache"); form4.Show(); }
                Form2 form2 = new Form2("                   YOU ARE CONNECTED !\n                   YOUR SETTINGS IS ON"); form2.Show(); ;
            }
            else
            {

                Form2 form2 = new Form2("                   ERROR\n Not Connected"); form2.Show();  //connexion
            }




        }
        private void Form1_Load(object sender, EventArgs e)
        {
           /* ws = new WebSocketSharp.WebSocket("");

            ws.OnMessage += (senderWs, eWs) =>
            {
                // Utilisation de Invoke pour mettre à jour la TextBox depuis le thread principal
                Invoke((MethodInvoker)delegate
                {
                    textBox1.Text=eWs.Data + Environment.NewLine ;
                });
            };

            ws.OnOpen += (senderWs, eWs) =>
            {
                // Utilisation de Invoke pour mettre à jour la TextBox depuis le thread principal
                Invoke((MethodInvoker)delegate
                {
                    textBox1.Text = "Connecté au serveur WebSocket" + Environment.NewLine;
                });
            };

            ws.OnClose += (senderWs, eWs) =>
            {
                // Utilisation de Invoke pour mettre à jour la TextBox depuis le thread principal
                Invoke((MethodInvoker)delegate
                {
                    textBox1.Text = "Déconnecté du serveur WebSocket" + Environment.NewLine;
                });
            };

            // Établissement de la connexion WebSocket
            ws.Connect();*/


        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.AttachProcess())
                {

                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "CONNECTED");
                }
                else { Form2 form2 = new Form2("                   ERROR ATTACH"); form2.Show(); } //Attach
            }
            catch { Form2 form2 = new Form2("\n\t\t\tERROR\n\n Not Attache"); form2.Show(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form5 = new Form2("                            You want try discord on ps3? \n                                 contact saphiro46               \n\n -discord : saphiro__\n -youtube : saphiro46"); form5.Show();

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void trackBarKnockback_Scroll(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (!button4Activation)
            {
                bool dark;
                bool shot;
                if (checkBoxDarkType.Checked) { dark = true; } else { dark = false; }
                if (checkBoxShotType.Checked) { shot = true; } else { shot = false; }
                OffsetsYourPresets.BETTERSKY(true,dark,shot);

                //await MoveSunSky();
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
            fovChange(trackBarFov.Value);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2("\t\t\tINFO\r\n\r\nThis is a design demonstration of what my rtm while be, so ther is just 3 mods you can try\r\nthis 3 mods work really good, i think...?\r\nccapi only sorry for tmapi.\r\n\r\n FAQ :\r\nQ : why only ccapi          | A : because nobody use tmapi\r\nQ : who created the rtm | A : SaphirO46 created this rtm, the 3 adresses come from misakii\r\nQ : why just 3 mods | A : i want to sear(lol there is no update of the faq)"); form2.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text != oldTextBox1) {
                oldTextBox1 = textBox1.Text ;
                textToSent = "DISCORD :\n" + textBox1.Text;


                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, textToSent);
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        #region "manual set memory"
        private void button6_Click_1(object sender, EventArgs e)
        {
            //-----------------------------------------------
            string strValue1 = textBox2.Text;

            // Quitamos el prefijo "0x" del string
            if (strValue1.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                strValue1 = strValue1.Substring(2);

            // Convertimos el string a un número entero en base 16 (hexadecimal)
            int intValue1 = int.Parse(strValue1, System.Globalization.NumberStyles.HexNumber);

            // Convertimos el número entero en un byte
            byte first = Convert.ToByte(intValue1);

            //------------------------------------------------
            string strValue2 = textBox3.Text;
            // Quitamos el prefijo "0x" del string
            if (strValue2.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                strValue2 = strValue2.Substring(2);

            // Convertimos el string a un número entero en base 16 (hexadecimal)
            int intValue2 = int.Parse(strValue2, System.Globalization.NumberStyles.HexNumber);

            // Convertimos el número entero en un byte
            byte second = Convert.ToByte(intValue2);
            //--------------------------------------------------------
            string strValue3 = textBox4.Text;
            // Supprimer le préfixe "0x" de la chaîne
            if (strValue3.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                strValue3 = strValue3.Substring(2);

            // Convertir la chaîne en un entier en base 16 (hexadécimal)
            uint lastAdd = uint.Parse(strValue3, System.Globalization.NumberStyles.HexNumber);

            //--------------------------------------------------------


            PS3.SetMemory(lastAdd, new byte[] { first, second });
        }
        #endregion
        private void button7_Click(object sender, EventArgs e) // defaults presets button
        {
            //preset 1

            try
            {
                //custom sky -----------------------------------------------------------------
                PS3.SetMemory(0x00B21F28, new byte[] { 0x41, 0x30 });//
                PS3.SetMemory(0x00B21F1C, new byte[] { 0x3F, 0xFF });//multiple sky //0xF8 for sky with moon
                PS3.SetMemory(0x00410738, new byte[] { 0x3F, 0x40 });//color sky
                PS3.SetMemory(0x00B21F24, new byte[] { 0x42, 0x00 });//
                PS3.SetMemory(0x00B21F5C, new byte[] { 0x84, 0x84 });//time sky

                //FOV-------------------------------------------------------------------------
                PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x45 });

                //Take all in chest-----------------------------------------------------------
                PS3.SetMemory(0x007D79D0, new byte[] { 0x4E, 0x80, 0x00, 0x20 });

                //chunk opti------------------------------------------------------------------
                PS3.SetMemory(0x00B21C60, new byte[] { 0x40, 0xD7, 0x00, 0x00 });

                //show armor------------------------------------------------------------------
                PS3.SetMemory(0x0090B5F0, new byte[] { 0x38, 0x80, 0x00, 0x01 });

                //show iditems-----------------------------------------------------------------
                PS3.SetMemory(0x003097B8, new byte[] { 0x41, 0xFF });

                //show damages items-----------------------------------------------------------
                PS3.SetMemory(0x00AD5A5C, new byte[] { 0x3F, 0x80 });

                //disable fog------------------------------------------------------------------
                PS3.SetMemory(0x300136D3, new byte[] { 0x01, 0xFF });

                //better line------------------------------------------------------------------
                PS3.SetMemory(0x00B25998, new byte[] { 0x41, 0x25 });//bigger lines
                PS3.SetMemory(0x00B25A59, new byte[] { 0x30, 0x70 });//color lines




                 

                Form2 form2 = new Form2("                   PRESETS : \n -custom sky    -Fov 90\n   -take all in chest   -Better chunk \n   -Better Fps   -show armot \n   -show ID+ items's damage    -better lines "); form2.Show();

            }
            catch (Exception erreur) { Form2 form2 = new Form2("                   ERROR \n" + erreur); form2.Show(); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBarFov_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormSettings SettingsPage = new FormSettings();
            //preset2
            SettingsPage.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            renderDistanceChange(trackBarRender.Value);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string jsonFilePath = "jsconfig1.json";
            string json = File.ReadAllText(jsonFilePath);

            dynamic config = JObject.Parse(json);
            config.ip = textBox5.Text;
            

            string updatedJson = config.ToString();
            File.WriteAllText(jsonFilePath, updatedJson);

            Console.WriteLine("Valeurs mises à jour avec succès.");

            Form2 form2 = new Form2("Great your Ip is : " + textBox5.Text + "  Restart the rtm to aply ip setting (auto connect only with ccapi)"); form2.Show();



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        
        

        private void button10_Click_1(object sender, EventArgs e)
        {
            FormSettingsDiscord formSettingsDiscord = new FormSettingsDiscord();
            formSettingsDiscord.Show();
        }
    }
}

