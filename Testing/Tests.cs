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

        /// <summary>
        /// GivenMoodAnalyserClassName_ShouldReturn_MoodAnalyserObject method
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturn_MoodAnalyserObject()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.IsTrue(mood.Equals(mood));
        }

        /// <summary>
        /// GivenClassName_WhenImproper_ThrowMoodAnalysisException method
        /// </summary>
        [Test]
        public void GivenClassName_WhenImproper_ThrowMoodAnalysisException()
        {
            string ExceptionMessage = MoodAnalyserReflector.MoodAnalyser("Amit").ToString();
            Assert.AreEqual("No Such Class", ExceptionMessage);
        }

        /// <summary>
        /// GivenMoodAnalyserProperThroughConstructor_WhenAnalyse_ReturnMoodAnalyserObject method
        /// </summary>
        [Test]
        public void GivenMoodAnalyserProperThroughConstructor_WhenAnalyse_ReturnMoodAnalyserObject()
        {
            MoodAnalyser mood = new MoodAnalyser("Hello");
            Assert.IsTrue(mood.Equals(mood));
        }

        /// <summary>
        /// GivenClassNameImproperThroughConstructor_WhenAnalyse_ReturnMoodAnalysisException method
        /// </summary>
        [Test]
        public void GivenClassNameImproperThroughConstructor_WhenAnalyse_ReturnMoodAnalysisException()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string exceptionMessage = MoodAnalyserReflector.MoodAnalyser("Bridge").ToString();
            Assert.AreEqual("No Such Class", exceptionMessage);
        }

        [Test]
        public void GivenHappyMessageUsingReflection_WhenAnalyse_ReturnHappyMood()
        {
            MoodAnalyser mood = (MoodAnalyser)MoodAnalyserReflector.MoodAnalyser("MoodAnalyser", "Happy");
            string actual = mood.GetType().GetMethod("AnalyseMood").Invoke(mood, null).ToString();
            Assert.AreEqual("Happy", actual);
        }
    }
}
