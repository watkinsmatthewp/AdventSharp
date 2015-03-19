using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class GetCommand : Command
    {
        private static readonly string[] GET_COMMANDS = new string[] 
        { 
            "get", 
            "take", 
            "steal", 
            "retrieve",
            "pick",
            "lift"
        };
        
        public GetCommand(string[] commandWords) 
            : base(2, 2, GET_COMMANDS, commandWords)
        {
            
        }
        
        protected override bool ParseCommand(string[] commandWords)
        {
            Target = commandWords[1];
            return true;
        }

        public override string Execute(GameContext context)
        {
            Item itemToGet = context.MainCharacter.CurrentLocation.Contents.FirstOrDefault(t => 
                t is Item && t.ShortDescription.Equals(Target)) as Item;
            if (itemToGet == null)
            {
                return "Nothing to get with that name";
            }
            else
            {
                if (context.MainCharacter.Inventory.Contains(itemToGet))
                {
                    return "You already have it";
                }
                else
                {
                    context.MainCharacter.Inventory.Add(itemToGet);
                    context.MainCharacter.CurrentLocation.Contents.Remove(itemToGet);
                    return "Got it";
                }
            }
        }
    }
}
