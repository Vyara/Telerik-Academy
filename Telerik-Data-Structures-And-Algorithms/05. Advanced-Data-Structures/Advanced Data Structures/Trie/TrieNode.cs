namespace Trie
{
    using System.Collections.Generic;

    public class TrieNode
    {
        public TrieNode(char nodeCharacter, IDictionary<char, TrieNode> nodeChildren, bool isWord, int wordCount)
        {
            this.NodeCharacter = nodeCharacter;
            this.NodeChildren = nodeChildren;
            this.IsWord = isWord;
            this.WordCount = wordCount;
        }

        internal char NodeCharacter { get; private set; }

        internal IDictionary<char, TrieNode> NodeChildren { get; private set; }

        internal int WordCount { get; set; }

        internal bool IsWord { get; set; }

        public override string ToString()
        {
            return this.NodeCharacter.ToString();
        }
    }
}
