using PokemonOakLab.Modules.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Logic
{
    public class BasicMoves : IBasicMoves
    {
        public Tuple<int, string> Growl(int level)
        {
            return Tuple.Create(100, "Woof Woof");
        }

        public Tuple<int, string> Tackle(int level)
        {
            return Tuple.Create(30, "Kaboom");
        }

        public Tuple<int, string> TailWhip(int level)
        {
            return Tuple.Create(40, "I am whipping my tail wig wig");
        }
    }
}
