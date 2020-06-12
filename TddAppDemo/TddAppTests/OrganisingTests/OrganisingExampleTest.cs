using System;
using System.Collections.Generic;
using System.Text;
using TddApp.OrganisingTests;
using Xunit;

namespace TddAppTests.OrganisingTests
{
    public class OrganisingExampleTests
    {
        protected readonly OrganisingExample _example = new OrganisingExample();

        public class When_calling_the_IsEven_method : OrganisingExampleTests
        {
            [Theory]
            [InlineData(0)]
            [InlineData(2)]
            [InlineData(10)]
            public void Then_passing_an_even_number_should_return_true(int number)
            {
                bool result = this._example.IsEven(number);

                Assert.True(result);
            }

            [Theory]
            [InlineData(1)]
            [InlineData(3)]
            [InlineData(9)]
            public void Then_passing_an_odd_number_should_return_false(int number)
            {
                bool result = this._example.IsEven(number);

                Assert.False(result);

            }

        }

        public class When_calling_the_IsOdd_method : OrganisingExampleTests
        {
            [Theory]
            [InlineData(0)]
            [InlineData(2)]
            [InlineData(10)]
            public void Then_passing_an_even_number_should_return_false(int number)
            {
                bool result = this._example.IsOdd(number);

                Assert.False(result);
            }

            [Theory]
            [InlineData(1)]
            [InlineData(3)]
            [InlineData(9)]
            public void Then_passing_an_odd_number_should_return_true(int number)
            {
                bool result = this._example.IsOdd(number);

                Assert.True(result);

            }

        }

    }
}
