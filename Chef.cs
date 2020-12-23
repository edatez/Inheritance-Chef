using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Chef
{
    class Chef
    {
        public int Rank = 0;
        public string Name = null;


        public Chef(string name, int rank)
        {
            this.Name= name;
            this.Rank = rank;
        }

        public void MakeChicken()
        {
            Console.WriteLine( "The Chef makes chicken" );
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public virtual void MakeSpecial()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        
    }
}
