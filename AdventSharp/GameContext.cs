using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventSharp
{
    public abstract class GameContext
    {
        #region Properties

        public List<Place> Map { get; private set; }
        public MainCharacter MainCharacter { get; private set; }

        #endregion

        #region Ctors

        protected GameContext(Map map, MainCharacter mainCharacter)
        {
            // Validate map
            if (map == null)
            {
                throw new ArgumentNullException("Cannot have a null map");
            }
            if (map.Places.Count == 0)
            {
                throw new ArgumentNullException("Cannot have an empty map");
            }
            map.RespawnPoint = map.RespawnPoint ?? map.Places[0];

            // Validate MC
            if (mainCharacter == null)
            {
                throw new ArgumentNullException("Cannot have a null main character");
            }

            MainCharacter = mainCharacter;
            MainCharacter.MoveTo(map.RespawnPoint);
        }

        #endregion
    }
}
