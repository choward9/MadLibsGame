using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadLibsGame;

namespace MadLibs.Test
{
    [TestClass]
    public class MadLibTest
    {
        [TestMethod]
        public void NextWordTest()
        {
            MadLib madLib = new MadLib("test ^an adjective^ Mad Lib ^a noun^", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("test1");

            Assert.AreEqual("a noun", madLib.CurrentWord);
        }

        [TestMethod]
        public void SpecialCharacterTest()
        {
            MadLib madLib = new MadLib("test ^an adjective^ Mad Lib ^a noun^", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("test1");
            madLib.AddWord("e^2");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 test test1 Mad Lib e^2}", madLib.StoryText);
        }

        [TestMethod]
        public void AllCapsModifierTest()
        {
            MadLib madLib = new MadLib("This is a/an ^an adjective, AC^ Mad Lib.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("test1");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 This is a/an TEST1 Mad Lib.}", madLib.StoryText);
        }

        [TestMethod]
        public void CapitalizationModifierTest()
        {
            MadLib madLib = new MadLib("This is a/an ^an adjective, C^ Mad Lib.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("really cool");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 This is a/an Really Cool Mad Lib.}", madLib.StoryText);
        }

        [TestMethod]
        public void CapitalizeFirstWordModifierTest()
        {
            MadLib madLib = new MadLib("^a plural noun, CF^ are really cool.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("desk lamps");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 Desk lamps are really cool.}", madLib.StoryText);
        }

        [TestMethod]
        public void LowercaseModifierTest()
        {
            MadLib madLib = new MadLib("^a plural noun, LC^ are really cool. I certainly ^a verb, LC^ so.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("Words");
            madLib.AddWord("hope");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 words are really cool. I certainly hope so.}", madLib.StoryText);
        }

        [TestMethod]
        public void MultipleModifierTest()
        {
            MadLib madLib = new MadLib("This is a/an ^an adjective, SW1|AC^ Mad Lib.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("test1");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 This is a/an TEST1 Mad Lib.}", madLib.StoryText);
        }

        [TestMethod]
        public void InvalidModifierTest()
        {
            MadLib madLib = new MadLib("This is a/an ^an adjective, XYZ^ Mad Lib.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("interesting");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 This is a/an interesting Mad Lib.}", madLib.StoryText);
        }

        [TestMethod]
        public void SameWordTest()
        {
            MadLib madLib = new MadLib("This is a ^an adjective, SW1^ test of the ^a noun, SW2^. I expect this ^an adjective, SW1^ test to go well for the ^a noun, SW2^.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("quick");
            madLib.AddWord("application");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 This is a quick test of the application. I expect this quick test to go well for the application.}", madLib.StoryText);
        }

        [TestMethod]
        public void SameWordDifferentModifiersTest()
        {
            MadLib madLib = new MadLib("This is a/an ^an adjective, SW1|AC^ test of the ^an adjective, SW1|C^ application.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("quick");
            madLib.CreateFinishedMadLib();

            Assert.AreEqual(@"{\rtf1 This is a/an QUICK test of the Quick application.}", madLib.StoryText);

        }

        [TestMethod]
        public void SameWordEntryCountTest()
        {
            MadLib madLib = new MadLib("This is a ^an adjective, SW1^ test of the ^a noun, SW2^. I expect this ^an adjective, SW1^ test to go well for the ^a noun, SW2^ ^an adverb^.", "Test Mad Libs", 22);
            madLib.CreateWordList();

            madLib.AddWord("quick");
            madLib.AddWord("application");

            Assert.AreEqual(3, madLib.EntryCount);
            Assert.AreEqual(3, madLib.TotalEntries);
        }
    }
}
