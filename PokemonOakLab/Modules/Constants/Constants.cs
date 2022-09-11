using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Constants
{
    public class Constants
    {
        public const int TotalPokemom = 151;

        public const string pathImage = "C:\\Users\\n_bry\\source\\repos\\PokemonOakLab\\PokemonOakLab\\Modules\\Sprites\\";

        public static List<string> typePokemons = new List<string>()
        {
            "NORMAL",
            "FIRE",
            "WATER",
            "GRASS",
            "ELECTRIC",
            "DRAGON",
            "GHOST",
            "GROUND",
            "BUG",
            "PSYCHIC",
            "ICE",
            "ROCK",
            "FIGHTING",
            "FLYING"
        };

      
      


        enum CategoryAttack
        {
            Physical,
            Special,
            Status
        }
    }
}
