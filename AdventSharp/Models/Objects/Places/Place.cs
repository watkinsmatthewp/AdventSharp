using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public class Place : Thing
    {
        public Dictionary<RelativeDirection, Exit> Exits { get; private set; }
        public List<Thing> Contents { get; private set; }
        public bool Visited { get; set; }

        public Place(bool isUnique, string description)
            : base(isUnique, description)
        {
            Exits = new Dictionary<RelativeDirection, Exit>();
            Contents = new List<Thing>();
        }

        public void AddExit(string shortDescription, Place to, RelativeDirection via)
        {
            AddExit(new Exit(shortDescription, this, to, via));
        }
        
        public void AddExit(string shortDescription, Place to, RelativeDirection via, bool hidden)
        {
            AddExit(new Exit(shortDescription, this, to, via, hidden));
        }

        public void AddExit(Exit exit)
        {
            Exits.Add(exit.Via, exit);
        }

        public string Describe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.LongDescription);
            foreach (KeyValuePair<RelativeDirection, Exit> exit in this.Exits)
            {
                sb.AppendLine(String.Format("{0} is {1}", exit.Key.GetString().CapitalizeFirstLetter(), exit.Value.LongDescription));
            }
            foreach (Thing item in this.Contents.Where(i => !(i is MainCharacter)))
            {
                sb.AppendLine("There is " + item + " here");
            }
            return sb.ToString();
        }
    }
}
