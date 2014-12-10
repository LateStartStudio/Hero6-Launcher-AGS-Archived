using System;
using System.Collections.Generic;
using System.Text;

namespace Hero6_Launcher
{
    /// <summary>
    /// Filename: ConfigHandler.cs
    /// Author:   Per Olav Flaten
    /// </summary>
    class ConfigHandler
    {

        private List<string> oldConfig = new List<string>(); // Backup
        private List<string> newConfig = new List<string>();

        public int Windowed { get; set; }
        public int Refresh { get; set; }
        public string GraphicDriver { get; set; }
        public string GraphicFilter { get; set; }

        public ConfigHandler()
        {
            foreach(string line in System.IO.File.ReadAllLines("acsetup.cfg"))
            {
                oldConfig.Add(line);
            }
        }

        public List<ConfigAttribute> extractAttributesFromPrint()
        {
            List<ConfigAttribute> attributes = new List<ConfigAttribute>();
            foreach (string line in oldConfig)
            {
                if (!(line.Equals("[sound]") || !line.Equals("[misc]")))
                {
                    string[] splitLine = line.Split('=');
                    attributes.Add(new ConfigAttribute(splitLine[0], splitLine[1], ""));
                }
            }
            return attributes;
        }

        public void buildConfigForPrint()
        {
            this.newConfig.Add("[sound]");
            this.newConfig.Add("digiid=-1");
            this.newConfig.Add("midiid=-1");
            this.newConfig.Add("digiwin=1");
            this.newConfig.Add("midiwin=-1");
            this.newConfig.Add("digiindx=0");
            this.newConfig.Add("midiindx=0");
            this.newConfig.Add("digiwinindx=0");
            this.newConfig.Add("midiwinindx=0");
            this.newConfig.Add("[misc]");
            this.newConfig.Add("gamecolordepth=32");
            this.newConfig.Add("defaultres=2");
            this.newConfig.Add("screenres=0");
            this.newConfig.Add("letterbox=1");
            this.newConfig.Add("defaultgfxdriver=D3D9");
            this.newConfig.Add("gfxdriver=" + GraphicDriver);
            this.newConfig.Add("titletext=Hero6 Setup");
            this.newConfig.Add("log=1");
            this.newConfig.Add("windowed=" + this.Windowed);
            this.newConfig.Add("refresh=" + this.Refresh);
            this.newConfig.Add("gfxfilter=" + this.GraphicFilter);
        }

        public void extendConfigWithHorizontalBorders(bool checkbox)
        {
            if (!checkbox) this.newConfig.Add("sideborders=0");
        }

        public void extendConfigWithVerticalBorders(bool checkbox)
        {
            if (checkbox) this.newConfig.Add("forceletterbox=1");
        }

        public void extendedConfigWithSmoothenedSprites(bool checkbox)
        {
            if (checkbox) this.newConfig.Add("antialias=1");
        }

        public void extendConfigWithReducedBits(bool checkbox)
        {
            if (checkbox) this.newConfig.Add("notruecolor=1");
        }

        public void printConfig()
        {
            System.IO.File.WriteAllLines("acsetup.cfg", this.newConfig.ToArray());
            this.newConfig = new List<string>(); // Reset text to avoid appending config
        }

        public void resetConfig() 
        {
            System.IO.File.WriteAllLines("acsetup.cfg", this.oldConfig.ToArray());
        }

        public void syncConfigs()
        {
            this.oldConfig = this.newConfig;
        }
    }
}
