using System;

namespace Inheritance_Chef
{
    class Program
    {
        static void Main(string[] args)
        {
            var chef = new Chef("Eda", 5);
            
           chef.MakeChicken();


            var italianChef = new ItalianChef("Pedro", 3);
            italianChef.MakePasta();

            italianChef.MakeSpecial();
        }
    }
}
