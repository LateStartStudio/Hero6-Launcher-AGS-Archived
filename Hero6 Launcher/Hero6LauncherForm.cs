using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hero6_Launcher
{
    /// <summary>
    /// Filename: Hero6SetupWindow.cs
    /// Author:   Per Olav Flaten
    /// </summary>
    public partial class Hero6LauncherForm : Form
    {

        private ConfigHandler configHandler;

        private List<ConfigAttribute> graphicDrivers = new List<ConfigAttribute>();
        private List<ConfigAttribute> graphicFiltersDD = new List<ConfigAttribute>();
        private List<ConfigAttribute> graphicFiltersD3D = new List<ConfigAttribute>();

        public Hero6LauncherForm()
        {
            this.configHandler = new ConfigHandler();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadDriverList();
            this.loadFilterD3DList(); // Load the Direct3D filters as default

            List<ConfigAttribute> attributes = configHandler.extractAttributesFromPrint();
            horizontalBordersCheckBox.Checked = true;

            foreach (ConfigAttribute att in attributes) // Make sure gfxdriver is identified first!!
            {
                if (att.AttributeName.Equals("gfxdriver"))
                {
                    if (graphicDrivers.IndexOf(att) == 0)     // Load DirectDraw filters
                    {
                        driverComboBox.SelectedIndex = 0;
                        this.loadFilterDDList();
                    }
                    else if (graphicDrivers.IndexOf(att) == 1) // Load Direct3D filters
                    {
                        driverComboBox.SelectedIndex = 1;
                        this.loadFilterD3DList();
                    }
                }
            }
            foreach (ConfigAttribute att in attributes)
            {
                if (att.AttributeName.Equals("windowed") && att.AttributeValue.Equals("0")) windowCheckBox.Checked = true;
                else if (att.AttributeName.Equals("gfxfilter"))
                {
                    if (driverComboBox.SelectedIndex == 0)       // Is DirectDrav the selected driver?
                    {
                        if (graphicFiltersDD.IndexOf(att) >= 0) filterComboBox.SelectedIndex = graphicFiltersDD.IndexOf(att);
                    }
                    else if (driverComboBox.SelectedIndex == 1) // Is Direct3D the selected driver?
                    {
                        if (graphicFiltersD3D.IndexOf(att) >= 0) filterComboBox.SelectedIndex = graphicFiltersD3D.IndexOf(att);
                    }
                }
                else if (att.AttributeName.Equals("sideborders")) horizontalBordersCheckBox.Checked = false;
                else if (att.AttributeName.Equals("forceletterbox")) verticalBordersCheckBox.Checked = true;
                else if (att.AttributeName.Equals("antialias")) smoothSpritesCheckBox.Checked = true;
                else if (att.AttributeName.Equals("notruecolor")) downgradeBitsCheckBox.Checked = true;
                else if (att.AttributeName.Equals("refresh") && att.AttributeValue.Equals("85")) crtDisplayCheckBox.Checked = true;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.executeSetup();
            Process.Start("hero6.exe");
            System.Threading.Thread.Sleep(1000);
            this.configHandler.resetConfig();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.executeSetup();
            this.configHandler.syncConfigs();
        }

        private void executeSetup()
        {
            //Set full screen
            if (windowCheckBox.Checked) this.configHandler.Windowed = 0;
            else this.configHandler.Windowed = 1;
            //Set Graphics driver
            this.configHandler.GraphicDriver = ((ConfigAttribute)driverComboBox.SelectedItem).AttributeValue;
            //Set Graphics filter
            this.configHandler.GraphicFilter = ((ConfigAttribute)filterComboBox.SelectedItem).AttributeValue;
            //Set 85 Hz
            if (crtDisplayCheckBox.Checked) this.configHandler.Refresh = 85;
            else this.configHandler.Refresh = 0;

            //Build config with the fixed default amount of attributes, setting of additional attributes below
            this.configHandler.buildConfigForPrint();

            //Set side borders
            this.configHandler.extendConfigWithHorizontalBorders(horizontalBordersCheckBox.Checked);
            //Set top bottom borders
            this.configHandler.extendConfigWithVerticalBorders(verticalBordersCheckBox.Checked);
            //Set smooth scaled sprites
            this.configHandler.extendedConfigWithSmoothenedSprites(smoothSpritesCheckBox.Checked);
            //Set downgrade 32-bit
            this.configHandler.extendConfigWithReducedBits(downgradeBitsCheckBox.Checked);

            this.configHandler.printConfig();
        }

        private void loadDriverList()
        {
            this.graphicDrivers.Add(new ConfigAttribute("gfxdriver", "DX5", "DirectDraw 5"));
            this.graphicDrivers.Add(new ConfigAttribute("gfxdriver", "D3D9", "Direct3D 9"));

            foreach (ConfigAttribute item in this.graphicDrivers)
            {
                driverComboBox.Items.Add(item);
            }

            driverComboBox.SelectedIndex = 1; // Set to the game's default display driver
        }

        private void loadFilterDDList()
        {
            this.graphicFiltersDD = new List<ConfigAttribute>();
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "None", "None"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "max", "Max nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale2", "2x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale3", "3x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale4", "4x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale5", "5x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale6", "6x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale7", "7x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "StdScale8", "8x nearest-neighbour filter"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "Hq2x", "Hq2x filter (32-bit only)"));
            this.graphicFiltersDD.Add(new ConfigAttribute("gfxfilter", "Hq3x", "Hq2x filter (32-bit only)"));

            this.loadFilterList(this.graphicFiltersDD);
        }

        private void loadFilterD3DList()
        {
            this.graphicFiltersD3D = new List<ConfigAttribute>();
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "None", "None"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "max", "Max nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale2", "2x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale3", "3x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale4", "4x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale5", "5x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale6", "6x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale7", "7x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "StdScale8", "8x nearest-neighbour filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx2", "2x anti-aliasing filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx3", "3x anti-aliasing filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx4", "4x anti-aliasing filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx5", "5x anti-aliasing filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx6", "6x anti-aliasing filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx7", "7x anti-aliasing filter"));
            this.graphicFiltersD3D.Add(new ConfigAttribute("gfxfilter", "AAx8", "8x anti-aliasing filter"));

            this.loadFilterList(this.graphicFiltersD3D);
        }

        private void loadFilterList(List<ConfigAttribute> filterList)
        {
            filterComboBox.Items.Clear();
            foreach(ConfigAttribute item in filterList)
            {
                filterComboBox.Items.Add(item);
            }
            filterComboBox.SelectedIndex = 0; // Set to the game's default display scaling filter
        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigAttribute currentFilter = (ConfigAttribute)filterComboBox.SelectedItem;
            if (driverComboBox.SelectedIndex == 0)
            {
                this.loadFilterDDList();
                if (graphicFiltersDD.IndexOf(currentFilter) >= 0) filterComboBox.SelectedIndex = graphicFiltersDD.IndexOf(currentFilter);
                else filterComboBox.SelectedIndex = 0;
            }
            else if (driverComboBox.SelectedIndex == 1)
            {
                this.loadFilterD3DList();
                if (graphicFiltersD3D.IndexOf(currentFilter) >= 0) filterComboBox.SelectedIndex = graphicFiltersD3D.IndexOf(currentFilter);
                else filterComboBox.SelectedIndex = 0;
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int driverIndex = driverComboBox.SelectedIndex;
            int filterIndex = filterComboBox.SelectedIndex;
            if ((driverIndex == 0 && filterIndex == 0) || (driverIndex == 0 && filterIndex == 1) ||
                (driverIndex == 1 && filterIndex == 0) || (driverIndex == 1 && filterIndex == 1))
                resolutionLabel.Text = "320 x 240";
            else if ((driverIndex == 0 && filterIndex == 2) || (driverIndex == 0 && filterIndex == 9) ||
                (driverIndex == 1 && filterIndex == 2) || (driverIndex == 1 && filterIndex == 9))
                resolutionLabel.Text = "640 x 480";
            else if ((driverIndex == 0 && filterIndex == 3) || (driverIndex == 0 && filterIndex == 10) ||
                (driverIndex == 1 && filterIndex == 3) || (driverIndex == 1 && filterIndex == 10))
                resolutionLabel.Text = "960 x 720";
            else if ((driverIndex == 0 && filterIndex == 4) || (driverIndex == 1 && filterIndex == 4) ||
                (driverIndex == 1 && filterIndex == 11))
                resolutionLabel.Text = "1280 x 960";
            else if ((driverIndex == 0 && filterIndex == 5) || (driverIndex == 1 && filterIndex == 5) ||
                (driverIndex == 1 && filterIndex == 12))
                resolutionLabel.Text = "1600 x 1200";
            else if ((driverIndex == 0 && filterIndex == 6) || (driverIndex == 1 && filterIndex == 6) ||
                (driverIndex == 1 && filterIndex == 13))
                resolutionLabel.Text = "1920 x 1440";
            else if ((driverIndex == 0 && filterIndex == 7) || (driverIndex == 1 && filterIndex == 7) ||
                (driverIndex == 1 && filterIndex == 14))
                resolutionLabel.Text = "2240 x 1680";
            else if ((driverIndex == 0 && filterIndex == 8) || (driverIndex == 1 && filterIndex == 8) ||
                (driverIndex == 1 && filterIndex == 15))
                resolutionLabel.Text = "2560 x 1920";
        }
    }
}
