using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class Map
    {
        public List<Place> Places { get; private set; }
        public Place RespawnPoint { get; set; }

        public Map(Place startingPoint)
            : this()
        {
            Places.Add(startingPoint);
            RespawnPoint = startingPoint;
        }
        
        public Map()
        {
            Places = new List<Place>();
        }

        public Place AddPlace(Place place)
        {
            if (!Places.Contains(place))
            {
                Places.Add(place);
            }
            return place;
        }

        public void AddBidirectionalExits(Place from, Place to, RelativeDirection via, string shortDescription)
        {
            AddBidirectionalExits(from, to, via, shortDescription, shortDescription, false, false);
        }

        
        public void AddBidirectionalExits(Place from, Place to, RelativeDirection via, string fromShortDescription, string toShortDescription)
        {
            AddBidirectionalExits(from, to, via, fromShortDescription, toShortDescription, false, false);
        }

        public void AddBidirectionalExits(Place from, Place to, RelativeDirection via, string fromShortDescription, string toShortDescription, bool fromHidden, bool toHidden)
        {
            from.AddExit(fromShortDescription, to, via, fromHidden);
            to.AddExit(toShortDescription, from, via.Opposite(), toHidden);
        }
    }
}
