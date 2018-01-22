using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWorldTextGame.Entities;
using WestWorldTextGame.Locations;

namespace WestWorldTextGame.States
{
    public class EnterMineAndDigForNuggets : State<Miner>
    {
        private static EnterMineAndDigForNuggets _Instance;
        public static EnterMineAndDigForNuggets Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new EnterMineAndDigForNuggets();
                }

                return _Instance;
            }
        }

        private EnterMineAndDigForNuggets() : base() { }

        public override void Enter(Miner entity)
        {
            if (!(entity.Location is Goldmine))
            {
                Console.WriteLine("Walking to the mine");
                entity.ChangeLocation(Goldmine.Instance);
            }
        }

        public override void Execute(Miner entity)
        {
            // the miner digs for gold until he is carrying in excess of maxnuggets
            // If he gets thirsty during his digging he stops work and
            // changes state to go to the saloon and have a drink.
            var nuggetsfound = new Random().Next(3);
            entity.AddGoldToCarried(nuggetsfound);

            // Digging is hard work
            entity.IncreaseFatigue();

            Console.WriteLine(string.Format("{0}: Picking up {1} nugget{2}!", entity.ID, nuggetsfound == 1 ? "a" : nuggetsfound.ToString(), nuggetsfound != 1 ? "s" : string.Empty));

            // if enough gold mined. Move to the bank
            if (entity.PocketsFull)
            {
                entity.ChangeState(VisitBankAndDepositGold.Instance);
            }
            else if (entity.Thirsty)
            {
                entity.ChangeState(QuenchThirst.Instance);
            }
        }

        public override void Leave(Miner entity)
        {
            Console.WriteLine(string.Format("{0}: I am leaving my goldmine with my pockets full of nuggets", entity.ID));
        }
    }
}
