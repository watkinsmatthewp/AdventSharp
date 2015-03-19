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

        public void MoveInDirection(RelativeDirection direction)
        {
            if (CurrentLocation.Exits.ContainsKey(direction))
            {
                MoveTo(CurrentLocation.Exits[direction]);
            }
            else
            {
                Console.WriteLine("Can't go there");
            }
        }
        
        public void MoveTo(Place destination)
        {
            if (CurrentLocation != null)
            {
                OnLeave(CurrentLocation);
            } 
            destination.Contents.Add(this);
            this.CurrentLocation = destination;
            OnArrive(destination);
        }

        #region Virtual methods

        public virtual void OnLeave(Place destination) { }
        public virtual void OnArrive(Place destination) { }

        #endregion
    }
}
