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
            StringBuilder sb = new StringBuilder();
            if (this is MainCharacter)
            {
                sb.AppendLine("You have:");
            }
            else
            {
                sb.AppendLine(ShortDescription + " has:");
            }
            
            if (Inventory.Count > 0)
            {
                foreach (Item item in Inventory)
                {
                    sb.AppendLine("- a " + item.ShortDescription);
                }
            }
            else
            {
                sb.AppendLine("- Absolutely nothing");
            }
            return sb.ToString();
        }
    }
}
