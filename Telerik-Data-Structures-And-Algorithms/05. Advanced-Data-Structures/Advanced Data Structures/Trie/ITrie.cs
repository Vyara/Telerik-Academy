namespace Trie
{
    using System.Collections.Generic;

   public interface ITrie
   {
       void Add(string word);

       ICollection<string> GetWords();

        ICollection<string> GetWordsByPrefix(string prefix);

       int WordCount(string word);

       bool HasWord(string word);
   }
}
