using System;
using Xunit;

namespace Stryker.Demo.Tests
{
    public class BoolComparerTest
    {
        [Fact]
        public void ShouldReturnTrueWhenEqual_Kill()
        {
            var result = BoolComparer.IsEqualMutationKilled(true, true);

            Assert.True(result);
        }
        
        [Fact]
        public void ShouldReturnTrueWhenEqual_Survive()
        {
            var result = BoolComparer.IsEqualMutationSurvived(true, true);

            Assert.True(result);
        }
    }
}