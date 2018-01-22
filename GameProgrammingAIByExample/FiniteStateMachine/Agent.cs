using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine
{
    public class Agent
    {
        public enum StateTypes { RunAway, Patrol, Attack }

        public void UpdateStatus(StateTypes CurrentState)
        {
            switch (CurrentState)
            {
                case StateTypes.RunAway:
                    EvadeEnemy();
                    if (Safe())
                    {
                        ChangeState(StateTypes.Patrol);
                    }
                    break;
                case StateTypes.Patrol:
                    FollowPatrolPath();
                    if (Threatened())
                    {
                        if (StrongerThanEnemy())
                        {
                            ChangeState(StateTypes.Attack);
                        }
                        else
                        {
                            ChangeState(StateTypes.RunAway);
                        }
                    }
                    break;
                case StateTypes.Attack:
                    if (WeakerThanEnemy())
                    {
                        ChangeState(StateTypes.RunAway);
                    }
                    else
                    {
                        BashEnemyOverhead();
                    }
                    break;
            }
        }

        private void BashEnemyOverhead()
        {
            throw new NotImplementedException();
        }

        private bool WeakerThanEnemy()
        {
            throw new NotImplementedException();
        }

        private bool StrongerThanEnemy()
        {
            throw new NotImplementedException();
        }

        private bool Threatened()
        {
            throw new NotImplementedException();
        }

        private void FollowPatrolPath()
        {
            throw new NotImplementedException();
        }

        private void ChangeState(StateTypes stateTypes)
        {
            throw new NotImplementedException();
        }

        private bool Safe()
        {
            throw new NotImplementedException();
        }

        private void EvadeEnemy()
        {
            throw new NotImplementedException();
        }
    }
}
