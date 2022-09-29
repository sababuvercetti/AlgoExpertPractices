using System;
using System.Text;
using System.Collections.Generic;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create the linked list
            string[] words = { "Hello", "There", "My Name", "Is", "Sam" };
            LinkedList<String> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");

            /// Get the number of items in the linkedlist
            Console.Write("LinkedList Items:"+sentence.Count());
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
