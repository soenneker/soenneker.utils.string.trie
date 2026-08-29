using System;
using System.Diagnostics.Contracts;

namespace Soenneker.Utils.String.Trie;

/// <summary>
/// A utility library for comparing strings via trie (prefix tree) similarity
/// </summary>
public static class TrieSimilarityStringUtil
{
    /// <summary>
    /// Calculates normalized trie-based string similarity on a zero-to-one scale.
    /// </summary>
    /// <param name="s1">The first string.</param>
    /// <param name="s2">The second string.</param>
    /// <returns>A score from 0 to 1.</returns>
    [Pure]
    public static double CalculateSimilarity(string s1, string s2)
    {
        if (s1 == s2)
            return 1;

        int commonPrefixLength = 0;
        int comparableLength = Math.Min(s1.Length, s2.Length);

        while (commonPrefixLength < comparableLength && s1[commonPrefixLength] == s2[commonPrefixLength])
            commonPrefixLength++;

        int maxLength = Math.Max(s1.Length, s2.Length);
        double similarityPercentage = (double)commonPrefixLength / maxLength;

        return similarityPercentage;
    }

    /// <summary>
    /// Calculates trie-based string similarity as a percentage.
    /// </summary>
    /// <param name="s1">The first string.</param>
    /// <param name="s2">The second string.</param>
    /// <returns>A percentage from 0 to 100.</returns>
    [Pure]
    public static double CalculateSimilarityPercentage(string s1, string s2)
    {
        double similarity = CalculateSimilarity(s1, s2);
        double percentageMatch = similarity * 100;

        return percentageMatch;
    }
}
