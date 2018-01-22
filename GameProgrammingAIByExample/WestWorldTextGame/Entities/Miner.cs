using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWorldTextGame.Locations;
using WestWorldTextGame.States;

namespace WestWorldTextGame.Entities
{
    public class Miner : BaseGameEntity
    {
        protected State<Miner> CurrentState { get; set; }
        public Location Location { get; set; }

        protected int GoldNuggets { get; set; }
        protected int MoneyInBank { get; set; }
        protected int Thirst { get; set; }
        protected int Fatigue { get; set; }

        public Miner(int id) : base (id)
        {

        }

        public override void Update()
        {
            Thirst++;
            if (CurrentState != null)
            {
                CurrentState.Execute(this);
            }
        }

        public void ChangeState(State<Miner> NewState)
        {
            if (CurrentState != null && NewState != null)
            {
                CurrentState.Leave(this);
                CurrentState = NewState;
                CurrentState.Enter(this);
            }
        }

        internal void ChangeLocation(Location loc)
        {
            this.Location = loc;
        }

        internal void AddGoldToCarried(int p)
        {
            throw new NotImplementedException();
        }

        internal void IncreaseFatigue()
        {
            throw new NotImplementedException();
        }

        public bool PocketsFull
        {
            get
            {
                return GoldNuggets >= 100;
            }
        }

        public bool Thirsty {
            get
            {
                return Thirst >= 50;
            }
        }
    }
}
