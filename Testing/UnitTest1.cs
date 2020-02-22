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
            Assert.Pass(mood.AnalyseMood("I'm in sad mood"), "Sad");
        }
    }
}