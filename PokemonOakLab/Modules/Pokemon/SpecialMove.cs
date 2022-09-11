using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Pokemon
{
    public class SpecialMove
    {
        private string _attackName;

        public string AttackName
        {
            get { return _attackName; }
            set { _attackName = value; }
        }

        private int _power;
        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _category;
        public int Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private PokemonType _typeAttack;
        public PokemonType TypeAttack
        {
            get { return _typeAttack;  }
            set { _typeAttack = value; }
        }



    }
}
