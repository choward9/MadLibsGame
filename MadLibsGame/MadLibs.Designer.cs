namespace MadLibsGame
{
     partial class MadLibs
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
            this.ChoosePanel = new System.Windows.Forms.Panel();
            this.CategoryMetadataLabel = new System.Windows.Forms.Label();
            this.StoryNumberBox = new System.Windows.Forms.ComboBox();
            this.CategoryList = new System.Windows.Forms.ComboBox();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.HowToPlayButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.MadLibDisplayBox = new System.Windows.Forms.RichTextBox();
            this.WordExamplesLabel = new System.Windows.Forms.Label();
            this.ChooseForMeButton = new System.Windows.Forms.Button();
            this.SaveMadLibButton = new System.Windows.Forms.Button();
            this.WordEnterButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.DisplayMadLibButton = new System.Windows.Forms.Button();
            this.ChooseNewCategoryButton = new System.Windows.Forms.Button();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.WordInstructionLabel = new System.Windows.Forms.Label();
            this.MadLibGameTabs = new System.Windows.Forms.TabControl();
            this.NewMadLibTab = new System.Windows.Forms.TabPage();
            this.SavedMadLibPage = new System.Windows.Forms.TabPage();
            this.SavedMadLibDisplayBox = new System.Windows.Forms.RichTextBox();
            this.SavedMadLibInfoLabel = new System.Windows.Forms.Label();
            this.SavedMadLibBox = new System.Windows.Forms.ComboBox();
            this.SavedTabDescription = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madLibSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedMadLibsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MadLibsPanel = new System.Windows.Forms.Panel();
            this.ChoosePanel.SuspendLayout();
            this.StartPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.MadLibGameTabs.SuspendLayout();
            this.NewMadLibTab.SuspendLayout();
            this.SavedMadLibPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MadLibsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoosePanel
            // 
            this.ChoosePanel.Controls.Add(this.CategoryMetadataLabel);
            this.ChoosePanel.Controls.Add(this.StoryNumberBox);
            this.ChoosePanel.Controls.Add(this.CategoryList);
            this.ChoosePanel.Controls.Add(this.SelectCategoryLabel);
            this.ChoosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoosePanel.Location = new System.Drawing.Point(3, 3);
            this.ChoosePanel.Name = "ChoosePanel";
            this.ChoosePanel.Size = new System.Drawing.Size(629, 532);
            this.ChoosePanel.TabIndex = 1;
            // 
            // CategoryMetadataLabel
            // 
            this.CategoryMetadataLabel.AutoSize = true;
            this.CategoryMetadataLabel.Location = new System.Drawing.Point(270, 119);
            this.CategoryMetadataLabel.MaximumSize = new System.Drawing.Size(370, 0);
            this.CategoryMetadataLabel.Name = "CategoryMetadataLabel";
            this.CategoryMetadataLabel.Size = new System.Drawing.Size(0, 13);
            this.CategoryMetadataLabel.TabIndex = 3;
            // 
            // StoryNumberBox
            // 
            this.StoryNumberBox.Enabled = false;
            this.StoryNumberBox.FormattingEnabled = true;
            this.StoryNumberBox.Location = new System.Drawing.Point(20, 194);
            this.StoryNumberBox.Name = "StoryNumberBox";
            this.StoryNumberBox.Size = new System.Drawing.Size(160, 21);
            this.StoryNumberBox.TabIndex = 2;
            this.StoryNumberBox.SelectedIndexChanged += new System.EventHandler(this.StoryNumberBox_SelectedIndexChanged);
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.IntegralHeight = false;
            this.CategoryList.ItemHeight = 13;
            this.CategoryList.Location = new System.Drawing.Point(20, 122);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(216, 21);
            this.CategoryList.TabIndex = 0;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged);
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategoryLabel.Location = new System.Drawing.Point(148, 41);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(379, 36);
            this.SelectCategoryLabel.TabIndex = 1;
            this.SelectCategoryLabel.Text = "Select a Mad Libs Category";
            this.SelectCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.GameTitleLabel);
            this.StartPanel.Controls.Add(this.AboutButton);
            this.StartPanel.Controls.Add(this.HowToPlayButton);
            this.StartPanel.Controls.Add(this.StartGameButton);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(0, 24);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(643, 564);
            this.StartPanel.TabIndex = 3;
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitleLabel.Location = new System.Drawing.Point(220, 51);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(205, 51);
            this.GameTitleLabel.TabIndex = 5;
            this.GameTitleLabel.Text = "Mad Libs";
            // 
            // AboutButton
            // 
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(229, 423);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(180, 90);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HowToPlayButton
            // 
            this.HowToPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlayButton.Location = new System.Drawing.Point(229, 289);
            this.HowToPlayButton.Name = "HowToPlayButton";
            this.HowToPlayButton.Size = new System.Drawing.Size(180, 90);
            this.HowToPlayButton.TabIndex = 3;
            this.HowToPlayButton.Text = "How To Play";
            this.HowToPlayButton.UseVisualStyleBackColor = true;
            this.HowToPlayButton.Click += new System.EventHandler(this.HowToPlayButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(229, 150);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(180, 90);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.MadLibDisplayBox);
            this.GamePanel.Controls.Add(this.WordExamplesLabel);
            this.GamePanel.Controls.Add(this.ChooseForMeButton);
            this.GamePanel.Controls.Add(this.SaveMadLibButton);
            this.GamePanel.Controls.Add(this.WordEnterButton);
            this.GamePanel.Controls.Add(this.CountLabel);
            this.GamePanel.Controls.Add(this.DisplayMadLibButton);
            this.GamePanel.Controls.Add(this.ChooseNewCategoryButton);
            this.GamePanel.Controls.Add(this.WordBox);
            this.GamePanel.Controls.Add(this.WordInstructionLabel);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 24);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(643, 564);
            this.GamePanel.TabIndex = 3;
            this.GamePanel.Visible = false;
            // 
            // MadLibDisplayBox
            // 
            this.MadLibDisplayBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MadLibDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MadLibDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadLibDisplayBox.Location = new System.Drawing.Point(12, 326);
            this.MadLibDisplayBox.Name = "MadLibDisplayBox";
            this.MadLibDisplayBox.ReadOnly = true;
            this.MadLibDisplayBox.Size = new System.Drawing.Size(619, 226);
            this.MadLibDisplayBox.TabIndex = 9;
            this.MadLibDisplayBox.Text = "";
            // 
            // WordExamplesLabel
            // 
            this.WordExamplesLabel.AutoSize = true;
            this.WordExamplesLabel.Location = new System.Drawing.Point(387, 38);
            this.WordExamplesLabel.MaximumSize = new System.Drawing.Size(175, 0);
            this.WordExamplesLabel.Name = "WordExamplesLabel";
            this.WordExamplesLabel.Size = new System.Drawing.Size(55, 13);
            this.WordExamplesLabel.TabIndex = 8;
            this.WordExamplesLabel.Text = "Examples:";
            // 
            // ChooseForMeButton
            // 
            this.ChooseForMeButton.Enabled = false;
            this.ChooseForMeButton.Location = new System.Drawing.Point(499, 95);
            this.ChooseForMeButton.Name = "ChooseForMeButton";
            this.ChooseForMeButton.Size = new System.Drawing.Size(93, 39);
            this.ChooseForMeButton.TabIndex = 7;
            this.ChooseForMeButton.Text = "Give Me a Word";
            this.ChooseForMeButton.UseVisualStyleBackColor = true;
            this.ChooseForMeButton.Click += new System.EventHandler(this.ChooseForMeButton_Click);
            // 
            // SaveMadLibButton
            // 
            this.SaveMadLibButton.Location = new System.Drawing.Point(451, 198);
            this.SaveMadLibButton.Name = "SaveMadLibButton";
            this.SaveMadLibButton.Size = new System.Drawing.Size(180, 90);
            this.SaveMadLibButton.TabIndex = 6;
            this.SaveMadLibButton.Text = "Save Mad Lib";
            this.SaveMadLibButton.UseVisualStyleBackColor = true;
            this.SaveMadLibButton.Visible = false;
            this.SaveMadLibButton.Click += new System.EventHandler(this.SaveMadLibButton_Click);
            // 
            // WordEnterButton
            // 
            this.WordEnterButton.Location = new System.Drawing.Point(390, 95);
            this.WordEnterButton.Name = "WordEnterButton";
            this.WordEnterButton.Size = new System.Drawing.Size(77, 39);
            this.WordEnterButton.TabIndex = 5;
            this.WordEnterButton.TabStop = false;
            this.WordEnterButton.Text = "Enter";
            this.WordEnterButton.UseVisualStyleBackColor = true;
            this.WordEnterButton.Click += new System.EventHandler(this.EnterWordButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(273, 161);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(65, 24);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "0 of 15";
            // 
            // DisplayMadLibButton
            // 
            this.DisplayMadLibButton.Location = new System.Drawing.Point(229, 198);
            this.DisplayMadLibButton.Name = "DisplayMadLibButton";
            this.DisplayMadLibButton.Size = new System.Drawing.Size(180, 90);
            this.DisplayMadLibButton.TabIndex = 3;
            this.DisplayMadLibButton.Text = "View Mad Lib";
            this.DisplayMadLibButton.UseVisualStyleBackColor = true;
            this.DisplayMadLibButton.Visible = false;
            this.DisplayMadLibButton.Click += new System.EventHandler(this.DisplayMadLibButton_Click);
            // 
            // ChooseNewCategoryButton
            // 
            this.ChooseNewCategoryButton.Location = new System.Drawing.Point(12, 198);
            this.ChooseNewCategoryButton.Name = "ChooseNewCategoryButton";
            this.ChooseNewCategoryButton.Size = new System.Drawing.Size(180, 90);
            this.ChooseNewCategoryButton.TabIndex = 2;
            this.ChooseNewCategoryButton.Text = "New Mad Lib";
            this.ChooseNewCategoryButton.UseVisualStyleBackColor = true;
            this.ChooseNewCategoryButton.Click += new System.EventHandler(this.ChooseNewCategoryButton_Click);
            // 
            // WordBox
            // 
            this.WordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordBox.Location = new System.Drawing.Point(48, 105);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(290, 32);
            this.WordBox.TabIndex = 1;
            this.WordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordBox_KeyDown);
            // 
            // WordInstructionLabel
            // 
            this.WordInstructionLabel.AutoSize = true;
            this.WordInstructionLabel.Location = new System.Drawing.Point(45, 40);
            this.WordInstructionLabel.MaximumSize = new System.Drawing.Size(175, 0);
            this.WordInstructionLabel.Name = "WordInstructionLabel";
            this.WordInstructionLabel.Size = new System.Drawing.Size(112, 13);
            this.WordInstructionLabel.TabIndex = 0;
            this.WordInstructionLabel.Text = "Enter the words below";
            // 
            // MadLibGameTabs
            // 
            this.MadLibGameTabs.Controls.Add(this.NewMadLibTab);
            this.MadLibGameTabs.Controls.Add(this.SavedMadLibPage);
            this.MadLibGameTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MadLibGameTabs.Location = new System.Drawing.Point(0, 0);
            this.MadLibGameTabs.Name = "MadLibGameTabs";
            this.MadLibGameTabs.SelectedIndex = 0;
            this.MadLibGameTabs.Size = new System.Drawing.Size(643, 564);
            this.MadLibGameTabs.TabIndex = 3;
            // 
            // NewMadLibTab
            // 
            this.NewMadLibTab.Controls.Add(this.ChoosePanel);
            this.NewMadLibTab.Location = new System.Drawing.Point(4, 22);
            this.NewMadLibTab.Name = "NewMadLibTab";
            this.NewMadLibTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewMadLibTab.Size = new System.Drawing.Size(635, 538);
            this.NewMadLibTab.TabIndex = 0;
            this.NewMadLibTab.Text = "New Mad Lib";
            this.NewMadLibTab.UseVisualStyleBackColor = true;
            // 
            // SavedMadLibPage
            // 
            this.SavedMadLibPage.Controls.Add(this.SavedMadLibDisplayBox);
            this.SavedMadLibPage.Controls.Add(this.SavedMadLibInfoLabel);
            this.SavedMadLibPage.Controls.Add(this.SavedMadLibBox);
            this.SavedMadLibPage.Controls.Add(this.SavedTabDescription);
            this.SavedMadLibPage.Location = new System.Drawing.Point(4, 22);
            this.SavedMadLibPage.Name = "SavedMadLibPage";
            this.SavedMadLibPage.Padding = new System.Windows.Forms.Padding(3);
            this.SavedMadLibPage.Size = new System.Drawing.Size(635, 538);
            this.SavedMadLibPage.TabIndex = 1;
            this.SavedMadLibPage.Text = "Saved Mad Libs";
            this.SavedMadLibPage.UseVisualStyleBackColor = true;
            // 
            // SavedMadLibDisplayBox
            // 
            this.SavedMadLibDisplayBox.BackColor = System.Drawing.SystemColors.Window;
            this.SavedMadLibDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavedMadLibDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedMadLibDisplayBox.Location = new System.Drawing.Point(17, 216);
            this.SavedMadLibDisplayBox.Name = "SavedMadLibDisplayBox";
            this.SavedMadLibDisplayBox.ReadOnly = true;
            this.SavedMadLibDisplayBox.Size = new System.Drawing.Size(597, 300);
            this.SavedMadLibDisplayBox.TabIndex = 4;
            this.SavedMadLibDisplayBox.Text = "";
            // 
            // SavedMadLibInfoLabel
            // 
            this.SavedMadLibInfoLabel.AutoSize = true;
            this.SavedMadLibInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedMadLibInfoLabel.Location = new System.Drawing.Point(222, 118);
            this.SavedMadLibInfoLabel.MaximumSize = new System.Drawing.Size(340, 0);
            this.SavedMadLibInfoLabel.Name = "SavedMadLibInfoLabel";
            this.SavedMadLibInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.SavedMadLibInfoLabel.TabIndex = 2;
            // 
            // SavedMadLibBox
            // 
            this.SavedMadLibBox.FormattingEnabled = true;
            this.SavedMadLibBox.Location = new System.Drawing.Point(17, 128);
            this.SavedMadLibBox.Name = "SavedMadLibBox";
            this.SavedMadLibBox.Size = new System.Drawing.Size(122, 21);
            this.SavedMadLibBox.TabIndex = 1;
            this.SavedMadLibBox.SelectedIndexChanged += new System.EventHandler(this.SavedMadLibBox_SelectedIndexChanged);
            // 
            // SavedTabDescription
            // 
            this.SavedTabDescription.AutoSize = true;
            this.SavedTabDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedTabDescription.Location = new System.Drawing.Point(20, 34);
            this.SavedTabDescription.Name = "SavedTabDescription";
            this.SavedTabDescription.Size = new System.Drawing.Size(303, 17);
            this.SavedTabDescription.TabIndex = 0;
            this.SavedTabDescription.Text = "You can view any Mad Libs you\'ve saved here.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startScreenToolStripMenuItem,
            this.madLibSelectToolStripMenuItem,
            this.savedMadLibsToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMenuItem.Text = "View";
            // 
            // startScreenToolStripMenuItem
            // 
            this.startScreenToolStripMenuItem.Name = "startScreenToolStripMenuItem";
            this.startScreenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.startScreenToolStripMenuItem.Text = "Start Screen";
            this.startScreenToolStripMenuItem.Click += new System.EventHandler(this.startScreenToolStripMenuItem_Click);
            // 
            // madLibSelectToolStripMenuItem
            // 
            this.madLibSelectToolStripMenuItem.Name = "madLibSelectToolStripMenuItem";
            this.madLibSelectToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.madLibSelectToolStripMenuItem.Text = "Mad Lib Select";
            this.madLibSelectToolStripMenuItem.Click += new System.EventHandler(this.madLibSelectToolStripMenuItem_Click);
            // 
            // savedMadLibsToolStripMenuItem
            // 
            this.savedMadLibsToolStripMenuItem.Name = "savedMadLibsToolStripMenuItem";
            this.savedMadLibsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.savedMadLibsToolStripMenuItem.Text = "Saved Mad Libs";
            this.savedMadLibsToolStripMenuItem.Click += new System.EventHandler(this.savedMadLibsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToPlayToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // HowToPlayToolStripMenuItem
            // 
            this.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem";
            this.HowToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.HowToPlayToolStripMenuItem.Text = "How to Play";
            this.HowToPlayToolStripMenuItem.Click += new System.EventHandler(this.HowToPlayToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MadLibsPanel
            // 
            this.MadLibsPanel.Controls.Add(this.MadLibGameTabs);
            this.MadLibsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MadLibsPanel.Location = new System.Drawing.Point(0, 24);
            this.MadLibsPanel.Name = "MadLibsPanel";
            this.MadLibsPanel.Size = new System.Drawing.Size(643, 564);
            this.MadLibsPanel.TabIndex = 6;
            this.MadLibsPanel.Visible = false;
            // 
            // MadLibs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 588);
            this.Controls.Add(this.MadLibsPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MadLibs";
            this.Text = "Mad Libs";
            this.ChoosePanel.ResumeLayout(false);
            this.ChoosePanel.PerformLayout();
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.MadLibGameTabs.ResumeLayout(false);
            this.NewMadLibTab.ResumeLayout(false);
            this.SavedMadLibPage.ResumeLayout(false);
            this.SavedMadLibPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MadLibsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Panel ChoosePanel;
          private System.Windows.Forms.ComboBox CategoryList;
          private System.Windows.Forms.Label SelectCategoryLabel;
          private System.Windows.Forms.ComboBox StoryNumberBox;
          private System.Windows.Forms.Panel GamePanel;
          private System.Windows.Forms.Label WordInstructionLabel;
          private System.Windows.Forms.Button DisplayMadLibButton;
          private System.Windows.Forms.Button ChooseNewCategoryButton;
          private System.Windows.Forms.TextBox WordBox;
          private System.Windows.Forms.Label CountLabel;
          private System.Windows.Forms.Button WordEnterButton;
          private System.Windows.Forms.TabControl MadLibGameTabs;
          private System.Windows.Forms.TabPage NewMadLibTab;
          private System.Windows.Forms.TabPage SavedMadLibPage;
          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
          private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
          private System.Windows.Forms.Button SaveMadLibButton;
          private System.Windows.Forms.Label SavedTabDescription;
          private System.Windows.Forms.ComboBox SavedMadLibBox;
          private System.Windows.Forms.Label SavedMadLibInfoLabel;
          private System.Windows.Forms.Panel StartPanel;
          private System.Windows.Forms.Button AboutButton;
          private System.Windows.Forms.Button HowToPlayButton;
          private System.Windows.Forms.Button StartGameButton;
          private System.Windows.Forms.Label GameTitleLabel;
          private System.Windows.Forms.Panel MadLibsPanel;
          private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem HowToPlayToolStripMenuItem;
          private System.Windows.Forms.Label WordExamplesLabel;
          private System.Windows.Forms.Button ChooseForMeButton;
          private System.Windows.Forms.ToolStripMenuItem startScreenToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem madLibSelectToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem savedMadLibsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox MadLibDisplayBox;
        private System.Windows.Forms.Label CategoryMetadataLabel;
        private System.Windows.Forms.RichTextBox SavedMadLibDisplayBox;
    }
}

