using System;

/*You are having an Asset management  program where all your assets - Computer, Laptop, 
 Headphone, Mouse, Dock Station are considered as derived classes.  Users should not be 
 able to create an instance of the base class Asset.  Asset class will have a Configuration 
 method which will be derived classes.   Asset classes can have some defined method like Warranty.   
 Use object oriented programming and design a good solution.*/

namespace Assets_Management
{
    
    abstract class Assets
    {
        public abstract void Configuration();
        public void Warrenty()
        {
            Console.WriteLine("Warrenty Period : One Year Brand Warrenty");
            Console.WriteLine();
        }
    }
    class Computer : Assets
    {

        public override void Configuration()
        {
            Console.WriteLine("Computer Configuration....");
            Console.WriteLine($"Manufacturer : HP\nModel : HP-15 daoo1x\nProcessor : i5-8200U @ 2.80Ghz\nInstalled Memory(RAm): 8GB");
        }
    }
    class Laptop : Assets
    {
        public override void Configuration()
        {
            Console.WriteLine("Laptop Configuration....");
            Console.WriteLine($"Manufacturer : ASUS\nModel : ASUS Laptop-15 daoo22x\nProcessor : i5-11Gen @ 3.80Ghz\nInstalled Memory(RAm): 16GB");
        }

    }
    class Headphone : Assets
    {
        public override void Configuration()
        {
            Console.WriteLine("HeadPhone Configuration....");
            Console.WriteLine($"Manufacturer : Boat\nModel : Boat Rockerzs 335");
        }
    }
    class Mouse : Assets
    {
        public override void Configuration()
        {
            Console.WriteLine("Mouse Configuration....");
            Console.WriteLine($"Manufacturer : LogiTech");
        }
    }
    class DockStation : Assets
    {
        public override void Configuration()
        {
            Console.WriteLine("Dock Station Configuration....");
            Console.WriteLine($"Manufacturer : DELL\nModel : WD19DC");
        }

    }
    class AssestManagement
    {
        public static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Configuration();
            computer.Warrenty();
            Laptop laptop = new Laptop();
            laptop.Configuration();
            laptop.Warrenty();
            Headphone headPhone = new Headphone();
            headPhone.Configuration();
            headPhone.Warrenty();
            Mouse mouse = new Mouse();
            mouse.Configuration();
            mouse.Warrenty();
            DockStation dockStation = new DockStation();
            dockStation.Configuration();
            dockStation.Warrenty();
        }
    }


}
