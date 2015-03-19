using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class Command
    {
        public bool ParsedSuccessfully { get; protected set; }
        public string Target { get; protected set; }

        protected Command(int? minArgCount, int? maxArgCount, string[] matchingCommandStarters, string[] commandWords)
        {
            ParsedSuccessfully = false;

            // Check args
            if (minArgCount.HasValue && commandWords.Length < minArgCount.Value)
            {
                return;
            }
            if (maxArgCount.HasValue && commandWords.Length > maxArgCount.Value)
            {
                return;
            }
            if (!matchingCommandStarters.Contains(commandWords[0]))
            {
                return;
            }

            // Try to parse the command
            try
            {
                ParsedSuccessfully = ParseCommand(commandWords);
            }
            catch (Exception e)
            {
                ParsedSuccessfully = false;
            }
        }

        protected virtual bool ParseCommand(string[] commandWords) { return true; }
        public abstract string Execute(GameContext context);
    }
}
