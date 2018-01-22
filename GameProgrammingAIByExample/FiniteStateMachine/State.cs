using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine
{
    public abstract class State
    {
        public abstract virtual void Execute(Troll troll);
    }

    public class RunAwayState : State
    {
        public override void Execute(Troll troll)
        {
            if (troll.IsSafe)
            {
                troll.ChangeState(new SleepState());
            }
            else
            {
                troll.MoveAwayFromEnemy();
            }
        }
    }

    public class SleepState : State
    {
        public override void Execute(Troll troll)
        {
            if (troll.IsThreatened)
            {
                troll.ChangeState(new RunAwayState());
            }
            else
            {
                troll.Snore();
            }
        }
    }

}
