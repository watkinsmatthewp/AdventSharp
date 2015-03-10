using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class ItemGroup : Item
    {
        public List<Item> Inventory { get; private set; }

        public ItemGroup(bool isUnique, string containerName)
            : base(isUnique, containerName)
        {
            Inventory = new List<Item>();
        }
    }
}
