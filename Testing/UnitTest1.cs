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
        public void GivenEmptyMood_ShouldThrow_EmptyMood()
        {
            MoodAnalyser mood = new MoodAnalyser(string.Empty);
            Assert.AreEqual(mood.AnalyseMood(), "Empty Mood");
        }


        [Test]
        public void GivenNullMood_ShouldThrow_NullMood()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            Assert.AreEqual(mood.AnalyseMood(), "Null Mood");
        }
    }
    }
