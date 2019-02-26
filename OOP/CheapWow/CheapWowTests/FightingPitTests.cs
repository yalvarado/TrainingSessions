using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CheapWow;
using CheapWow.Helpers;
using Moq;

namespace CheapWowTests
{
    
    public class FightingPitTests
    {
        

        [Fact]
        public void When_first_fighter_is_missing_second_fighter_has_same_health_than_before_the_fight()
        {
            string result = "fighter 1 is missing!";

            var mockConsole = new Mock<IConsole>();
            mockConsole.Setup(_ => _.WriteLine(result));
            

            var fightingPit = new FightingPit(mockConsole.Object);
            IFighter fighter2 = new Fighter("fighter2");

            var healthBeforeFight = fighter2.Health;
            fightingPit.Fight(null, fighter2);

            Assert.True(healthBeforeFight==fighter2.Health,"Fighter's 2 health has changed during the fight");

            mockConsole.VerifyAll();

        }

        [Fact]
        public void When_second_fighter_is_missing_first_fighter_has_same_health_than_before_the_fight()
        {
            string result = "fighter 2 is missing!";

            var mockConsole = new Mock<IConsole>();
            mockConsole.Setup(_ => _.WriteLine(result));


            var fightingPit = new FightingPit(mockConsole.Object);
            IFighter fighter1 = new Fighter("fighter1");

            var healthBeforeFight = fighter1.Health;
            fightingPit.Fight(fighter1,null);

            Assert.True(healthBeforeFight == fighter1.Health, "Fighter's 2 health has changed during the fight");

            mockConsole.VerifyAll();

        }

    }
}
