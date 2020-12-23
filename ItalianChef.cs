using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Chef
{
    class ItalianChef :Chef
    {
        public string cuisine; 
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
        public override void MakeSpecial()
        {
            Console.WriteLine("The Chef makes Gnochi");
        }

    }
}
