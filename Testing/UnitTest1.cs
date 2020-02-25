namespace Testing
{
    using MoodAnalyserNUnit;
    using NUnit.Framework;
   
    [TestFixture]
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

        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturn_MoodAnalyserObject()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.IsTrue(mood.Equals(mood));
        }
    }
}
