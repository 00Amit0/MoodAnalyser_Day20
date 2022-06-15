using MoodAnalyser;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("HAPPY MOOD")]
        public void TestMethod1()
        {
            //giving string value to message 
            string message = "I am HAPPY today";
            //giving expected result to variable 
            string expected = "happy";
            //creating object
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //returned value assigning to actual
            string actual = moodAnalyzer.AnalyseMood();
            //comparing expected and actual 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("SAD MOOD")]
        public void TestMethod2()
        {
            //giving string value to message 
            string message = "I am sad today";
            //giving expected result to variable 
            string expected = "sad";
            //creating object
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //returned value assigning to actual
            string actual = moodAnalyzer.AnalyseMood();
            //comparing expected and actual 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("NULL")]
        public void TestMethod3()
        {
            //giving string value to message 
            string message = null;
            //giving expected result to variable 
            string expected = "happy";
            //creating object
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //returned value assigning to actual
            string actual = moodAnalyzer.AnalyseMood();
            //comparing expected and actual 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Empty Exception")]
        public void TestMethod4()
        {
            ///Arrange , Act and in last Assert
            //giving expected result to variable 
            string excepted = "Message can't be Empty";
            try
            {
                //giving string value to message 
                string message = " ";
                //creating object
                MoodAnalyzer mood = new MoodAnalyzer(message);
                //returned value assigning to actual
                string actual = mood.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                Console.WriteLine("Mood anaylser Exception :" + ex);
                //comparing 
                Assert.AreEqual(excepted, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Invalid class Name")]
        public void GivenInvalidClassName_ShouldThrow_MoodAnalyserException()
        {
            ///Arrange , Act and in last Assert
            //giving expected result to variable 
            string expected = "Class not Found";
            try
            {
                //creating instence of class 
                object obj = MoodAnalyserFactory.CreateMoodAnalyseMethod("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomMoodAnalyserException ex)
            {
                //comparing and catching exception
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Invalid cunstructor")]
        public void GivenClass_WhenNotProper_Constructor_ShouldThrow_MoodAnalyserException()
        {
            ///Arrange , Act and in last Assert
            //giving expected result to variable 
            string expected = "Constructor is not Found";
            try
            {
                //creating instence of class 
                object obj = MoodAnalyserFactory.CreateMoodAnalyseMethod("MoodAnalyser.MoodAnalyzer", "MoodAnalyzer");
            }
            catch (CustomMoodAnalyserException ex)
            {
                //comparing and catching exception
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}