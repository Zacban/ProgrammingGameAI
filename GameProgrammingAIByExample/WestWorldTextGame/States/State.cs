using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWorldTextGame.Entities;

namespace WestWorldTextGame.States
{
    public class State<E> where E : BaseGameEntity
    {
        public abstract void Enter(E entity);
        public abstract void Execute(E entity);
        public abstract void Leave(E entity);
    }
}
