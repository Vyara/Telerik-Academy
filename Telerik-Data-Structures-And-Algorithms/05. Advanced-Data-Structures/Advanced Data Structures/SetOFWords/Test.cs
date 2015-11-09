namespace SetOFWords
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Trie;

    public class Test
    {
        private static readonly Random Random = new Random();
        private static readonly Stopwatch Timer = new Stopwatch();

        public static void Main()
        {
            var trie = new Trie(new TrieNode(' ', new Dictionary<char, TrieNode>(), false, 0));

            var words = GenerateRandomWords(1000000);
            var uniqueWords = new HashSet<string>(words);

            AddWordsToTrie(words, trie);
            GetCountOfAllUniqueWords(uniqueWords, trie);
        }

        private static ICollection<string> GenerateRandomWords(int count)
        {
            Console.WriteLine("Genrating random words... ");
            Console.WriteLine(new string('-', 30));
            Timer.Start();

            var words = new List<string>(count);

            for (int i = 0; i < count; i++)
            {
                words.Add(GetRandomWord());
            }

            Timer.Stop();
            Console.WriteLine("Generated random words -> Total words: {0} | Elapsed time: {1}", words.Count, Timer.Elapsed);
            Console.WriteLine(new string('-', 30));
            Timer.Reset();

            return words;
        }

        private static string GetRandomWord()
        {
            var newWord = new char[Random.Next(3, 7)];

            for (int i = 0; i < newWord.Length; i++)
            {
                newWord[i] = (char)Random.Next(97, 122);
            }

            return new string(newWord);
        }

        private static void AddWordsToTrie(ICollection<string> words, ITrie trie)
        {
            Console.WriteLine("Adding words to trie... ");
            Console.WriteLine(new string('-', 30));
            Timer.Start();

            foreach (var word in words)
            {
                trie.Add(word);
            }

            Timer.Stop();
            Console.WriteLine("Added words to trie {0} -> Elapsed time: {1}", words.Count, Timer.Elapsed);
            Console.WriteLine(new string('-', 30));
            Timer.Reset();
        }

        private static void GetCountOfAllUniqueWords(ICollection<string> wordsToBeSearched, ITrie trie)
        {
            Console.WriteLine("Searching for words... ");
            Console.WriteLine(new string('-', 30));
            Timer.Start();

            foreach (var word in wordsToBeSearched)
            {
                trie.WordCount(word); // return the number of words    
            }

            Timer.Stop();
            Console.WriteLine("Searched words -> Unique words: {0} | Elapsed time: {1}", wordsToBeSearched.Count, Timer.Elapsed);
            Console.WriteLine(new string('-', 30));
            Timer.Reset();
        }
    }
}
