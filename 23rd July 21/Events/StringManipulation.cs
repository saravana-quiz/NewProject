using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class StringManipulation
    {
        

        private string _newWords = "";

        public event EventHandler<ProcessEventAgrs> StringEvents;
        public void ReplaceCharacter(object s, ProcessEventAgrs eventsArgs)
        {

            string message = eventsArgs.MyString.Replace(' ', '_');

            Console.WriteLine("The ' ' is Replaced with '_' in the given Sentance :\n" + message);
        }

        public void ReverseSentance(object s, ProcessEventAgrs eventsArgs)
        {
            List<string> wordList = new List<string>();

            string[] words = eventsArgs.MyString.Split(new[] { ' ' });

            for (int i = words.Length - 1; i >= 0; i--)
            {
                _newWords += words[i] + " ";
            }

            wordList.Add(_newWords);

            foreach (var val in wordList)
            {
                Console.WriteLine("\nThe Reversed Sentance :" + val);
            }

        }

        public void JoinStrings(object s, ProcessEventAgrs eventsArgs)
        {
            Console.WriteLine($"\nThe Joined String is :{eventsArgs.MyString},{eventsArgs.MyString1}");

        }

        public void FindCharOccurrence(object s, ProcessEventAgrs eventsArgs)
        {
            char index = eventsArgs.MyString[8];

            int count = eventsArgs.MyString.Count(x => (x == index));

            Console.WriteLine($"\nThe Character at 8th Index is :{index}\n\nThe Number of Occurrence in the String is :{count}");
        }

        public void ProcessString()
        {
            ProcessEventAgrs object1 = new ProcessEventAgrs();

            object1.MyString = "Magic always happens";
            object1.MyString1 = "when you direct your inner powers to the object you want to change";
            OnProcessString(object1);

        }

        protected virtual void OnProcessString(ProcessEventAgrs eventAgrs)
        {
            StringEvents?.Invoke(this, eventAgrs);
        }
    }
}
