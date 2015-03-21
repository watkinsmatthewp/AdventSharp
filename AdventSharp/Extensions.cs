using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public static class Extensions
    {
        #region Directions

        private static readonly Dictionary<RelativeDirection, RelativeDirection> _oppositeMappings = new Dictionary<RelativeDirection, RelativeDirection>()
        {
            { RelativeDirection.In, RelativeDirection.Out },
            { RelativeDirection.Down, RelativeDirection.Up },
            { RelativeDirection.North, RelativeDirection.South},
            { RelativeDirection.East, RelativeDirection.West }
        };

        private static readonly Dictionary<string, RelativeDirection> _directionParseStringMappings = new Dictionary<string, RelativeDirection>()
        {
            { "u", RelativeDirection.Up },
            { "up", RelativeDirection.Up },
            { "d", RelativeDirection.Down },
            { "down", RelativeDirection.Down },
            { "in", RelativeDirection.In },
            { "out", RelativeDirection.Out },
            { "n", RelativeDirection.North },
            { "north", RelativeDirection.North },
            { "s", RelativeDirection.South },
            { "south", RelativeDirection.South },
            { "e", RelativeDirection.East },
            { "east", RelativeDirection.East },
            { "w", RelativeDirection.West },
            { "west", RelativeDirection.West }
        };

        private static readonly Dictionary<RelativeDirection, string> _directionToStringMappings = new Dictionary<RelativeDirection, string>()
        {
            { RelativeDirection.Up, "above" },
            { RelativeDirection.Down, "beneath" },
            { RelativeDirection.In, "inside" },
            { RelativeDirection.Out, "outside"},
            { RelativeDirection.North, "to the north" },
            { RelativeDirection.South, "to the south" },
            { RelativeDirection.East, "to the east" },
            { RelativeDirection.West, "to the west" }
        };

        public static RelativeDirection Opposite(this RelativeDirection direction)
        {
            foreach (KeyValuePair<RelativeDirection, RelativeDirection> oppositeMapping in _oppositeMappings)
            {
                if (direction == oppositeMapping.Key)
                {
                    return oppositeMapping.Value;
                }
                else if (direction == oppositeMapping.Value)
                {
                    return oppositeMapping.Key;
                }
            }

            throw new ArgumentException("Could not get the opposite of " + direction);
        }
        
        public static RelativeDirection ParseDirection(this string directionString)
        {
            if (_directionParseStringMappings.ContainsKey(directionString))
            {
                return _directionParseStringMappings[directionString];
            }

            throw new ArgumentException("Could not parse " + directionString + " as a direction");
        }

        public static string GetString(this RelativeDirection direction)
        {
            if (_directionToStringMappings.ContainsKey(direction))
            {
                return _directionToStringMappings[direction];
            }

            throw new ArgumentException("Could not convert " + direction + " as a string");
        }

        #endregion

        #region strings

        private static readonly char[] VOWELS = new char[] { 'a', 'e', 'i', 'o', 'u' };

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

        public static bool IsVowel(this char c)
        {
            return VOWELS.Contains(c);
        }

        #endregion

        public static bool SharesAnyElementWith<T>(this IList<T> collection1, IList<T> collection2) where T : IComparable
        {
            foreach (T item1 in collection1)
            {
                foreach (T item2 in collection2)
                {
                    if (item1.CompareTo(item2) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
