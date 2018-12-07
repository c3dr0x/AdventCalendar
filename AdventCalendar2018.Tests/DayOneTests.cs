using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventCalendar2018.Tests
{
    [TestClass]
    public class DayOneTests
    {
        [TestMethod]
        public void CallengeOne_TestSituation1()
        {
            string input = "+1, +1, +1";
            int result = DayOne.ComputeChallengeOneResult(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CallengeOne_TestSituation2()
        {
            string input = "+1, +1, -2";
            int result = DayOne.ComputeChallengeOneResult(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CallengeOne_TestSituation3()
        {
            string input = "-1, -2, -3";
            int result = DayOne.ComputeChallengeOneResult(input);

            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void ChallengeTwo_TestSituation1()
        {
            string input = "+1, -1";
            int result = DayOne.ComputeChallengeTwoResult(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ChallengeTwo_TestSituation2()
        {
            string input = "+3, +3, +4, -2, -4";
            int result = DayOne.ComputeChallengeTwoResult(input);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ChallengeTwo_TestSituation3()
        {
            string input = "-6, +3, +8, +5, -6";
            int result = DayOne.ComputeChallengeTwoResult(input);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ChallengeTwo_TestSituation4()
        {
            string input = "+7, +7, -2, -7, -4";
            int result = DayOne.ComputeChallengeTwoResult(input);

            Assert.AreEqual(14, result);
        }
    }
}
