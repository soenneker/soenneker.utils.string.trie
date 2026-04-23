using Soenneker.Tests.HostedUnit;

using AwesomeAssertions;

namespace Soenneker.Utils.String.Trie.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class TrieSimilarityStringUtilTests : HostedUnitTest
{
    public TrieSimilarityStringUtilTests(Host host) : base(host)
    {
    }

    [Test]
    [Arguments("hello", "hell", 80.0)]
    [Arguments("abc", "abcd", 75.0)]
    [Arguments("abc", "xyz", 0.0)]
    [Arguments("prefix", "pre", 50.0)]
    [Arguments("", "", 100.0)]
    [Arguments("abcdef", "abcxyz", 50.0)]
    [Arguments("i bought me a cat", "i bought me a duck", 77.0)]
    public void CalculateSimilarity_ShouldReturnExpectedResult(string str1, string str2, double expected)
    {
        double actual = TrieSimilarityStringUtil.CalculateSimilarityPercentage(str1, str2);
        actual.Should().BeApproximately(expected, 1);
    }
}

