using MadLibs.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;

namespace MadLibsGame
{
    public static class FileHelper
    {
        public static string ChosenCategory { get; set; }
        public static int ChosenStoryNumber { get; set; }

        /// <summary>
        /// Read all the files in the story file directory and return category list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<StoryFile> GetCategories()
        {
            
            Regex MetadataRegex = new Regex(@"\{\s*(?:(?:[a-zA-Z0-9]+: .+)\s*)+\}");
            string[] files = Directory.GetFiles(Path.GetFullPath("../../stories"), "*.txt");
            List<StoryFile> categories = new List<StoryFile>();
            foreach(string file in files)
            {
                string fileText = File.ReadAllText(file);
                if (!MetadataRegex.IsMatch(fileText))
                {
                    //Metadata is unreadable or missing from the top of the file
                    continue;
                }
                else
                {
                    string metadataMatch = MetadataRegex.Match(fileText).Value;
                    StoryFile storyFile = new StoryFile();
                    storyFile.FilePath = file;
                    storyFile.Title = Regex.Match(metadataMatch, @"Title: (.+)")?.Groups[1]?.Value.Trim() ?? string.Empty;
                    if (string.IsNullOrEmpty(storyFile.Title))
                    {
                        continue;
                    }
                    storyFile.MadLibsCount = int.Parse(Regex.Match(metadataMatch, @"Number: (.+)")?.Groups[1]?.Value.Trim() ?? "0");
                    if(storyFile.MadLibsCount == 0)
                    {
                        continue;
                    }
                    storyFile.Description = Regex.Match(metadataMatch, @"Description: (.+)")?.Groups[1]?.Value.Trim() ?? string.Empty;
                    storyFile.Year = Regex.Match(metadataMatch, @"Year: (.+)")?.Groups[1]?.Value.Trim() ?? string.Empty;

                    categories.Add(storyFile);
                }
            }
            return categories;
        }

        public static string GetStoryText(string filePath, int storyNumber)
        {
            string fileText = File.ReadAllText(filePath);
            Regex textRegex = new Regex(@"#_" + storyNumber + @"(?<Text>.*?)#!", RegexOptions.Singleline);
            Match textMatch = textRegex.Match(fileText);
            if (textMatch.Success)
            {
                ChosenStoryNumber = storyNumber;
                return textMatch.Groups["Text"].Value;
            }
            else
            {
                throw new Exception("Cannot locate Mad Lib # " + storyNumber + ". Select a different Mad Lib");
            }
        }

        public static void WriteToSavedMadLibsFile(string FilePath, string StoryText, string category, int storyNumber)
        {
            string SaveFileText = "";
            int numStories = 1;
            if (File.Exists(FilePath))
            {
                SaveFileText = File.ReadAllText(FilePath);
                Match NumStoriesMatch = Regex.Match(SaveFileText, @"(?<NumStories>\d+)\s+MadLibs available", RegexOptions.IgnoreCase);
                numStories = 0;
                if (NumStoriesMatch.Success)
                {
                    numStories = int.Parse(NumStoriesMatch.Groups["NumStories"].Value);
                }
                numStories++;
                SaveFileText = SaveFileText.Replace(NumStoriesMatch.Value, numStories + " MadLibs available");
            }
            else
            {
                SaveFileText = "1 MadLibs available";
            }
            string metadata = string.Format("{0} #{1}, {2}", category, storyNumber, DateTime.Now);
            SaveFileText += Environment.NewLine + Environment.NewLine;
            SaveFileText += "#_" + numStories + Environment.NewLine;
            SaveFileText += metadata + Environment.NewLine;
            SaveFileText += StoryText + Environment.NewLine;
            SaveFileText += "#!";
            File.WriteAllText(FilePath, SaveFileText);
        }

        public static int GetNumberOfSavedMadLibs(string filePath)
        {
            
            if (File.Exists(filePath)) {
                string text = File.ReadAllText(filePath);
                Match NumStoriesMatch = Regex.Match(text, @"(?<NumStories>\d+)\s+MadLibs available", RegexOptions.IgnoreCase);
                if (NumStoriesMatch.Success)
                {
                    return int.Parse(NumStoriesMatch.Groups["NumStories"].Value);
                }
            }
                return 0;
        }

        public static SavedMadLib GetSavedMadLib(int selectedNumber)
        {
            var sml = new SavedMadLib();
            string FilePath = MadLibsGameSettings.Default.SavedMadLibsFilePath;
            if (File.Exists(FilePath))
            {
                string fileText = File.ReadAllText(FilePath);
                Match StoryTextMatch = Regex.Match(fileText, @"#_" + selectedNumber + @"\s+(?<MadLibLocation>.*?#\d+), (?<SavedTime>\d{1,2}/\d{1,2}/\d{2,4} \d{1,2}:\d{1,2}:\d{1,2} (?:AM|PM))\s+(?<Text>\{\\rtf1\s+\\par\s+(?<Title>.*?)\\par\s+\\par\s+.*?)#!", RegexOptions.Singleline);
                if (StoryTextMatch.Success)
                {
                    sml.Number = selectedNumber;
                    sml.Location = StoryTextMatch.Groups["MadLibLocation"].Value;
                    sml.SaveTime = StoryTextMatch.Groups["SavedTime"].Value;
                    sml.Title = StoryTextMatch.Groups["Title"].Value;
                    sml.Text = StoryTextMatch.Groups["Text"].Value;
                }
            }

            return sml;
        }
    }
}
