using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankManagers> bankManagers = new List<BankManagers>();

            bankManagers.Add(new BankManagers { ID = 1, Age = 25, Name = "Nadhi" });
            bankManagers.Add(new BankManagers { ID = 2, Age = 24, Name = "Roshan" });
            bankManagers.Add(new BankManagers { ID = 3, Age = 32, Name = "Richy Reginald" });
            bankManagers.Add(new BankManagers { ID = 4, Age = 28, Name = "Nicky" });
            bankManagers.Add(new BankManagers { ID = 5, Age = 35, Name = "Shanker" });
            bankManagers.Add(new BankManagers { ID = 6, Age = 38, Name = "Dinesh" });

            List<BankBranches> bankBranches = new List<BankBranches>();

            bankBranches.Add(new BankBranches { ID = 1, BranchName = "SRM UNIVERSITY", MaximumPoint = 6 });
            bankBranches.Add(new BankBranches { ID = 2, BranchName = "Adayar", MaximumPoint = 8 });
            bankBranches.Add(new BankBranches { ID = 3, BranchName = "Kanchipuram", MaximumPoint = 9 });
            bankBranches.Add(new BankBranches { ID = 4, BranchName = "Coimbatore", MaximumPoint = 5 });
            bankBranches.Add(new BankBranches { ID = 5, BranchName = "Madurai", MaximumPoint = 8 });
            bankBranches.Add(new BankBranches { ID = 6, BranchName = "Tirchy", MaximumPoint = 6 });

            var innerJoin = bankManagers.Join(bankBranches, i => i.ID, j => j.ID, (i, j) => new
            {
                ManagerName = i.Name,
                BranchName = j.BranchName

            });

            foreach (var branchList in innerJoin)
            {

                System.Console.WriteLine($"Branch Name :{branchList.BranchName}--Manager Name :{branchList.ManagerName}");
            }
 

            var ageGreaterThenThirty = from managerList in bankManagers
                      join branchList in bankBranches on managerList.ID equals branchList.ID
                      where managerList.Age>30
                      select new { managerList.ID, managerList.Name, branchList.BranchName, branchList.MaximumPoint };

            System.Console.WriteLine("\nManagers Aged Above 30 are:");

            foreach (var age in ageGreaterThenThirty)
            {
                System.Console.WriteLine($"\nID :{age.ID}\nName :{age.Name}\nBranch Name :{age.BranchName}\nMaximum Point :{age.MaximumPoint}");
            }


            var maxPoint = bankBranches.Max(s => s.MaximumPoint);

            var max = from managerList in bankManagers
                      join branchList in bankBranches on managerList.ID equals branchList.ID
                      where branchList.MaximumPoint == maxPoint
                      select new { managerList.ID, managerList.Name, branchList.BranchName, branchList.MaximumPoint };

            foreach (var maxi in max)
            {
                System.Console.WriteLine($"\nMaximum Points Earned by :\n\nID :{maxi.ID}\nName :{maxi.Name}\nBranch Name :{maxi.BranchName}\nMaximum Point :{maxi.MaximumPoint}");
            }


        }
    }
}
