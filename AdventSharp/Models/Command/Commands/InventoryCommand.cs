using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class InventoryCommand : Command
    {
        private static readonly string[] INVENTORY_COMMAND_WORDS = new string[] 
        {
            "inventory"
        };
        
        public InventoryCommand(string[] commandWords)
            : base(1, 1, INVENTORY_COMMAND_WORDS, commandWords)
        {

        }
        
        public override string Execute(GameContext context)
        {
            if (context.MainCharacter.Inventory.Count == 0)
            {
                return "You do not have anything";
            }
            else
            {
                return "You have:\r\n" + context.MainCharacter.ListInventory();
            }
        }
    }
}
