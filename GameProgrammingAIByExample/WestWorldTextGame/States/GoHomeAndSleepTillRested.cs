using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWorldTextGame.Entities;

namespace WestWorldTextGame.States
{
    public class GoHomeAndSleepTillRested : State<Miner>
    {
        private static GoHomeAndSleepTillRested _Instance;
        public static GoHomeAndSleepTillRested Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new GoHomeAndSleepTillRested();
                }

                return _Instance;
            }
        }

        private GoHomeAndSleepTillRested() : base() { }

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
