using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class LookCommand : Command
    {
        private static readonly string[] LOOK_COMMAND_WORDS = new string[] 
        {
            "look",
            "l",
            "see",
            "describe",
            "description",
            "watch",
            "observe"
        };
        
        public LookCommand(string[] commandWords)
            : base(1, null, LOOK_COMMAND_WORDS, commandWords)
        {

        }

        public override string Execute(GameContext context)
        {
            return "You are in " + context.MainCharacter.CurrentLocation.Describe();
        }
    }
}
