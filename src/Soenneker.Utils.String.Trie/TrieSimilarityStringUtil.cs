using System;
using System.Diagnostics.Contracts;

namespace Soenneker.Utils.String.Trie;

/// <summary>
/// A utility library for comparing strings via trie (prefix tree) similarity
/// </summary>
public static class TrieSimilarityStringUtil
{
    [Pure]
    public static double CalculateSimilarity(string s1, string s2)
    {
        if (s1 == s2)
            return 1;

        var trie = new Trie();
        trie.Insert(s1);

        int commonPrefixLength = trie.GetCommonPrefixLength(s2);

        int maxLength = Math.Max(s1.Length, s2.Length);
        double similarityPercentage = (double)commonPrefixLength / maxLength;

        return similarityPercentage;
    }

    [Pure]
    public static double CalculateSimilarityPercentage(string s1, string s2)
    {
        double similarity = CalculateSimilarity(s1, s2);
        double percentageMatch = similarity * 100;

        return percentageMatch;
    }
}