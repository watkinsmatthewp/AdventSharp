using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class Exit : Thing
    {
        public Place From { get; private set; }
        public Place To { get; private set; }
        public RelativeDirection Via { get; private set; }
        public bool Visible { get; set; }
        public bool Blocked { get; set; }

        public Exit(string shortDescription, Place from, Place to, RelativeDirection via)
            : this(shortDescription, from, to, via, true)
        {

        }
        
        public Exit(string shortDescription, Place from, Place to, RelativeDirection via, bool visible)
            : base(false, shortDescription)
        {
            From = from;
            To = to;
            Via = via;
            Visible = visible;
            Blocked = false;
        }
    }
}
