using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegate
{
    class StringManipulation
    {
        private string _newSentance;

        private string _newSentance1;

        private string _newWords = "";

        public delegate void StringHandler();

        public string MyString
        {
            set { this._newSentance = value; }
        }
        public string MyString1
        {
            set { this._newSentance1 = value; }
        }

        public void ReplaceCharacter()
        {

            string message = _newSentance.Replace(' ', '_');

            Console.WriteLine("The ' ' is Replaced with '_' in the given Sentance :\n" + message);
        }

        public void ReverseSentance()
        {
            List<string> wordList = new List<string>();

            string[] words = _newSentance.Split(new[] { ' ' });

            for (int i = words.Length - 1; i >= 0; i--)
            {
                _newWords += words[i] + " ";
            }

            wordList.Add(_newWords);

            foreach (var s in wordList)
            {
                Console.WriteLine("\nThe Reversed Sentance :" + s);
            }

        }

        public void JoinStrings()
        {
            Console.WriteLine($"\nThe Joined String is :{_newSentance},{_newSentance1}");

        }

        public void FindCharOccurrence()
        {
            char index = _newSentance[8]; 

            int count = _newSentance.Count(x => (x == index));

            Console.WriteLine($"\nThe Character at 8th Index is :{index}\n\nThe Number of Occurrence in the String is :{count}");
        }
        public void ProcessString(StringHandler process)
        {
            process();

        }
    }
}
