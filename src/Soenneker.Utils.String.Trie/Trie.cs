namespace Soenneker.Utils.String.Trie;

internal class Trie
{
    private readonly TrieNode _root;

    public Trie()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode currentNode = _root;

        for (var i = 0; i < word.Length; i++)
        {
            char ch = word[i];

            if (!currentNode.Children.ContainsKey(ch))
            {
                currentNode.Children[ch] = new TrieNode();
            }

            currentNode = currentNode.Children[ch];
        }

        currentNode.IsEndOfWord = true;
    }

    public int GetCommonPrefixLength(string word)
    {
        TrieNode currentNode = _root;
        var commonPrefixLength = 0;

        for (var i = 0; i < word.Length; i++)
        {
            char ch = word[i];
            if (currentNode.Children.TryGetValue(ch, out TrieNode? child))
            {
                commonPrefixLength++;
                currentNode = child;
            }
            else
            {
                break;
            }
        }

        return commonPrefixLength;
    }
}