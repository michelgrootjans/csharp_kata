using NUnit.Framework;

namespace Kata
{
    public class RomanOperationsTest
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual("II", Add("I", "I"));
            Assert.AreEqual("III", Add("II", "I"));
            Assert.AreEqual("III", Add("I", "II"));
            Assert.AreEqual("IV", Add("I", "III"));
        }

        private string Add(string s, string s1)
        {
            return "";
        }
    }
}