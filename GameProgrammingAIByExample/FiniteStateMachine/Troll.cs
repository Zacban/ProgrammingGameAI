using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiniteStateMachine
{
    public class Troll
    {
        protected State CurrentState;

        public void Update()
        {
            CurrentState.Execute(this);
        }

        public void ChangeState(State NewState)
        {
            CurrentState = NewState;
        }

        public bool IsSafe { get; set; }

        internal void MoveAwayFromEnemy()
        {
            throw new NotImplementedException();
        }

        public bool IsThreatened { get; set; }

        internal void Snore()
        {
            throw new NotImplementedException();
        }
    }
}
