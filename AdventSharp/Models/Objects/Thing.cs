using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class Thing
    {
        public bool IsUnique { get; private set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        protected Thing(bool isUnique, string name)
        {
            IsUnique = isUnique;
            Name = name;
            LongDescription = ShortDescription = (IsUnique ? "the" : Name[0].IsVowel() ? "an" : "a") + " " + Name;
        }
    }
}
