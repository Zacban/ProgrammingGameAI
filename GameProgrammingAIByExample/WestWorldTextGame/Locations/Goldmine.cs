using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWorldTextGame.Locations
{
    public class Goldmine : Location
    {
        private static Goldmine _Instance;
        public static Goldmine Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Goldmine();
                }

                return _Instance;
            }
        }

        private Goldmine() : base() { }
    }
}
