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
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        protected Thing(bool isUnique, string shortDescription)
        {
            IsUnique = isUnique;
            ShortDescription = shortDescription ?? String.Empty;
            LongDescription = ShortDescription;
        }

        public virtual string GetFullDescription()
        {
            return (IsUnique ? "the " : "a/n ") + ShortDescription;
        }
    }
}
