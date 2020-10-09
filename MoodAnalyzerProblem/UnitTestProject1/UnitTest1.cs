using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MoodAnalyze moodAnalyze = new MoodAnalyze();
            //Act
            var result = moodAnalyze.analyzeMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            MoodAnalyze moodAnalyze = new MoodAnalyze();
            //Act
            var result = moodAnalyze.analyzeMood("I am in Happy Mood");
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        [DataRow("I am in Sad Mood")]
        public void TestMethod3(string message)
        {
            //Arrange
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);
            //Act
            var result = moodAnalyze.analyzeMood();
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        public void TestMethod4(string message)
        {
            //Arrange
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);
            //Act
            var result = moodAnalyze.analyzeMood();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
    }
}
