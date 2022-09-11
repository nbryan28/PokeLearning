using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.ILogic
{
    public interface IBasicMoves
    {
        Tuple<int, string> Tackle(int level);
        Tuple<int, string> TailWhip(int level);
        Tuple<int, string> Growl(int level);
 


    }
}
