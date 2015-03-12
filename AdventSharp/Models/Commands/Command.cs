using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class Command
    {
        public string Execute(GameContext Context)
        {
            throw new NotImplementedException();
        }
    }
}
