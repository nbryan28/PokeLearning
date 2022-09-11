using PokemonOakLab.Modules.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Pokemon
{
    public class Pokemon
    {
        private Guid Guid;

        private string _name;
        public string Name
        {
            get{ return _name; }
            set { _name = value; }
        }

        private string _height;
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private List<string> _moveList;

        public List<string> MoveList
        {
            get { return _moveList; }
            set { _moveList = value; }
        }

        private List<string> _typeList;

        public List<string> TypeList
        {
            get { return _typeList; }
            set { _typeList = value; }
        }

        private Pokemon? _preEvolution;
        public Pokemon? PreEvolution
        {
            get
            {
                if (_preEvolution == null)
                {
                    return null;
                }
                else
                {
                    return _preEvolution;
                }

            }
            set { _preEvolution = value; }
        }

        private Pokemon? _evolution;
        public Pokemon? Evolution
        {
            get
            {
                if (_evolution == null)
                {
                    return null;
                }
                else
                {
                    return _evolution;
                }
            }
            set { _evolution = value; }
        }

        public Pokemon(string name, string height, string description, List<string> moveList, List<string> typeList, string preEvolution , string evolution)
        {
            this._name = name;
            this._height = height;
            this._description = description;
            this._moveList = moveList;
            this._typeList = typeList;
            this.Guid = Guid.NewGuid();

        }
    }
}
