using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MadLibsGame;

namespace MadLibs.Test
{
    /// <summary>
    /// Summary description for FileHelperTests
    /// </summary>
    [TestClass]
    public class FileHelperTests
    {
        public TestContext TestContext { get; set; }
        const string File_Name = "StoryTestFile.txt";
        const string SavedMadLibs_File_Name = "SavedMadLibsTestFile.txt";


        [DeploymentItem(File_Name)]
        [TestMethod]
        public void GetStoryTextTest()
        {
            string fileText = string.Empty;

            fileText = FileHelper.GetStoryText(TestContext.DeploymentDirectory + @"\" + File_Name, 1);

            //test if story text can be read with a valid number
            Assert.IsFalse(string.IsNullOrEmpty(fileText));
        }

        /// <summary>
        /// Test if an exception is raised when a story number is passed in that doesn't exist in the file
        /// </summary>
        [DeploymentItem(File_Name)]
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetStoryText_InvalidNumberTest()
        {
            string fileText = string.Empty;

            fileText = FileHelper.GetStoryText(TestContext.DeploymentDirectory + @"\" + File_Name, 999);
        }

        /// <summary>
        /// Test if writing to the saved mad libs file works correctly.
        /// </summary>
        [DeploymentItem(SavedMadLibs_File_Name)]
        [TestMethod]
        public void WriteToSavedMadLibsFileTest()
        {
            FileHelper.WriteToSavedMadLibsFile(TestContext.DeploymentDirectory + @"\" + SavedMadLibs_File_Name, "test", "Unit Test Mad Libs", 17);
        }

        /// <summary>
        /// Test if the number of saved Mad Libs can be retrieved from the save file
        /// </summary>
        [DeploymentItem(SavedMadLibs_File_Name)]
        [TestMethod]
        public void GetNumberOfSavedMadLibsTest()
        {
            int num = 0;

            num = FileHelper.GetNumberOfSavedMadLibs(TestContext.DeploymentDirectory + @"\" + SavedMadLibs_File_Name);

            Assert.AreNotEqual(0, num);
        }
    }
}
