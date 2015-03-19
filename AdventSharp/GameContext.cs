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

        private Place _respawnPoint;
        public Place RespawnPoint
        {
            get
            {
                return _respawnPoint;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot have a null respawn point");
                }
                _respawnPoint = value;
            }
        }

        #endregion

        #region Ctors

        protected GameContext(List<Place> map, MainCharacter mainCharacter)
            : this(map, mainCharacter, null)
        {

        }
        
        protected GameContext(List<Place> map, MainCharacter mainCharacter, Place respawnPoint)
        {
            // Validate map
            if (map == null)
            {
                throw new ArgumentNullException("Cannot have a null map");
            }
            if (map.Count== 0)
            {
                throw new ArgumentNullException("Cannot have an empty map");
            }

            // Validate MC
            if (mainCharacter == null)
            {
                throw new ArgumentNullException("Cannot have a null main character");
            }

            RespawnPoint = respawnPoint ?? map[0];
            MainCharacter = mainCharacter;
            MainCharacter.MoveTo(RespawnPoint);
        }

        #endregion
    }
}
