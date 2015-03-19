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

        private static List<Place> CreateMap()
        {
            Place tardisConsole = new Place(true, "Tardis Engine Room");
            Place tardisHallway = new Place(true, "Tardis Hallway");
            Place tardisLibrary = new Place(true, "Tardis Library");
            Place tardisSwimmingPool = new Place(true, "Tardis Swimming Pool");

            tardisConsole.Exits.Add(RelativeDirection.Down, tardisHallway);
            tardisHallway.Exits.Add(RelativeDirection.Up, tardisConsole);

            tardisHallway.Exits.Add(RelativeDirection.North, tardisLibrary);
            tardisLibrary.Exits.Add(RelativeDirection.South, tardisHallway);

            tardisHallway.Exits.Add(RelativeDirection.South, tardisSwimmingPool);
            tardisSwimmingPool.Exits.Add(RelativeDirection.North, tardisHallway);

            return new List<Place>()
            {
                tardisConsole,
                tardisHallway,
                tardisLibrary,
                tardisSwimmingPool
            };
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
