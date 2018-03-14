using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Threading;
using MadLibs.Models;

namespace MadLibsGame
{
    public partial class MadLibs : Form
    {
        ResourceSet StoryFileNames = FileDisplayNames.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

        private string SavedStoryText;
        private IEnumerable<StoryFile> storyFiles;

        MadLib madLib;

        public MadLibs()
        {
            InitializeComponent();
            LoadCategoriesList();
            PopulateSavedMadLibs();
        }

        private void LoadCategoriesList()
        {
            storyFiles = FileHelper.GetCategories();

            List<string> listItems = new List<string>();
            listItems.Add("--Select a Category--");
            foreach (StoryFile sf in storyFiles)
            {
                listItems.Add(sf.Title);
            }
            CategoryList.DataSource = new BindingSource(listItems, null);
            CategoryList.SelectedIndex = 0;
        }

        private void StartGame()
        {
            WordBox.Enabled = true;
            WordEnterButton.Enabled = true;
            DisplayMadLibButton.Visible = false;
            SaveMadLibButton.Visible = false;
            MadLibDisplayBox.Text = "";
            madLib.CreateWordList();
            WordBox.Focus();
            DisplayNextWord();
        }

        private void DisplayNextWord()
        {
            WordInstructionLabel.Text = "Enter " + madLib.CurrentWord;
            CountLabel.Text = madLib.EntryCount + " of " + madLib.TotalEntries;
            var examples = PartsOfSpeechHelper.RetrieveExampleList(madLib.CurrentWord);

            if (examples.Any())
            {
                WordExamplesLabel.Text = "Examples: ";
                foreach(var example in examples)
                {
                    WordExamplesLabel.Text += example;
                    if (example != examples.Last())
                    {
                        WordExamplesLabel.Text += ", ";
                    }
                }
                ChooseForMeButton.Enabled = true;
            }
            else
            {
                WordExamplesLabel.Text = "No examples available.";
                ChooseForMeButton.Enabled = false;
            }
        }

        private void CreateFinishedMadLib()
        {
            //pull in user entries and add them back into the story text
            madLib.CreateFinishedMadLib();
            DisplayMadLibButton.Visible = true;
            SaveMadLibButton.Visible = true;
            WordBox.Enabled = false;
            WordEnterButton.Enabled = false;
            ChooseForMeButton.Enabled = false;
            WordExamplesLabel.Text = string.Empty;
        }

        private void ResetGame()
        {
            CategoryList.SelectedIndex = 0;
            StoryNumberBox.SelectedIndex = -1;
        }

        private void PopulateSavedMadLibs()
        {
            int numSaved = FileHelper.GetNumberOfSavedMadLibs(MadLibsGameSettings.Default.SavedMadLibsFilePath);
            if (numSaved > 0)
            {
                SavedMadLibBox.Items.Add("Select a Mad Lib");
                for (int i = 1; i <= numSaved; i++)
                {
                    SavedMadLibBox.Items.Add(i);
                }
                SavedMadLibBox.SelectedIndex = 0;
            }
            else
            {
                SavedMadLibBox.Enabled = false;
            }

        }

        private void DisplayAboutInformation()
        {
            MessageBox.Show("Mad Libs Game, Version 1", "About Mad Libs");
        }

        private void DisplayHowToPlayInformation()
        {
            MessageBox.Show("After you select a category and a story on the next screen, " +
            "you will be asked to enter a number of different parts of speech.  In case you " +
            "forgot, here's the official tutorial from the Mad Libs books:\n" +
            "A NOUN, as you know, is the name of a person, place, or thing, such as friend, " +
            "school, or book. Plural means more than one.\n" +
            "An ADJECTIVE is a word that describes a noun, such as sticky, quiet, or jumpy.\n" +
            "A VERB is an action word. It tells what a noun does, such as run, read, or scream.\n" +
            "An ADVERB tells how something is done. It describes a verb and often ends in \"ly.\" " +
            "Easily, bravely, and truthfully are adverbs.", "How To Play Mad Libs");
        }

        #region Event Handlers
        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryList.SelectedIndex > 0)
            {
                StoryNumberBox.Items.Clear();                
                try
                {
                    var selectedStoryFile = storyFiles.Where(x => x.Title == CategoryList.SelectedValue.ToString()).First();
                    int numStories = selectedStoryFile.MadLibsCount;
                    CategoryMetadataLabel.Text = selectedStoryFile.Title + Environment.NewLine + 
                        "Description:" + selectedStoryFile.Description + Environment.NewLine + 
                        "Year:" + selectedStoryFile.Year;
                    StoryNumberBox.Enabled = true;
                    StoryNumberBox.Items.Add("--Select a Mad Lib to do--");
                    for (int i = 1; i <= numStories; i++)
                    {
                        StoryNumberBox.Items.Add(i);
                        StoryNumberBox.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else if (CategoryList.SelectedIndex == 0)
            {
                StoryNumberBox.Items.Clear();
                StoryNumberBox.Enabled = false;
            }
        }

        private void StoryNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StoryNumberBox.SelectedIndex > 0)
            {
                try
                {
                    var selectedStoryFile = storyFiles.Where(x => x.Title == CategoryList.SelectedValue.ToString()).First();

                    madLib = new MadLib(FileHelper.GetStoryText(selectedStoryFile.FilePath, StoryNumberBox.SelectedIndex), selectedStoryFile.Title, StoryNumberBox.SelectedIndex);
                    MadLibsPanel.Visible = false;
                    GamePanel.Visible = true;
                    StartGame();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void EnterWordButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(WordBox.Text))
            {
                madLib.AddWord(WordBox.Text);
                WordBox.Clear();
                WordBox.Focus();

                if (madLib.EntryCount > madLib.TotalEntries)
                {
                    CreateFinishedMadLib();
                    WordInstructionLabel.Text = "Finished. Click the button below to view the finished Mad Lib";
                }
                else
                {
                    WordInstructionLabel.Text = string.Empty;
                    WordExamplesLabel.Text = string.Empty;
                    Thread.Sleep(250);
                    DisplayNextWord();
                }
            }
        }

        private void WordBox_KeyDown(object sender, KeyEventArgs k)
        {

            if (k.KeyCode == Keys.Enter)
            {
                WordEnterButton.PerformClick();
                k.SuppressKeyPress = true;
            }
        }

        private void DisplayMadLibButton_Click(object sender, EventArgs e)
        {
            MadLibDisplayBox.Rtf = madLib.StoryText;
            //MessageBox.Show(StoryText, "Mad Libs Game");
        }

        private void ChooseNewCategoryButton_Click(object sender, EventArgs e)
        {
            ResetGame();
            MadLibsPanel.Visible = true;
            GamePanel.Visible = false;
        }

        #region Menu Items
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAboutInformation();
        }

        private void HowToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayHowToPlayInformation();
        }

        private void startScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = true;
            GamePanel.Visible = false;
            MadLibsPanel.Visible = false;
        }

        private void madLibSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            GamePanel.Visible = false;
            MadLibsPanel.Visible = true;
            ResetGame();
        }

        private void savedMadLibsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            GamePanel.Visible = false;
            MadLibsPanel.Visible = true;
            MadLibGameTabs.SelectedTab = SavedMadLibPage;
        }
        #endregion

        #region Saved Mad Libs
        private void SaveMadLibButton_Click(object sender, EventArgs e)
        {
            try
            {
                madLib.SaveMadLib();
                MessageBox.Show("Mad Lib saved successfully!", "Success");
            }
            catch(Exception)
            {
                MessageBox.Show("There was an issue saving your mad lib.", "Error");
            }
            finally
            {
                SaveMadLibButton.Enabled = false;
            }
        }

        private void SavedMadLibBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = SavedMadLibBox.SelectedIndex;
            if(selected > 0)
            {
                var sml = FileHelper.GetSavedMadLib(SavedMadLibBox.SelectedIndex);
                SavedMadLibInfoLabel.Text =
                "Saved Mad Lib " + selected + ":" + Environment.NewLine +
                     "\"" + sml.Title + "\"" + Environment.NewLine +
                     "Category: " + sml.Location + Environment.NewLine
                     + "Saved: " + sml.SaveTime;

                SavedMadLibDisplayBox.Rtf = sml.Text;
                SavedStoryText = sml.Text;
            }
        }
        #endregion

        #region Start Panel
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            MadLibsPanel.Visible = true;
        }

        private void HowToPlayButton_Click(object sender, EventArgs e)
        {
            DisplayHowToPlayInformation();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            DisplayAboutInformation();
        }
        #endregion

        private void ChooseForMeButton_Click(object sender, EventArgs e)
        {
            WordBox.Text = string.Empty;
            WordBox.Text = PartsOfSpeechHelper.RetrieveSuggestedWord(madLib.CurrentWord);
        }
        #endregion
    }
}
