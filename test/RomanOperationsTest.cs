using NUnit.Framework;

namespace Kata
{
    public class RomanOperationsTest
    {
        private RomanOperations operations;

        [SetUp]
        public void SetUp()
        {
            operations = new RomanOperations();
        }

        [Test]
        public void Add_I_I()
        {
            Assert.That(operations.Add("I", "I"), Is.EqualTo("II"));
        }

        [Test]
        public void Add_I_II()
        {
            Assert.That(operations.Add("I", "II"), Is.EqualTo("III"));
        }

        [Test]
        public void Add_II_I()
        {
            Assert.That(operations.Add("II", "I"), Is.EqualTo("III"));
        }

        [Test]
        public void Add_II_II()
        {
            Assert.That(operations.Add("II", "II"), Is.EqualTo("IV"));
        }

        [Test]
        public void Add_II_III()
        {
            Assert.That(operations.Add("II", "III"), Is.EqualTo("V"));
        }

        [Test]
        public void Add_I_IIII()
        {
            Assert.That(operations.Add("I", "IIII"), Is.EqualTo("V"));
        }

        [Test]
        public void Add_III_III()
        {
            Assert.That(operations.Add("III", "III"), Is.EqualTo("VI"));
        }

        [Test]
        public void Add_IV_I()
        {
            Assert.That(operations.Add("IV", "I"), Is.EqualTo("V"));
        }

        [Test]
        public void Add_V_I()
        {
            Assert.That(operations.Add("V", "I"), Is.EqualTo("VI"));
        }

        [Test]
        public void Add_VI_I()
        {
            Assert.That(operations.Add("VI", "I"), Is.EqualTo("VII"));
        }

        [Test]
        public void Add_V_IV()
        {
            Assert.That(operations.Add("V", "IV"), Is.EqualTo("IX"));
        }

        [Test]
        public void Add_VI_IV()
        {
            Assert.That(operations.Add("VI", "IV"), Is.EqualTo("X"));
        }

        [Test]
        public void Add_VI_IX()
        {
            Assert.That(operations.Add("VI", "IX"), Is.EqualTo("XV"));
        }

        [Test]
        public void Add_VI_X()
        {
            Assert.That(operations.Add("VI", "X"), Is.EqualTo("XVI"));
        }

        [Test]
        public void Add_XIX_XX()
        {
            Assert.That(operations.Add("XIX", "XX"), Is.EqualTo("XXXIX"));
        }
    }
}