using NUnit.Framework;

namespace Kata
{
    public class RomanOperationsTest
    {
        [Test]
        public void Add_I_I()
        {
            Assert.That(Add("I", "I"), Is.EqualTo("II"));
        }

        private string Add(string s, string s1)
        {
            return "II";
        }
    }
}