using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tests
{
    [TestClass()]
    public class SharedLogicTests
    {
        SharedLogic sharedlogic = new SharedLogic();
        [TestMethod()]
        public void countNumberofWordsTest()
        {
            string result = string.Empty;
            long count=0;
            string sentence = "Hi How Are You?";
            result= sharedlogic.countNumberofWords(sentence, ref count);
            Assert.IsNotNull(result, "Test is passed");
            Assert.IsTrue(result.Length>0, "Test is passed");
            Assert.IsTrue(count>0, "Test is passed");
        }
    }
}