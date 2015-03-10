using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public static class Extensions
    {
        public static string ToString(this RelativeDirection direction)
        {
            switch (direction)
            {
                case RelativeDirection.Down:
                    return "below";
                case RelativeDirection.East:
                    return "to the east";
                case RelativeDirection.North:
                    return "to the north";
                case RelativeDirection.South:
                    return "to the south";
                case RelativeDirection.Up:
                    return "above";
                case RelativeDirection.West:
                    return "to the west";
                default:
                    return "somewhere around";
            }
        }

        public static string CapitalizeFirstLetter(this string thisString)
        {
            if (thisString == null)
            {
                return null;
            }
            else
            {
                return Char.ToUpperInvariant(thisString[0]) + thisString.Substring(1);
            }
        }
    }
}
