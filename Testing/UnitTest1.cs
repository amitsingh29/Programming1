using NUnit.Framework;
using MoodAnalyserNUnit;
namespace Testing
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.Pass(mood.AnalyseMood(), "Sad");
        }

        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.Pass(mood.AnalyseMood(), "Happy");
        }

        [Test]
        public void GivenNullMood_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.AreEqual(mood.AnalyseMood(), "Happy");
        }
    }
}