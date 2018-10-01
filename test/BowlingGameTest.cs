using NUnit.Framework;

namespace Kata
{
    public class BowlingGameTest
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void ANewGame()
        {
            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test]
        public void Rolling_0()
        {
            game.Roll(0);
            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test]
        public void Rolling_1()
        {
            game.Roll(1);
            Assert.That(game.Score(), Is.EqualTo(1));
        }

        [Test]
        public void Rolling_1_1()
        {
            game.Roll(1);
            game.Roll(1);
            Assert.That(game.Score(), Is.EqualTo(2));
        }

        [Test]
        public void Rolling_spare_1()
        {
            game.Roll(6);
            game.Roll(4);
            game.Roll(1);
            Assert.That(game.Score(), Is.EqualTo((6+4+1) + 1));
        }

        [Test]
        public void Rolling_1_2_spare_1()
        {
            game.Roll(1);
            game.Roll(2);
            game.Roll(6);
            game.Roll(4);
            game.Roll(1);
            Assert.That(game.Score(), Is.EqualTo((1+2) + (6+4+1) + 1));
        }

        [Test]
        public void Rolling_fake_spare()
        {
            game.Roll(0);
            game.Roll(4);
            game.Roll(6);
            game.Roll(1);
            Assert.That(game.Score(), Is.EqualTo((0+4) + (6+1)));
        }

        [Test]
        public void Rolling_strike_1_2()
        {
            game.Roll(10);
            game.Roll(1);
            game.Roll(2);
            Assert.That(game.Score(), Is.EqualTo((10+1+2) + (1+2)));
        }

        [Test]
        public void Rolling_fake_strike_1_2()
        {
            game.Roll(0);
            game.Roll(10);
            game.Roll(1);
            game.Roll(2);
            Assert.That(game.Score(), Is.EqualTo((0+10+1) + (1+2)));
        }

        [Test]
        public void Rolling_strike_strike_1_2()
        {
            game.Roll(10);
            game.Roll(10);
            game.Roll(1);
            game.Roll(2);
            Assert.That(game.Score(), Is.EqualTo((10+10+1) + (10+1+2) + (1+2)));
        }

        [Test]
        public void Rolling_all_5()
        {
            for (int i = 0; i < 21; i++)
                game.Roll(5);
            Assert.That(game.Score(), Is.EqualTo(150));
        }

        [Test]
        public void Rolling_a_perfect_game()
        {
            for (int i = 0; i < 12; i++)
                game.Roll(10);
            Assert.That(game.Score(), Is.EqualTo(300));
        }
    }
}