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
            return ParseCommonCommand(commandWords) ?? ParseCustomComamnd(commandWords);
        }

        private Command ParseCommonCommand(string[] commandWords)
        {
            throw new NotImplementedException();
        }

        protected virtual Command ParseCustomComamnd(string[] commandWords) { return null; }
    }
}
