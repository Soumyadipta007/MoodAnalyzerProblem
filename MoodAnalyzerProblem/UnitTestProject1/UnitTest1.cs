using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodReturnSad()
        {
            //Arrange
            MoodAnalyze moodAnalyze = new MoodAnalyze();
            //Act
            var result = moodAnalyze.analyzeMood("I am in Sad Mood");
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void GivenHappyMoodReturnHappy()
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
        public void GivenSadMoodInConstructorReturnSad(string message)
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
        public void GivenHappyMoodInConstructorReturnHappy(string message)
        {
            //Arrange
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);
            //Act
            var result = moodAnalyze.analyzeMood();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenNullMoodThrowMoodAnalyzerExceptionNullMessage(string message)
        {
            try
            {
                //Arrange
                MoodAnalyze moodAnalyze = new MoodAnalyze(message);
                //Act
                var result = moodAnalyze.analyzeMood();
            }
            catch(MoodAnalyzerException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyMoodThrowMoodAnalyzerExceptionEmptyMessage(string message)
        {
            try
            {
                //Arrange
                MoodAnalyze moodAnalyze = new MoodAnalyze(message);
                //Act
                var result = moodAnalyze.analyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            //Arrange
            string message = null;
            object expected = new MoodAnalyze(message);
            //Act
            object obj = MoodAnalyzerFactory.CreateMoodAnalyser("MoodAnalyzerProblem.MoodAnalyze", "MoodAnalyze");
            //Assert
            expected.Equals(obj);
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }
        [TestMethod]
        public void GivenMoodAnalyzeImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = null;
                object expected = new MoodAnalyze(message);
                //Act
                object obj = MoodAnalyzerFactory.CreateMoodAnalyser("MoodAnalyzerProblem.MoodAnalyz", "MoodAnalyz");                  
            }
            catch(MoodAnalyzerException e)
            {
                //Assert
                Assert.AreEqual("Class not found", e.Message);
            }
        }
        [TestMethod]
        public void GivenMoodAnalyzeImproperConstructorName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = null;
                object expected = new MoodAnalyze(message);
                //Act
                object obj = MoodAnalyzerFactory.CreateMoodAnalyser("MoodAnalyzerProblem.MoodAnalyze", "MoodAnalyz");
            }
            catch (MoodAnalyzerException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not found", e.Message);
            }
        }
    }
}
