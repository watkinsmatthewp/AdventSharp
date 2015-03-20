using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class MoveCommand : Command
    {
        public RelativeDirection Direction { get; private set; }
        
        private static readonly string[] MOVE_COMMANDS = new string[] 
        { 
            "move", 
            "walk", 
            "run",
            "go",
        };

        private static readonly string[] DIRECTION_SHORTCUTS = new string[] 
        {
            // Direction shortcuts
            "in", 
            "out", 
            "up", 
            "down",
            "north", 
            "south",
            "east",
            "west",

            // Direction super shortcuts
            "u",
            "d",
            "n", 
            "s", 
            "e", 
            "w", 
        };

        public MoveCommand(string[] commandWords)
            : base(1, 2, MOVE_COMMANDS.Union(DIRECTION_SHORTCUTS).ToArray(), commandWords)
        {
            
        }
        
        protected override bool ParseCommand(string[] commandWords)
        {
            if (commandWords.Length == 1)
            {
                if (DIRECTION_SHORTCUTS.Contains(commandWords[0]))
                {
                    // Ex. "s"
                    Direction = commandWords[0].ParseDirection();
                    return true;
                }
            }
            else
            {
                if (DIRECTION_SHORTCUTS.Contains(commandWords[1]))
                {
                    // Ex. "go south"
                    Direction = commandWords[1].ParseDirection();
                    return true;
                }
            }
            
            return false;
        }

        public override string Execute(GameContext Context)
        {
            Context.MainCharacter.MoveInDirection(Direction);
            return "You moved";
        }
    }
}
