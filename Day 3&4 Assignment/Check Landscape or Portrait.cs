using System;

namespace Check_Landscape_or_Potrait
{
    class Program
    {
        //enum is used to store the Image types value
        enum ImageType
        {
            Portrait, Landscape
        }

        static void Main(string[] args)
        {
            //Getting width and legth of image from thr user
            Console.WriteLine("Enter the Width of the Image: ");

            //COnverting the user input into integer value
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the Image: ");
            var length=Convert.ToInt32(Console.ReadLine());

            //Ternary operator is used to check the type of image
            var image = length > width ? ImageType.Portrait : ImageType.Landscape;

            Console.WriteLine("The Image is: " +image);

        }
    }
}
