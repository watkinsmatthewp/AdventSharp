using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class AdventureGame<C, P>
        where C : GameContext
        where P : CommandParser
    {       
        #region Public Properties

        public string GameTitle { get; private set; }       
        public C Context { get; private set; }

        public virtual string GameDescription { get { return "A great game"; } }

        protected P CommandParser { get; private set; }

        #endregion

        protected AdventureGame(string gameTitle, C context, P commandParser)
        {
            GameTitle = gameTitle;
            Context = context;
            CommandParser = commandParser;
        }

        #region Public methods

        public string EnterCommand(string commandText)
        {
            string[] commandWords = commandText == null ? new string[0] : commandText.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLowerInvariant()).ToArray();
            if (commandWords.Length == 0)
            {
                return "No command specified";
            }
            else
            {
                Command parsedCommand = CommandParser.ParseCommand(commandWords);
                if (!parsedCommand.ParsedSuccessfully)
                {
                    return "I don't understand what you're trying to tell me. Type 'help' to get an example list of commands";
                }

                return parsedCommand.Execute(Context);
            }
        }

        #endregion

        #region Overridable methods

        public virtual string Start()
        {
            return EnterCommand("look");
        }

        #endregion
    }
}
