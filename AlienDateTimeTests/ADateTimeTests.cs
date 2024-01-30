using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlienDateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienDateTime.Tests
{
    [TestClass()]
    public class ADateTimeTests
    {

        [TestMethod()]
        public void ConvertToAlienClockTest()
        {
            List<bool> testResult = new List<bool>();

            AlienDateTime.ADateTime testData = new ADateTime();
            string aDateTimeStr = testData.ConvertToAlienClock(new DateTime(1970, 1, 1, 12, 0, 0)).ToString();
            testResult.Add(aDateTimeStr == "2804-18-31 2:2:88");

            aDateTimeStr = testData.ConvertToAlienClock(new DateTime(1970, 1, 1, 12, 0, 1)).ToString();
            testResult.Add(aDateTimeStr == "2804-18-31 2:3:0");

            aDateTimeStr = testData.ConvertToAlienClock(new DateTime(1970, 1, 1, 12, 1, 1)).ToString();
            testResult.Add(aDateTimeStr == "2804-18-31 2:4:30");

            aDateTimeStr = testData.ConvertToAlienClock(new DateTime(1970, 1, 2, 12, 1, 1)).ToString();
            testResult.Add(aDateTimeStr == "2804-18-31 23:34:30");

            aDateTimeStr = testData.ConvertToAlienClock(new DateTime(1970, 1, 3, 12, 1, 1)).ToString();
            testResult.Add(aDateTimeStr == "2804-18-32 8:64:30");

            aDateTimeStr = testData.ConvertToAlienClock(new DateTime(2005, 8, 1, 6, 1, 1)).ToString();
            testResult.Add(aDateTimeStr == "2814-18-32 8:64:30");

            aDateTimeStr = testData.ConvertToAlienClock(new DateTime(2024, 1, 29, 12, 1, 1)).ToString();
            testResult.Add(aDateTimeStr == "2820-4-13 12:64:30");

            int testOk = 0;
            testResult.ForEach(x => { if (x) testOk++; });
            Assert.IsTrue(testOk == testResult.Count);
        }

        [TestMethod()]
        public void ToEarthTimeTest()
        {
            List<bool> testResult = new List<bool>();

            AlienDateTime.ADateTime testData = new ADateTime();
            DateTime dt = new DateTime(1970, 1, 1, 12, 0, 0);
            testData = new ADateTime(2804, 18, 31, 2, 2, 88);
            testResult.Add(dt == testData.ToEarthTime());

            dt = new DateTime(1970, 1, 1, 12, 0, 1);
            testData = new ADateTime(2804, 18, 31, 2, 3, 0);
            testResult.Add(dt == testData.ToEarthTime());

            dt = new DateTime(1970, 1, 1, 12, 1, 1);
            testData = new ADateTime(2804, 18, 31, 2, 4, 30);
            testResult.Add(dt == testData.ToEarthTime());

            dt = new DateTime(1970, 1, 2, 12, 1, 1);
            testData = new ADateTime(2804, 18, 31, 23, 34, 30);
            testResult.Add(dt == testData.ToEarthTime());

            dt = new DateTime(1970, 1, 3, 12, 1, 1);
            testData = new ADateTime(2804, 18, 32, 8, 64, 30);
            testResult.Add(dt == testData.ToEarthTime());

            dt = new DateTime(2005, 8, 1, 6, 1, 1);
            testData = new ADateTime(2814, 18, 32, 8, 64, 30);
            testResult.Add(dt == testData.ToEarthTime());

            dt = new DateTime(2024, 1, 29, 12, 1, 1);
            testData = new ADateTime(2820, 4, 13, 12, 64, 30);
            testResult.Add(dt == testData.ToEarthTime());

            int testOk = 0;
            testResult.ForEach(x => { if (x) testOk++; });

            Assert.IsTrue(testOk == testResult.Count);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            List<bool> testResult = new List<bool>();

            ADateTime testData1 = new ADateTime(2804, 18, 31, 2, 2, 88);
            ADateTime testData2 = new ADateTime(2804, 18, 31, 2, 3, 88);
            testResult.Add(testData1 != testData2);

            testData1 = new ADateTime(2834, 18, 31, 2, 2, 88);
            testData2 = new ADateTime(2834, 18, 31, 2, 2, 88);
            testResult.Add(testData1 == testData2);

            testResult.Add(testData1.GetHashCode() == testData2.GetHashCode());

            int testOk = 0;
            testResult.ForEach(x => { if (x) testOk++; });

            Assert.IsTrue(testOk == testResult.Count);
        }

        [TestMethod()]
        public void CalculateDifferenceInDaysTest()
        {
            ADateTime testData1 = new ADateTime(2804, 18, 38, 2, 2, 88);
            ADateTime testData2 = new ADateTime(2805, 1, 1, 2, 3, 88);
            int res=testData1.CalculateDifferenceInDays(testData1, testData2);
            Assert.IsTrue(res==-1);
        }
    }
}