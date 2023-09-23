using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;
using PS3Lib.NET;

namespace Rtm_Ps3.Classes
{
    public class OffsetsYourPresets
    {
        public static PS3API PS3 = new PS3API();
        public void GODMODE(bool uwu)
        {
            if (uwu)
            {

            }
        }
        public void PRESETS(bool uwu)
        {
            if (uwu)
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
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Defaults Presets:\n-Better sky\n-Chunk opti\n-Armor show\n-Items Info       ON");
            }
        }
        public void FOV90(bool uwu)
        {
            if (uwu)
            {
                PS3.SetMemory(0x014C670C, new byte[] { 0x3F, 0x45 });
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Fov 90\n       ON");
            }
            
        }

        public void RESET_SKY() {
            PS3.SetMemory(0x00410734, new byte[] { 0x40, 0xC0 });//color sky
            PS3.SetMemory(0x00410738, new byte[] { 0x3F, 0x80 });//color sky
            PS3.SetMemory(0x014C67D8, new byte[] { 0x3F }); ////SET to default fog
            PS3.SetMemory(0x003A3FF0, new byte[] { 0x3F, 0x80 });// default fog
        }
        public void BETTERSKY(bool uwu ,bool darkType , bool shotType)
        {
            if (uwu)
            {

                RESET_SKY();

                PS3.SetMemory(0x00B21F28, new byte[] { 0x41, 0x30 });//idk
                PS3.SetMemory(0x00B21F24, new byte[] { 0x42, 0x00 });//idk
                PS3.SetMemory(0x00B21F5C, new byte[] { 0x84, 0x84 });//time sky
                if (darkType) 
                { 
                    PS3.SetMemory(0x00AA1B76, new byte[] { 0x28 });//fogblack
                    PS3.SetMemory(0x00410734, new byte[] { 0xF0, 0xC0 });//black sky
                    
                }
                else 
                {
                    PS3.SetMemory(0x00410738, new byte[] { 0x3F, 0x40 });//color sky
                    
                }
                if (shotType) {
                    PS3.SetMemory(0x00B21F1C, new byte[] { 0x3F, 0x80 });//shot image size sun
                } 
                else 
                {
                    PS3.SetMemory(0x00B21F1C, new byte[] { 0x3F, 0xFF });//multiple sky //0xF8 for sky with moon
                }



                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Better Sky\n       ON");
            }
        }
        public void BETTERLINE(bool uwu)
        {
            Console.WriteLine("bad");
            if (uwu)
            {
                Console.WriteLine("great");
                //better line------------------------------------------------------------------
                PS3.SetMemory(0x00B25998, new byte[] { 0x41, 0x25 });//bigger lines
                PS3.SetMemory(0x00B25A59, new byte[] { 0x30, 0x70 });//color lines
                PS3.CCAPI.Notify(CCAPI.NotifyIcon.PEN, "Better Line\n       ON");
            }
        }
        public void ANTI_KICK(bool uwu)
        {
            
            if (uwu)
            {
               
                PS3.SetMemory(0x00AEE434, new byte[] { 0x40 });//anti kick
                
            }
        }

        public void BETTER_SKY_SHOT(bool uwu)
        {

            if (uwu)
            {

                PS3.SetMemory(0x00AEE434, new byte[] { 0x40 });//anti kick

            }
        }
        public void CHUNK_OPTI(bool uwu)
        {

            if (uwu)
            {

                PS3.SetMemory(0x00AEE434, new byte[] { 0x40 });//anti kick

            }
        }
    }
}
