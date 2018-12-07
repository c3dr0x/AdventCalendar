using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventCalendar2018.Tests
{
    [TestClass]
    public class DayTwoTests
    {
        [TestMethod]
        public void CallengeOne_TestSituation1()
        {
            string input = "abcdef";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(false, Twice);
            Assert.AreEqual(false, ThreeTimes);
        }

        [TestMethod]
        public void CallengeOne_TestSituation2()
        {
            string input = "bababc";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(true, Twice);
            Assert.AreEqual(true, ThreeTimes);
        }

        [TestMethod]
        public void CallengeOne_TestSituation3()
        {
            string input = "abbcde";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(true, Twice);
            Assert.AreEqual(false, ThreeTimes);
        }

        [TestMethod]
        public void CallengeOne_TestSituation4()
        {
            string input = "abcccd";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(false, Twice);
            Assert.AreEqual(true, ThreeTimes);
        }

        [TestMethod]
        public void CallengeOne_TestSituation5()
        {
            string input = "aabcdd";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(true, Twice);
            Assert.AreEqual(false, ThreeTimes);
        }

        [TestMethod]
        public void CallengeOne_TestSituation6()
        {
            string input = "abcdee";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(true, Twice);
            Assert.AreEqual(false, ThreeTimes);
        }

        [TestMethod]
        public void CallengeOne_TestSituation7()
        {
            string input = "ababab";

            var (Twice, ThreeTimes) = DayTwo.CountTwiceAndThreeTimes(input);

            Assert.AreEqual(false, Twice);
            Assert.AreEqual(true, ThreeTimes);
        }

        [TestMethod]
        public void ChallengeOne_TestSituationComplete()
        {
            string input = @"
abcdef
bababc
abbcde
abcccd
aabcdd
abcdee
ababab";

            int result = DayTwo.ComputeChallengeOneResult(input);

            Assert.AreEqual(12, result);
        }
    }
}
