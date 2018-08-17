using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace FileDataTest
{
    [TestClass]
    public class TestFileData
    {
        FileDetails fd;

        [TestMethod]
        public void nullInputRetrunsNull()
        {
            // check for input value to retun null
        }
        [TestMethod]
        public void method_Should_returnFile_Version()
        {
            fd = new FileDetails();
            string fileName = "C:/test.txt";
            var result = fd.Version(fileName);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void method_Should_returnFile_size()
        {
            fd = new FileDetails();
            string fileName = "C:/test.txt";
            var result = fd.Size(fileName);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CommandLine_ArgCheck()
        {
            string[] argVal = Environment.GetCommandLineArgs();
            Assert.AreEqual(11, argVal.Length);
            //Assert.AreEqual<string>("-version", argVal[5] as string);
        }
        [TestMethod]
        public void Check_for_value_exist_in_array()
        {
            string[] strVersion = { "-v", "--v", "/v", "--version" };
            string inputVal = "--version";
            int result = Array.IndexOf(strVersion, inputVal);
            Assert.AreEqual(3, result);
            string negVal = "-ABC";
            int negResult = Array.IndexOf(strVersion, negVal);
            Assert.AreEqual(-1, negResult);         

        }
    }
}
