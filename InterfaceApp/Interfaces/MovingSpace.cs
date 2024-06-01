using InterfaceApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Interfaces
{
    internal class MovingSpace
    {
        private  readonly IMoveable moveable;

        //Dependency Injection, IoC
        public MovingSpace(IMoveable moveable)
        {
            this.moveable = moveable;
        }

        public void MakeMove5()
        {
            moveable.Move5();
        }

    }
}
