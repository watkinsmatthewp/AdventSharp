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

        //public static bool Contains<T>(this IList<T> collection1, T element) where T : IComparable
        //{
        //    foreach (T item1 in collection1)
        //    {
        //        if (item1.CompareTo(element) == 0)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        public static RelativeDirection ParseDirection(this string directionString)
        {
            switch (directionString)
            {
                case "u":
                case "up":
                    return RelativeDirection.Up;
                case "d":
                case "down":
                    return RelativeDirection.Down;
                case "in":
                    return RelativeDirection.In;
                case "out":
                    return RelativeDirection.Out;
                case "north":
                case "n":
                    return RelativeDirection.North;
                case "south":
                case "s":
                    return RelativeDirection.South;
                case "east":
                case "e":
                    return RelativeDirection.East;
                case "west":
                case "w":
                    return RelativeDirection.West;
                default:
                    throw new ArgumentException("Could not parse direction " + directionString);
            }
        }
    }
}
