using CheapWow.Helpers;
using NMock;
using Xunit;

namespace CheapWowTests.Helpers
{

    public class When_working_with_the_RandomGenerator_class
    {
        public class And_calling_the_getrandomnumber_method : When_working_with_the_RandomGenerator_class
        {
            [Fact]
            public void When_passing_two_positive_numbers_the_returned_number_is_between_the_two_given_numbers()
            {
                var _mockFactory = new MockFactory();
                Mock<IRandomGenerator> mockRandomGenerator = _mockFactory.CreateMock<IRandomGenerator>()
            }

        }
    }
}
