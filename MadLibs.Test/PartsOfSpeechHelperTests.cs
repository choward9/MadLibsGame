using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadLibsGame;
using System.Linq;
using System.Collections.Generic;

namespace MadLibs.Test
{
    [TestClass]
    public class PartsOfSpeechHelperTests
    {
        [TestMethod]
        public void RetrieveExampleListTest()
        {
            var examples = PartsOfSpeechHelper.RetrieveExampleList("a noun").ToList();

            CollectionAssert.DoesNotContain(examples, string.Empty);
        }

        [TestMethod]
        public void RetrieveExampleList_InvalidPartOfSpeechTest()
        {
            var expected = new List<string>() { string.Empty, string.Empty, string.Empty };
            var examples = PartsOfSpeechHelper.RetrieveExampleList("not a word").ToList();

            CollectionAssert.AreEqual(expected, examples);
        }

        [TestMethod]
        public void RetrieveSuggestedWordTest()
        {
            var word = PartsOfSpeechHelper.RetrieveSuggestedWord("a noun");

            Assert.AreNotEqual(string.Empty, word);
        }

        [TestMethod]
        public void RetrieveSuggestedWord_InvalidPartOfSpeechTest()
        {
            var word = PartsOfSpeechHelper.RetrieveSuggestedWord("not a word");

            Assert.AreEqual(string.Empty, word);
        }
    }
}
