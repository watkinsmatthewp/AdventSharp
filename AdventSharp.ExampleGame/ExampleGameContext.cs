using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp.ExampleGame
{
    public class ExampleGameContext : GameContext
    {
        public ExampleGameContext() : 
            base(CreateMap(), CreateMainCharacter())
        {

        }

        private static Map CreateMap()
        {
            Map map = new Map();
            
            Place tardisConsole = map.AddPlace(new Place(true, "Tardis Engine Room"));
            Place tardisHallway = map.AddPlace(new Place(true, "Tardis Hallway"));
            Place tardisLibrary = map.AddPlace(new Place(true, "Tardis Library"));
            Place tardisSwimmingPool = map.AddPlace(new Place(true, "Tardis Swimming Pool"));

            map.AddBidirectionalExits(tardisConsole, tardisHallway, RelativeDirection.Down, "staircase leading down", "staircase leading up");
            map.AddBidirectionalExits(tardisHallway, tardisLibrary, RelativeDirection.North, "winding passageway");
            map.AddBidirectionalExits(tardisHallway, tardisSwimmingPool, RelativeDirection.South, "tiled passageway");

            return map;
        }

        private static MainCharacter CreateMainCharacter()
        {
            MainCharacter mc = new MainCharacter("the Doctor");
            mc.Inventory.Add(new Item(false, "sonic screwdriver"));
            mc.Inventory.Add(new Item(false, "fez"));
            return mc;
        }
    }
}
