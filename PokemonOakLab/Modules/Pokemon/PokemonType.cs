using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Pokemon
{
    public class PokemonType
    {

        private List<string> _advantage;

        public List<string> Advantage
        {
            get { return _advantage; }
            set { _advantage = value; }
        }

        private List<string> _disadvantage;

        public List<string> Disadvantage
        {
            get { return _disadvantage; }
            set { _disadvantage = value; }
        }


    }
}
