using System;
using Xunit;

namespace GitKrakenTesting.Tests
{
    public class GitKrakenTests
    {
        [Fact]
        public void Add_Numbers()
        {
            // arrange
            var target = new Calculator();
            // act
            var result = target.Add(1, 2);
            // assert
            Assert.Equal(3, result);
        }
    }
}
