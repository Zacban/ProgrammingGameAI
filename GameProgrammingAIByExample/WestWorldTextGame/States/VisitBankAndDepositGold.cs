using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWorldTextGame.Entities;

namespace WestWorldTextGame.States
{
    public class VisitBankAndDepositGold : State<Miner>
    {
        private static VisitBankAndDepositGold _Instance;
        public static VisitBankAndDepositGold Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new VisitBankAndDepositGold();
                }

                return _Instance;
            }
        }

        private VisitBankAndDepositGold() : base() { }
        public override void Enter(Miner entity)
        {
            if (!(entity.Location is 
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
