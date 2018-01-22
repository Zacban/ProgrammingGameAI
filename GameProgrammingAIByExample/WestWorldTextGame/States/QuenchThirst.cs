using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWorldTextGame.Entities;

namespace WestWorldTextGame.States
{
    public class QuenchThirst : State<Miner>
    {
        private static QuenchThirst _Instance;
        public static QuenchThirst Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QuenchThirst();
                }

                return _Instance;
            }
        }

        private QuenchThirst() : base() { }

        public override void Enter(Miner entity)
        {
            throw new NotImplementedException();
        }

        public override void Execute(Miner entity)
        {
            throw new NotImplementedException();
        }

        public override void Leave(Miner entity)
        {
            throw new NotImplementedException();
        }
    }
}
