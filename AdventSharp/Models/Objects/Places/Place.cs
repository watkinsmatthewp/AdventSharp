using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class Place : Thing
    {
        public Dictionary<RelativeDirection, Place> Exits { get; private set; }
        public List<Thing> Contents { get; private set; }
        public bool Visited { get; set; }

        public Place(bool isUnique, string description)
            : base(isUnique, description)
        {
            Exits = new Dictionary<RelativeDirection, Place>();
            Contents = new List<Thing>();
        }
    }
}
