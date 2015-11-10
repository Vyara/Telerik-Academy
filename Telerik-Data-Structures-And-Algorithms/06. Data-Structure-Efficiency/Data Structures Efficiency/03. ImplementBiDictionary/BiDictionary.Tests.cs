namespace ImplementBiDictionary
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            var biDictionary = new BiDictionary<int, string, string>(true);

            Console.WriteLine("Testing Adding...");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Adding elements with Key 1");
            Console.WriteLine(new string('-', 30));
            biDictionary.Add(1, "One", "Element with Key1 1, Key 2 is One");
            biDictionary.Add(1, "One", "Element with Key1 1, Key 2 is One");
            biDictionary.Add(1, "Two", "Element with Key 1 1, Key 2 is Two");

            Console.WriteLine("Adding elements with Key 2");
            Console.WriteLine(new string('-', 30));
            biDictionary.Add(2, "Two", "First Element with Key1 2");
            biDictionary.Add(2, "Second - Two", "Second Element with Key1 2");

            Console.WriteLine("Adding elements with Key 3");
            Console.WriteLine(new string('-', 30));
            biDictionary.Add(3, "Three", "Element with Key1 3");

            biDictionary.Add(3, "Second Three", "Turing");
            Console.WriteLine("Adding elements with Key 4");
            Console.WriteLine(new string('-', 30));
            biDictionary.Add(4, "Four", "First");
            biDictionary.Add(4, "Four", "Second");

            Console.WriteLine("Testing Get Methods...");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(string.Join(", ", biDictionary.GetByFirstKey(1)));
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", biDictionary.GetBySecondKey("Two")));
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", biDictionary.GetByTwoKeys(1, "One")));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Testing Value property...");
            Console.WriteLine(new string('-', 30));
            PrintAllValues(biDictionary);

            Console.WriteLine();
            Console.WriteLine("Removing first Key method...");
            Console.WriteLine(new string('-', 30));
            biDictionary.RemoveByFirstKey(4);

            PrintAllValues(biDictionary);

            Console.WriteLine();
            Console.WriteLine("Removing second Key method...");
            Console.WriteLine(new string('-', 30));
            biDictionary.RemoveBySecondKey("Two");

            PrintAllValues(biDictionary);

            Console.WriteLine();
            Console.WriteLine("Removing by two Key methods");
            Console.WriteLine(new string('-', 30));
            biDictionary.RemoveByTwoKeys(1, "One");

            PrintAllValues(biDictionary);

            Console.WriteLine();
            Console.WriteLine("Testing clearing method...");
            Console.WriteLine(new string('-', 30));
            biDictionary.Clear();

            PrintAllValues(biDictionary);
        }

        public static void PrintAllValues<K1, K2, V>(BiDictionary<K1, K2, V> biDictionary)
        {
            Console.WriteLine("\nEmelents Count: " + biDictionary.Count);

            foreach (var value in biDictionary.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}