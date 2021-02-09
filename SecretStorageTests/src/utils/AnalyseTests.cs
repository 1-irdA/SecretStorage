﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretStorage.src.utils.Tests
{
    /// <summary>
    /// Test Analyse class
    /// </summary>
    [TestClass()]
    public class AnalyseTests
    {
        /// <summary>
        /// Test AnalyseAndReplace method with 'x'
        /// Uses IndexOf
        /// </summary>
        [TestMethod()]
        public void AnalyseAndReplaceTestWithIndexOfX()
        {
            string toAnalyse = "This x is a string to test x char like xxx";
            string result = Analyse.AnalyseAndReplace(toAnalyse);

            if (result.IndexOf('x') != -1)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test AnalyseAndReplace method with 'x'
        /// Uses CompareTo
        /// </summary>
        [TestMethod()]
        public void AnalyseAndReplaceTestWithCompareToX()
        {
            string toAnalyse = "This x is a string to test x char like xxx";
            string result = Analyse.AnalyseAndReplace(toAnalyse);

            if (result.CompareTo("This * is a string to test * char like ***") != 0)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test AnalyseAndReplace method with ','
        /// Uses IndexOf
        /// </summary>
        [TestMethod()]
        public void AnalyseAndReplaceTestWithIndexOfComma()
        {
            string toAnalyse = "This x is a string to test x char like xxx";
            string result = Analyse.AnalyseAndReplace(toAnalyse);

            if (result.IndexOf('x') != -1)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Test AnalyseAndReplace method with ','
        /// Uses CompareTo
        /// </summary>
        [TestMethod()]
        public void AnalyseAndReplaceTestWithCompareToComma()
        {
            string toAnalyse = "This , is a string to test , char like ,,,";
            string result = Analyse.AnalyseAndReplace(toAnalyse);

            if (result.CompareTo("This . is a string to test . char like ...") != 0)
            {
                Assert.Fail();
            }
        }
    }
}