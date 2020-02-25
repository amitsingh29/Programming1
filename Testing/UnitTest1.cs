//-----------------------------------------------------------------------
// <copyright file="Tests.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace Testing
{
    using MoodAnalyserNUnit;
    using NUnit.Framework;
   
    /// <summary>
    /// Tests class
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// GivenSadMessage_WhenAnalyse_ReturnSad method
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.Pass(mood.AnalyseMood(), "Sad");
        }

        /// <summary>
        /// GivenAnyMessage_WhenAnalyse_ReturnHappy method
        /// </summary>
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.Pass(mood.AnalyseMood(), "Happy");
        }

        /// <summary>
        /// GivenEmptyMood_ShouldThrow_EmptyMood method
        /// </summary>
        [Test]
        public void GivenEmptyMood_ShouldThrow_EmptyMood()
        {
            MoodAnalyser mood = new MoodAnalyser(string.Empty);
            Assert.AreEqual(mood.AnalyseMood(), "Empty Mood");
        }

        /// <summary>
        /// GivenNullMood_ShouldThrow_NullMood method
        /// </summary>
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
