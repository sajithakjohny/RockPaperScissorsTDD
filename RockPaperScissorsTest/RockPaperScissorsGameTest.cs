using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsDev;
using Xunit;

namespace RockPaperScissorsTest
{
    public class RockPaperScissorsGameTest
    {
        RockPaperScissorsGameDev rockPaperScissorsGameDev = new RockPaperScissorsGameDev();
        [Fact]
        public void rockShouldCrushScissors()
        {
            //Arrange
            string expectedResult = "rock beats scissors";
            //Act
            string result = rockPaperScissorsGameDev.DetermineWinner("rock", "scissors");
            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
