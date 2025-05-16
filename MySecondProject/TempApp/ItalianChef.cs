using System;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef can make pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes pizza pam");
        }

    }
}