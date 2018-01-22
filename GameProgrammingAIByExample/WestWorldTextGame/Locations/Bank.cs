using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWorldTextGame.Locations
{
    public class Bank : Location
    {
        private static Bank _Instance;
        public static Bank Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Bank();
                }

                return _Instance;
            }
        }

        private Bank() : base() { }
    }
}
