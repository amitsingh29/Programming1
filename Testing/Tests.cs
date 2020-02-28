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
        /// Given the sad message when analyze return sad.
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I'm in sad mood");
            Assert.Pass(mood.AnalyseMood(), "Sad");
        }

        /// <summary>
        /// Given any message when analyze return happy.
        /// </summary>
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I'm in any mood");
            Assert.Pass(mood.AnalyseMood(), "Happy");
        }

        /// <summary>
        ///  Given the empty message when analyze return empty
        /// </summary>
        [Test]
        public void GivenEmptyMood_ShouldThrow_EmptyMood()
        {
            MoodAnalyser mood = new MoodAnalyser(string.Empty);
            Assert.AreEqual(mood.AnalyseMood(), "Empty Mood");
        }

        /// <summary>
        ///  Given the null message when analyze return null.
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldThrow_NullMood()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            Assert.AreEqual(mood.AnalyseMood(), "Null Mood");
        }

        /// <summary>
        ///  Given the null message when analyze return null.
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturn_MoodAnalyserObject()
        {
            MoodAnalyser mood = new MoodAnalyser();
            Assert.IsTrue(mood.Equals(mood));
        }

        /// <summary>
        ///  Given the class name improper when analyze return mood analysis exception
        /// </summary>
        [Test]
        public void GivenClassName_WhenImproper_ThrowMoodAnalysisException()
        {
            string exceptionMessage = MoodAnalyserReflector.MoodAnalyser("Amit").ToString();
            Assert.AreEqual("No Such Class", exceptionMessage);
        }

        /// <summary>
        /// Given the mood analyzer proper through constructor when analyze return mood analyzer object.
        /// </summary>
        [Test]
        public void GivenMoodAnalyserProperThroughConstructor_WhenAnalyse_ReturnMoodAnalyserObject()
        {
            MoodAnalyser mood = new MoodAnalyser("Hello");
            Assert.IsTrue(mood.Equals(mood));
        }

        /// <summary>
        ///  Given the class name improper through constructor when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void GivenClassNameImproperThroughConstructor_WhenAnalyse_ReturnMoodAnalysisException()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string exceptionMessage = MoodAnalyserReflector.MoodAnalyser("Bridge").ToString();
            Assert.AreEqual("No Such Class", exceptionMessage);
        }

        /// <summary>
        /// Given the happy message using reflection when analyze return happy mood.
        /// </summary>
        [Test]
        public void GivenHappyMessageUsingReflection_WhenAnalyse_ReturnHappyMood()
        {
            MoodAnalyser mood = (MoodAnalyser)MoodAnalyserReflector.MoodAnalyser("MoodAnalyser", "Happy");
            string actual = mood.GetType().GetMethod("AnalyseMood").Invoke(mood, null).ToString();
            Assert.AreEqual("Happy", actual);
        }

        /// <summary>
        /// Given the happy message when improper method when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void GivenHappyMessageWhenImproperMethod_WhenAnalyse_ThrowMoodAnalysisException()
        {
            MoodAnalyserReflector moodAnalyserReflector = (MoodAnalyserReflector)MoodAnalyserReflector.MoodAnalyser("MoodAnalyserReflector");
            string[] parameters = new string[1];
            parameters[0] = "No Such Method";
            string actual = moodAnalyserReflector.GetType().GetMethod("WrongMethod").Invoke(moodAnalyserReflector, parameters).ToString();
            Assert.AreEqual("No Such Method", actual);
        }

        /// <summary>
        /// Set the happy message with reflector when analyze return happy.
        /// </summary>
        [Test]
        public void SetHappyMessageWithReflector_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyserReflector moodAnalyserReflector = (MoodAnalyserReflector)MoodAnalyserReflector.MoodAnalyser("MoodAnalyserReflector");
            string[] parameters = new string[2];
            parameters[0] = "Happy";
            parameters[1] = "Check";
            string actual = moodAnalyserReflector.GetType().GetMethod("SetField").Invoke(moodAnalyserReflector, parameters).ToString();
            Assert.AreEqual("Happy", actual);
        }

        /// <summary>
        /// Set the improper field with message when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void SetValueOnImproperField_WhenAnalyse_ThrowMoodAnalysisException()
        {
            MoodAnalyserReflector moodAnalyserReflector = (MoodAnalyserReflector)MoodAnalyserReflector.MoodAnalyser("MoodAnalyserReflector");
            string[] parameters = new string[2];
            parameters[0] = "Happy";
            parameters[1] = "anything";
            string actual = moodAnalyserReflector.GetType().GetMethod("SetField").Invoke(moodAnalyserReflector, parameters).ToString();
            Assert.AreEqual("No Such Field", actual);
        }

        /// <summary>
        /// Set the null message with reflector when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void SetNullMessageWithReflector_WhenAnalyse_ReturnMoodAnalysisException()
        {
            MoodAnalyserReflector moodAnalyserReflector = (MoodAnalyserReflector)MoodAnalyserReflector.MoodAnalyser("MoodAnalyserReflector");
            string[] parameters = new string[2];
            parameters[0] = null;
            parameters[1] = "Check";
            string actual = moodAnalyserReflector.GetType().GetMethod("SetField").Invoke(moodAnalyserReflector, parameters).ToString();
            Assert.AreEqual("Null", actual);
        }
    }
}
