using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            

            StringManipulation object1= new StringManipulation();

            object1.MyString = "Success in life is not for those who run fast" ;

            object1.MyString1 = "but for those who keep running and always on the move";

            StringManipulation.StringHandler handler = object1.ReplaceCharacter;
            handler += object1.ReverseSentance;
            handler += object1.JoinStrings;
            handler += object1.FindCharOccurrence;

            object1.ProcessString(handler);



        }
    }
}
