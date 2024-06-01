using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Interfaces
{
    internal interface IMoveable
    {
        abstract void Move5(); //default is abstract

        //Default Implemantation
        void Move10() 
        {
            Console.WriteLine("Move 10 units");
        }
    }
}
