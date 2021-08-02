using System;

namespace List_Manipulation_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Process process = new Process();
            process.Add(106, "Saran", 4, 12000, "saran@test.com");
            process.Delete(106, "Saran", 4, 12000, "saran@test.com");
            process.Update(4,106, "Saran", 4, 12000, "saran@test.com");
            process.Sort();
            process.Clear();

        }
    }
}
