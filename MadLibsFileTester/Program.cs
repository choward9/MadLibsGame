using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MadLibsFileTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "y";
            do
            {
                string folderPath = args[0];
                string type = string.Empty;
                string specificTest = string.Empty;
                if (args.Count() > 1)
                {
                    type = args[1];
                }
                if (args.Count() > 2)
                {
                    specificTest = args[2];
                }

                Regex storyRegex = new Regex(@"#_(?<Number>\d+)(?<Text>.*?)#!", RegexOptions.Singleline);
                var files = Directory.GetFiles(folderPath, "*.txt", SearchOption.AllDirectories);

                List<string> errors = new List<string>();

                if (!files.Any())
                {
                    Console.WriteLine($"No txt files found in {folderPath}");
                    return;
                }
                if (specificTest == "-psc")
                {
                    Dictionary<string, int> partsOfSpeech = new Dictionary<string, int>();
                    Regex wordsRegex = new Regex(@"\^(?<Entry>.*?)(, (?<Modifier>[|\w]+))?\^");
                    foreach (var file in files)
                    {
                        string fileText = File.ReadAllText(file);
                        MatchCollection wordsCollection = wordsRegex.Matches(fileText);
                        foreach (Match match in wordsCollection)
                        {
                            var cleanedWord = match.Groups["Entry"].Value;
                            if (!cleanedWord.StartsWith("something"))
                            {
                                Regex firstWordRegex = new Regex(@"^(?:the same|the title|a|an|another|the) ");
                                cleanedWord = firstWordRegex.Replace(cleanedWord, "");
                                cleanedWord = cleanedWord.Replace("type of ", string.Empty);
                                cleanedWord = cleanedWord.Replace("kind of ", string.Empty);
                            }
                            if (partsOfSpeech.ContainsKey(cleanedWord))
                            {
                                partsOfSpeech[cleanedWord] = (partsOfSpeech[cleanedWord] + 1);
                            }
                            else
                            {
                                partsOfSpeech.Add(cleanedWord, 1);
                            }
                        }
                    }
                    var finalList = partsOfSpeech.OrderByDescending(x => x.Value);
                    var fileOutput = string.Empty;
                    foreach (var item in finalList)
                    {
                        fileOutput += item.Key + ": " + item.Value + Environment.NewLine;
                    }
                    File.WriteAllText("../../test-results.txt", fileOutput);
                    return;
                }
                foreach (var file in files)
                {
                    var storyText = File.ReadAllText(file);
                    var fileName = new FileInfo(file).Name;
                    MatchCollection stories = storyRegex.Matches(storyText);
                    if (stories.Count > 0)
                    {
                        Console.WriteLine($"Checking carots in {fileName}...");
                        foreach (Match story in stories)
                        {
                            if (!CheckCarots(story.Groups["Text"].Value))
                            {
                                errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} has an odd number of carots.");
                            }
                        }

                        Console.WriteLine($"Checking instances where a should be a/an in {fileName}...");
                        foreach (Match story in stories)
                        {
                            if (!CheckASlashAn(story.Groups["Text"].Value))
                            {
                                errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} should have a/an instead of a.");
                            }
                        }

                        Console.WriteLine($"Checking beginning of words in {fileName}...");
                        foreach (Match story in stories)
                        {
                            string invalidWord;
                            if (!CheckBeginningOfWords(story.Groups["Text"].Value, out invalidWord))
                            {
                                errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} has an invalid starting word in entry \"{invalidWord}\".");
                            }
                        }
                        if (type == "-nm")
                        {
                            Console.WriteLine($"Checking modifiers in {fileName}...");
                            foreach (Match story in stories)
                            {
                                if (!CheckModifiersInNoModifierFile(story.Groups["Text"].Value))
                                {
                                    errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} has parts of speech modifier characters.");
                                }
                            }

                            Console.WriteLine($"Checking rtf in {fileName}...");
                            foreach (Match story in stories)
                            {
                                if (!CheckRTFInNoRTFFile(story.Groups["Text"].Value))
                                {
                                    errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} has rtf characters.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Checking for capitalization modifiers in {fileName}...");
                            foreach (Match story in stories)
                            {
                                string invalidWord;
                                if (!CheckCapitalizationModifiers(story.Groups["Text"].Value, out invalidWord))
                                {
                                    errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} has entry \"{invalidWord}\" that is missing a capitalization modifier.");
                                }
                            }

                            Console.WriteLine($"Checking for incorrect rtf slashes in {fileName}...");
                            foreach (Match story in stories)
                            {
                                if (!HasCorrectRTFSlashes(story.Groups["Text"].Value))
                                {
                                    errors.Add($"Mad Lib #{story.Groups["Number"].Value} in file {fileName} has the wrong rtf slashes.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Story regex did not match for file {file}.");
                    }
                }

                if (errors.Any())
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"There were {errors.Count()} errors...");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"No errors were found in specified set of files.");
                }
                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
                Console.Write("Rerun test (y/n)?: ");
                input = Console.ReadLine();
            } while (input == "y");
        }

        protected static bool CheckCarots(string story)
        {
            int count = 0;
            foreach(var c in story)
            {
                if(c == '^')
                {
                    count++;
                }
            }
            return count % 2 == 0;
        }

        protected static bool CheckASlashAn(string story)
        {
            Regex aSlashAnRegex = new Regex(@" a \^.+?\^", RegexOptions.IgnoreCase);
            MatchCollection matches = aSlashAnRegex.Matches(story);

            return matches.Count == 0;
        }

        protected static bool CheckModifiersInNoModifierFile(string story)
        {
            Regex modifierRegex = new Regex(@"\^.+?, [a-zA-Z0-9]+\^");
            MatchCollection matches = modifierRegex.Matches(story);

            return matches.Count == 0;
        }

        protected static bool CheckRTFInNoRTFFile(string story)
        {
            Regex rtfRegex = new Regex(@"\\i|\\i0|\\b|\\b0|\\bullet");
            MatchCollection matches = rtfRegex.Matches(story);

            return matches.Count == 0;
        }

        protected static bool CheckBeginningOfWords(string story, out string invalidEntry)
        {
            Regex wordsRegex = new Regex(@"\^(?<Entry>.*?)(, (?<Modifier>[|\w]+))?\^");
            MatchCollection matches = wordsRegex.Matches(story);
            bool hasInvalidStart = false;
            invalidEntry = string.Empty;
            foreach(Match match in matches)
            {
                if(!Regex.IsMatch(match.Groups["Entry"].Value, @"(?:a|an|something|another|the|two|three) .+"))
                {
                    invalidEntry = match.Groups["Entry"].Value;
                    hasInvalidStart = true;
                    break;
                }
            }
            return !hasInvalidStart;
        }

        protected static bool HasCorrectRTFSlashes(string story)
        {
            Regex rtfSlashRegex = new Regex(@"/i0|/b0|/i|/b");
            return !rtfSlashRegex.IsMatch(story);
        }
        //ToDo: get all words, using word regex above and remove first word
        //loop through and test to see modifier is correct (C or AC)
        protected static bool CheckCapitalizationModifiers(string story, out string invalidEntry)
        {
            Regex wordsRegex = new Regex(@"\^(?<Entry>.*?)(, (?<Modifier>[|\w]+))?\^");
            MatchCollection matches = wordsRegex.Matches(story);
            bool isValid = true;
            invalidEntry = string.Empty;
            foreach(Match match in matches)
            {
                var cleanedWord = match.Groups["Entry"].Value;
                cleanedWord = StripBeginningOfEntry(cleanedWord);
                Regex captRegex = new Regex(@"^(?:city|town|country|first name|last name|celebrity|female celebrity|male celebrity|name of a person in the room|name of a girl in the room|name of a boy in the room|famous person|actor|person's name)");
                if (captRegex.IsMatch(cleanedWord))
                {
                    //isvalid
                    string modifier = match.Groups["Modifier"].Value;
                    if(!Regex.IsMatch(modifier, @"^(?:SW\d+\|)?C|AC|LC$")){
                        isValid = false;
                        invalidEntry = match.Groups["Entry"].Value;
                    }
                }
            }

            return isValid;
        }

        #region Private Methods
        private static string StripBeginningOfEntry(string entry)
        {
            if (!entry.StartsWith("something"))
            {
                Regex firstWordRegex = new Regex(@"^(?:the same|the title|a|an|another|the) ");
                entry = firstWordRegex.Replace(entry, "");
                entry = entry.Replace("type of ", string.Empty);
                entry = entry.Replace("kind of ", string.Empty);
            }
            return entry;
        }
        #endregion
    }
}
