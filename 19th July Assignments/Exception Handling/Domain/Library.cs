using System;
using System.Text;

namespace Domain
{
    public class Library
    {
        public static string Occurance(string text)
        {
            StringBuilder builder = new StringBuilder("This is my Sample text occurance");

            if (builder.ToString().Contains(text))
            {
                return "'Subtext Found' in Text Occurance";
            }
            else
            {
                throw new TextNotFoundException("Sub Text Not Found");
            }
        }  
    }

    public class TextNotFoundException : Exception
    {
        public TextNotFoundException(string message) : base(message)
        {

        }
    }
}
