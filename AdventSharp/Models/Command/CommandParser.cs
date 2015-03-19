using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class CommandParser
    {
        public Command ParseCommand(string[] commandWords)
        {
            Command parsedCommand = ParseCommonCommand(commandWords);
            if (!parsedCommand.ParsedSuccessfully)
            {
                parsedCommand = ParseCustomComamnd(commandWords);
            }
            return parsedCommand;
        }

        private Command ParseCommonCommand(string[] commandWords)
        {
            Command parsedCommand = new LookCommand(commandWords);
            if (!parsedCommand.ParsedSuccessfully)
            {
                // Is it a move command?
                parsedCommand = new MoveCommand(commandWords);
            }
            if (!parsedCommand.ParsedSuccessfully)
            {
                // Is it a get command?
                parsedCommand = new GetCommand(commandWords);
            }

            return parsedCommand;
        }

        protected virtual Command ParseCustomComamnd(string[] commandWords) { return null; }
    }
}
