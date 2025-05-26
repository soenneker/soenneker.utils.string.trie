using Soenneker.Tests.FixturedUnit;
using Xunit;

using AwesomeAssertions;

namespace Soenneker.Utils.String.Trie.Tests;

[Collection("Collection")]
public class TrieSimilarityStringUtilTests : FixturedUnitTest
{
    public TrieSimilarityStringUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Theory]
    [InlineData("hello", "hell", 80.0)]
    [InlineData("abc", "abcd", 75.0)]
    [InlineData("abc", "xyz", 0.0)]
    [InlineData("prefix", "pre", 50.0)]
    [InlineData("", "", 100.0)]
    [InlineData("abcdef", "abcxyz", 50.0)]
    [InlineData("i bought me a cat", "i bought me a duck", 77.0)]
    public void CalculateSimilarity_ShouldReturnExpectedResult(string str1, string str2, double expected)
    {
        double actual = TrieSimilarityStringUtil.CalculateSimilarityPercentage(str1, str2);
        actual.Should().BeApproximately(expected, 1);
    }
}
