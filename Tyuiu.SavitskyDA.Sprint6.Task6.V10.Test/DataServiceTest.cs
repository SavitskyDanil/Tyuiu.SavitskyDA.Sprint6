using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.SavitskyDA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.SavitskyDA.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V10.txt";

            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = " nXkwQYzgZ LlckTwkpaAGTvLPc";
            Assert.AreEqual(wait, res);
        }
    }
}
