using System.Collections.Generic;

namespace Soenneker.Utils.String.Trie;

internal class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; set; }

    public bool IsEndOfWord { get; set; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}