using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWorldTextGame.Entities
{
    public abstract class BaseGameEntity
    {
        /// <summary>
        /// Every Entity has a unique identifying number
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// This is the next valid ID. Each time a BaseGameEntity is instantiated
        /// this value is updated
        /// </summary>
        protected int NextValidID { get; set; }

        public BaseGameEntity(int id)
        {
            if (id < NextValidID)
                throw new Exception("Invalid ID provided");

            this.ID = id;
            NextValidID = ++this.ID;
        }

        public abstract void Update();
    }
}
