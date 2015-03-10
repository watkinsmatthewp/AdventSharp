using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class MovableThing : Thing
    {
        public Place CurrentLocation { get; private set; }
        
        protected MovableThing(bool isUnique, string description)
            : base(isUnique, description)
        {

        }
        
        public void MoveTo(Place destination)
        {
            destination.Contents.Add(this);
            CurrentLocation = destination;
        }
    }
}
