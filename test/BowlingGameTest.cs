using Xunit;

namespace bowling
{
    public class BowlingGameTest
    {
        [Fact]
        public void ANewGame()
        {
            Assert.Equal(0, new BowlingGame().Score);
        }
        
    }

    public class BowlingGame{
        public int Score{get; set;}
    }
}