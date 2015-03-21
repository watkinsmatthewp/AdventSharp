using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class GameCharacter : ItemGroup
    {
        public double HealthPercent { get; set; }

        public bool IsAlive
        {
            get
            {
                return HealthPercent > 0;
            }
        }

        public GameCharacter(bool isUnique, string description)
            : base(isUnique, description)
        {
            HealthPercent = 1;
        }

        public string ListInventory()
        {
            if (Inventory.Count == 0)
            {
                return "nothing";
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (Item item in Inventory)
            {
                sb.AppendLine("- " + item.ShortDescription);
            }
            return sb.ToString();
        }
    }
}
