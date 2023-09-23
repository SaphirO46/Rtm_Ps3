using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PS3Lib;
using Rtm_Ps3.Classes;

namespace Rtm_Ps3
{
    public partial class FormSettings : Form
    {
        private dynamic config;
        public dynamic connectionRecupParams()
        {
            string jsonFilePath = "jsconfig1.json";
            string json = File.ReadAllText(jsonFilePath);

            dynamic config = JObject.Parse(json);
            return config;
        }
        public void writeJsonData(dynamic config)
        {
            string jsonFilePath = "jsconfig1.json";
            string updatedJson = config.ToString();
            File.WriteAllText(jsonFilePath, updatedJson);
        }
        public FormSettings()
        {
            InitializeComponent();

            //get data from json
            config = connectionRecupParams();

            //autocheck when form is loaded ---------------------------
            //your custom preset enabler
            if (Convert.ToBoolean(config.godmode)) { checkBox2.Checked = true; }
            if (Convert.ToBoolean(config.defaultspresets)) { defaultPresetCheckBox.Checked = true; }
            if (Convert.ToBoolean(config.fov90)) { checkBox4.Checked = true; }
            if (Convert.ToBoolean(config.bettersky)) { checkBox6.Checked = true; }
            if (Convert.ToBoolean(config.betterline)) { checkBox3.Checked = true; }
            if (Convert.ToBoolean( config.antikick)) { checkBox3.Checked = true; }
            if (Convert.ToBoolean(config.chunkopti)) { checkBox3.Checked = true; }
            if (Convert.ToBoolean(config.betterskyshottype)) { checkBox3.Checked = true; }
            //---------------------------------------------------------
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                config.betterline = true;
            }
            else
            {
                config.betterline = false;
            }
        }

        private void defaultPresetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //default preset 
            if (defaultPresetCheckBox.Checked)
            {
                config.defaultspresets = true;
            }
            else 
            {
                config.defaultspresets = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //fov 90
           
            if (checkBox4.Checked)
            {
                config.fov90 = true;
            }
            else
            {
                config.fov90 = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //better sky
           
            if (checkBox6.Checked)
            {
                config.bettersky = true;
            }
            else
            {
                config.bettersky = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //godmode
            
            if (checkBox2.Checked)
            {
                config.godmode = true;
            }
            else
            {
                config.godmode = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            config.yourpresets = true;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = false;
            defaultPresetCheckBox.Checked = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeJsonData(config);
            writeJsonData(config);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //better sky shot type

            if (checkBox2.Checked)
            {
                config.godmode = true;
            }
            else
            {
                config.godmode = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//antikick
            if (checkBox2.Checked)
            {
                config.godmode = true;
            }
            else
            {
                config.godmode = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //chunk opti
            if (checkBox2.Checked)
            {
                config.godmode = true;
            }
            else
            {
                config.godmode = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
