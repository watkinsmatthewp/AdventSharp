using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class MainCharacter : GameCharacter
    {
        public MainCharacter(string description)
            : base(true, description)
        {

        }

        public override void OnLeave(Place location)
        {
            location.Visited = true;
        }

        public string LookAround()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("You are in ");
            if (this.CurrentLocation.IsUnique)
            {
                sb.Append(this.CurrentLocation.ShortDescription.CapitalizeFirstLetter());
            }
            else
            {
                sb.Append("a " + this.CurrentLocation.ShortDescription);
            }
            
            if (this.CurrentLocation.Contents.Count > 0)
            {
                foreach (Thing thing in this.CurrentLocation.Contents.Where(c => c != this))
                {
                    sb.Append("\n");
                    if (thing.IsUnique)
                    {
                        sb.AppendFormat("{0} is", thing.ShortDescription.CapitalizeFirstLetter());
                    }
                    else
                    {
                        sb.AppendFormat("There is a {0}", thing.ShortDescription);
                    }
                    sb.Append(" here.");
                }
            }
            if (this.CurrentLocation.Exits.Count > 0)
            {
                foreach (KeyValuePair<RelativeDirection, Exit> exit in this.CurrentLocation.Exits)
                {
                    if (!exit.Value.Visible)
                    {
                        sb.AppendFormat("\n{0} is {1}.", exit.Key.ToString().CapitalizeFirstLetter(), exit.Value.ShortDescription);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
