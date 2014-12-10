namespace Hero6_Launcher
{
    partial class Hero6LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hero6LauncherForm));
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.windowCheckBox = new System.Windows.Forms.CheckBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.resolutionDescriptionLabel = new System.Windows.Forms.Label();
            this.graphicOptionsBox = new System.Windows.Forms.GroupBox();
            this.crtDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.downgradeBitsCheckBox = new System.Windows.Forms.CheckBox();
            this.smoothSpritesCheckBox = new System.Windows.Forms.CheckBox();
            this.verticalBordersCheckBox = new System.Windows.Forms.CheckBox();
            this.horizontalBordersCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.graphicOptionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterComboBox
            // 
            this.filterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(215, 251);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(155, 21);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // driverComboBox
            // 
            this.driverComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(215, 224);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(155, 21);
            this.driverComboBox.TabIndex = 4;
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
            // 
            // windowCheckBox
            // 
            this.windowCheckBox.AutoSize = true;
            this.windowCheckBox.Location = new System.Drawing.Point(215, 278);
            this.windowCheckBox.Name = "windowCheckBox";
            this.windowCheckBox.Size = new System.Drawing.Size(77, 17);
            this.windowCheckBox.TabIndex = 3;
            this.windowCheckBox.Text = "Full screen";
            this.windowCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(16, 263);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(74, 13);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Graphics filter:";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(16, 236);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(81, 13);
            this.driverLabel.TabIndex = 1;
            this.driverLabel.Text = "Graphics driver:";
            // 
            // resolutionDescriptionLabel
            // 
            this.resolutionDescriptionLabel.AutoSize = true;
            this.resolutionDescriptionLabel.Location = new System.Drawing.Point(16, 208);
            this.resolutionDescriptionLabel.Name = "resolutionDescriptionLabel";
            this.resolutionDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.resolutionDescriptionLabel.TabIndex = 0;
            this.resolutionDescriptionLabel.Text = "Resolution:";
            // 
            // graphicOptionsBox
            // 
            this.graphicOptionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicOptionsBox.Controls.Add(this.crtDisplayCheckBox);
            this.graphicOptionsBox.Controls.Add(this.downgradeBitsCheckBox);
            this.graphicOptionsBox.Controls.Add(this.smoothSpritesCheckBox);
            this.graphicOptionsBox.Controls.Add(this.verticalBordersCheckBox);
            this.graphicOptionsBox.Controls.Add(this.horizontalBordersCheckBox);
            this.graphicOptionsBox.Location = new System.Drawing.Point(19, 310);
            this.graphicOptionsBox.Name = "graphicOptionsBox";
            this.graphicOptionsBox.Size = new System.Drawing.Size(351, 138);
            this.graphicOptionsBox.TabIndex = 1;
            this.graphicOptionsBox.TabStop = false;
            this.graphicOptionsBox.Text = "Graphic Options";
            // 
            // crtDisplayCheckBox
            // 
            this.crtDisplayCheckBox.AutoSize = true;
            this.crtDisplayCheckBox.Location = new System.Drawing.Point(7, 113);
            this.crtDisplayCheckBox.Name = "crtDisplayCheckBox";
            this.crtDisplayCheckBox.Size = new System.Drawing.Size(206, 17);
            this.crtDisplayCheckBox.TabIndex = 4;
            this.crtDisplayCheckBox.Text = "Use 85 Hz display (CRT monitors only)";
            this.crtDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // downgradeBitsCheckBox
            // 
            this.downgradeBitsCheckBox.AutoSize = true;
            this.downgradeBitsCheckBox.Location = new System.Drawing.Point(7, 88);
            this.downgradeBitsCheckBox.Name = "downgradeBitsCheckBox";
            this.downgradeBitsCheckBox.Size = new System.Drawing.Size(194, 17);
            this.downgradeBitsCheckBox.TabIndex = 3;
            this.downgradeBitsCheckBox.Text = "Downgrade 32-bit graphics to 16-bit";
            this.downgradeBitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // smoothSpritesCheckBox
            // 
            this.smoothSpritesCheckBox.AutoSize = true;
            this.smoothSpritesCheckBox.Location = new System.Drawing.Point(7, 65);
            this.smoothSpritesCheckBox.Name = "smoothSpritesCheckBox";
            this.smoothSpritesCheckBox.Size = new System.Drawing.Size(204, 17);
            this.smoothSpritesCheckBox.TabIndex = 2;
            this.smoothSpritesCheckBox.Text = "Smooth scaled sprites(fast CPUs only)";
            this.smoothSpritesCheckBox.UseVisualStyleBackColor = true;
            // 
            // verticalBordersCheckBox
            // 
            this.verticalBordersCheckBox.AutoSize = true;
            this.verticalBordersCheckBox.Location = new System.Drawing.Point(7, 42);
            this.verticalBordersCheckBox.Name = "verticalBordersCheckBox";
            this.verticalBordersCheckBox.Size = new System.Drawing.Size(171, 17);
            this.verticalBordersCheckBox.TabIndex = 1;
            this.verticalBordersCheckBox.Text = "Enable top and bottom borders";
            this.verticalBordersCheckBox.UseVisualStyleBackColor = true;
            // 
            // horizontalBordersCheckBox
            // 
            this.horizontalBordersCheckBox.AutoSize = true;
            this.horizontalBordersCheckBox.Location = new System.Drawing.Point(7, 19);
            this.horizontalBordersCheckBox.Name = "horizontalBordersCheckBox";
            this.horizontalBordersCheckBox.Size = new System.Drawing.Size(119, 17);
            this.horizontalBordersCheckBox.TabIndex = 0;
            this.horizontalBordersCheckBox.Text = "Enable side borders";
            this.horizontalBordersCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(130, 454);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playButton.AutoSize = true;
            this.playButton.Location = new System.Drawing.Point(12, 454);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(112, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.AutoSize = true;
            this.quitButton.Location = new System.Drawing.Point(258, 454);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(112, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.resolutionLabel.Location = new System.Drawing.Point(212, 208);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(54, 13);
            this.resolutionLabel.TabIndex = 7;
            this.resolutionLabel.Text = "320 x 240";
            // 
            // Hero6LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 485);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.windowCheckBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.resolutionDescriptionLabel);
            this.Controls.Add(this.graphicOptionsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hero6LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero6 v0.?.? Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.graphicOptionsBox.ResumeLayout(false);
            this.graphicOptionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.CheckBox windowCheckBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label resolutionDescriptionLabel;
        private System.Windows.Forms.GroupBox graphicOptionsBox;
        private System.Windows.Forms.CheckBox crtDisplayCheckBox;
        private System.Windows.Forms.CheckBox downgradeBitsCheckBox;
        private System.Windows.Forms.CheckBox smoothSpritesCheckBox;
        private System.Windows.Forms.CheckBox verticalBordersCheckBox;
        private System.Windows.Forms.CheckBox horizontalBordersCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label resolutionLabel;

    }
}

