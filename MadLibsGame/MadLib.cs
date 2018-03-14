using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using MadLibs.Models;

namespace MadLibsGame
{
    public class MadLib
    {
        public string FileText { get; set; }
        public string StoryText { get; set; }
        public string SavedStoryText { get; set; }
        public string SavedFileText { get; set; }
        public string ChosenCategory { get; set; }
        public string ChosenCategoryDisplayName { get; set; }
        public int ChosenStoryNumber { get; set; }
        private MatchCollection wordsToEnter;
        private List<string> UserSuppliedWords;
        private Dictionary<string, string> SameWords;
        public int TotalEntries => wordsToEnter.Count - totalDuplicates;
        public int EntryCount => (UserSuppliedWords.Count() + 1 - duplicateCount);
        public string CurrentWord => wordsToEnter[UserSuppliedWords.Count()].Groups["Entry"].Value;

        private int totalDuplicates { get; set; }
        private int duplicateCount { get; set; }


        /// <summary>
        /// Creates a new Mad Lib object.
        /// </summary>
        /// <param name="storyText">The raw text of the Mad Lib.</param>
        /// <param name="category">the selected category from the dropdown</param>
        /// <param name="number">the selected number from the dropdown</param>
        public MadLib(string storyText, string category, int number)
        {
            this.StoryText = storyText;
            this.ChosenCategory = category;
            this.ChosenStoryNumber = number;
            UserSuppliedWords = new List<string>();
        }

        public void CreateWordList()
        {
            Regex wordsRegex = new Regex(@"\^(?<Entry>.*?)(, (?<Modifier>[|\w]+))?\^");
            wordsToEnter = wordsRegex.Matches(StoryText);

            var duplicates = new List<string>();
            
            foreach(Match match in wordsToEnter)
            {
                var modifiers = match.Groups["Modifier"].Value.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string modifier in modifiers)
                {
                    if (modifier.StartsWith("SW"))
                    {
                        if (duplicates.Contains(modifier))
                        {
                            totalDuplicates++;
                        }
                        else
                        {
                            duplicates.Add(modifier);
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Adds the user supplied word to the list and applies any modifiers.
        /// </summary>
        /// <param name="enteredWord">the word entered by the user</param>
        public void AddWord(string enteredWord)
        {
            var activeModifiers = wordsToEnter[UserSuppliedWords.Count()].Groups["Modifier"].Value.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string activeModifier in activeModifiers)
            {
                //Check for same word modifiers
                if (activeModifier.StartsWith("SW"))
                {
                    if (SameWords == null)
                    {
                        SameWords = new Dictionary<string, string>();
                    }

                    if (!SameWords.ContainsKey(activeModifier))
                    {
                        SameWords.Add(activeModifier, enteredWord);
                    }
                }
                else
                {
                    enteredWord = ApplyModifier(enteredWord, activeModifier);
                }
                
            }
            UserSuppliedWords.Add(enteredWord);
            if (UserSuppliedWords.Count() < wordsToEnter.Count)
            {
                PrepareNextWord();
            }
        }

        private void PrepareNextWord()
        {
            var modifiers = wordsToEnter[UserSuppliedWords.Count()].Groups["Modifier"].Value.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries); ;
            foreach (string modifier in modifiers)
            {
                if (SameWords != null && modifier.StartsWith("SW") && SameWords.ContainsKey(modifier))
                {
                    AddWord(SameWords[modifier]);
                    duplicateCount++;
                    break;
                }
            }
        }

        /// <summary>
        /// Put the user supplied words into the original story text and apply rich text formatting
        /// </summary>
        public void CreateFinishedMadLib()
        {
            //pull in user entries and add them back into the story text
            for (int i = wordsToEnter.Count - 1; i >= 0; i--)
            {
                StoryText = StoryText.Remove(wordsToEnter[i].Index, wordsToEnter[i].Length);
                StoryText = StoryText.Insert(wordsToEnter[i].Index, UserSuppliedWords[i]);
            }

            //Surround story text with RTF opening and closing tags and replace new lines with RTF paragraphs
            //This allows the styled text to display correctly in the application.
            StoryText = @"{\rtf1 " + Regex.Replace(StoryText, @"\r\n", @"\par ") + "}";

        }

        /// <summary>
        /// Saves the completed Mad Lib to a file.
        /// </summary>
        public void SaveMadLib()
        {
            string fullSaveFilePath = new FileInfo(MadLibsGameSettings.Default.SavedMadLibsFilePath).FullName;
            FileHelper.WriteToSavedMadLibsFile(fullSaveFilePath, StoryText, ChosenCategory, ChosenStoryNumber);
        }

        private string ApplyModifier(string word, string modifier)
        {
            switch (modifier)
            {
                case "C":
                    System.Globalization.TextInfo textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;
                    word = textInfo.ToTitleCase(word);
                    break;
                case "CF":
                    word = word.Substring(0, 1).ToUpper() + word.Substring(1);
                    break;
                case "AC":
                    word = word.ToUpper();
                    break;
                case "LC":
                    word = word.ToLower();
                    break;
                case "i":
                    word = @"\i " + word + @"\i0";
                    break;
                case "b":
                    word = @"\b " + word + @"\b0";
                    break;
            }

            return word;
        }
    }
}
