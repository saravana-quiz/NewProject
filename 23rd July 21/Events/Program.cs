using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManipulation manipulationObject = new StringManipulation();
            manipulationObject.StringEvents += manipulationObject.ReplaceCharacter;
            manipulationObject.StringEvents += manipulationObject.ReverseSentance;
            manipulationObject.StringEvents += manipulationObject.JoinStrings;
            manipulationObject.StringEvents += manipulationObject.FindCharOccurrence;
            manipulationObject.ProcessString();
        }
        
    }
}
