namespace Trie
{
    using System.Collections.Generic;
    using System.Text;

    public class Trie : ITrie
    {
        public Trie(TrieNode root)
        {
            this.Root = root;
        }

        private TrieNode Root { get; set; }

        public void Add(string word)
        {
            this.AddWord(this.Root, word.ToCharArray());
        }

        public ICollection<string> GetWords()
        {
            var words = this.GetWordsFromCollection(this.Root);
            return words;
        }

        public ICollection<string> GetWordsByPrefix(string prefix)
        {
            ICollection<string> words;
            if (string.IsNullOrEmpty(prefix))
            {
                words = this.GetWords();
            }
            else
            {
                var trieNode = this.GetNode(prefix);
                words = new List<string>();

                if (trieNode != null)
                {
                    var buffer = new StringBuilder();
                    buffer.Append(prefix);
                    this.GetWordsFromCollection(trieNode, words, buffer);
                }
            }

            return words;
        }

        public bool HasWord(string word)
        {
            var node = this.GetNode(word);
            return node != null && node.IsWord;
        }

        public int WordCount(string word)
        {
            var node = this.GetNode(word);
            return node == null ? 0 : node.WordCount;
        }

        private void AddWord(TrieNode node, char[] word)
        {
            if (word.Length == 0)
            {
                node.IsWord = true;
                node.WordCount++;
            }
        }

        private ICollection<string> GetWordsFromCollection(TrieNode trieNode, ICollection<string> words = null, StringBuilder buffer = null)
        {
            if (buffer == null)
            {
                buffer = new StringBuilder();
            }

            if (words == null)
            {
                words = new List<string>();
            }

            if (trieNode.IsWord)
            {
                words.Add(buffer.ToString());
            }

            foreach (var child in trieNode.NodeChildren.Values)
            {
                buffer.Append(child.NodeChildren);
                this.GetWordsFromCollection(child, words, buffer);
                buffer.Length--;
            }

            return words;
        }

        private TrieNode GetNode(string prefix)
        {
            var trieNode = this.Root;
            foreach (var prefixChar in prefix.ToCharArray())
            {
                trieNode.NodeChildren.TryGetValue(prefixChar, out trieNode);
                if (trieNode == null)
                {
                    break;
                }
            }

            return trieNode;
        }
    }
}
