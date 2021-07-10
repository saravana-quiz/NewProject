using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*I have a large text, but have to display only 20 characters of the text
and display but ensure you won't break the word appearing in the end.
So It can go a little beyond 20 characters ensuring we won't break the word. */

namespace String_trim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Line to trim: ");
            var stringone = Console.ReadLine();
            //Split method is used to split the Entire line into separate words
            var splitedLine = stringone.Split(' ');
            //New list is created to Add the required index limit values
            var newStringLine = new List<string>();
            var wordIndex = 0;
            var n = 0;
            while(wordIndex < 20)
            {
                //+= operator adds the value of the variable on the left with the value on the right,
                //which is (result) then assigned to the variable that is on the left
                wordIndex += splitedLine[n].Length;
                newStringLine.Add(splitedLine[n]);
                n++;
            }
            foreach(var h in newStringLine)
            {
                Console.Write(h+" ");
            }
        }
    }
}
