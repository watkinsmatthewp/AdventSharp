using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class Item : MovableThing
    {
        public Item(bool isUnique, string description)
            : base(isUnique, description)
        {
            
        }
    }
}
