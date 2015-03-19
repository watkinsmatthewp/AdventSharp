using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp.ExampleGame
{
    public class ExampleGame : AdventureGame<ExampleGameContext, ExampleGameCommandParser>
    {
        public ExampleGame()
            : base("Example Game", new ExampleGameContext(), new ExampleGameCommandParser())
        {

        }
    }
}
