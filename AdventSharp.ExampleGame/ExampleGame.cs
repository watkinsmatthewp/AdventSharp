using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp.ExampleGame
{
    public class ExampleGame
    {
        public void Start()
        {            
            Place meadow = new Place(false, "grassy meadow");

            MainCharacter mc = new MainCharacter("you");
            mc.MoveTo(meadow);
            mc.Inventory.Add(new Item(false, "small sword"));

            GameCharacter elf = new GameCharacter(false, "elf");
            elf.MoveTo(meadow);

            Item shield = new Item(false, "shield");
            shield.MoveTo(meadow);

            Console.WriteLine(mc.LookAround());
            Console.WriteLine(mc.ListInventory());
            Console.ReadKey();
        }
    }
}
