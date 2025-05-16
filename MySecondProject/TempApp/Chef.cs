using System;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Chef can make chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Chef can make salad");
        }

        // virtual keyword is used to override a method during inheritance
        // written virtual in defn method means the method can be overwritten when defining a subclass
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }
}