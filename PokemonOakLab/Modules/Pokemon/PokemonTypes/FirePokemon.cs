using PokemonOakLab.Modules.ILogic;
using PokemonOakLab.Modules.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.PokemonTypes
{
    public class FirePokemon : PokemonOakLab.Modules.Pokemon.Pokemon, IBasicMoves
    {


        public FirePokemon(string name, string height, string description, List<string> moveList, List<string> typeList, string preEvolution, string evolution) : base(name, height, description, moveList, typeList, preEvolution, evolution)
        {

        }


        public string WhatDoIhate(out string pokeType)
        {
            pokeType = "water";
            return "I hate water pokemons!";
        }

        public Tuple<int, string> FireBall(int level)
        {
            return Tuple.Create(70, "Burn in hell!");
        }

        public Tuple<int, string> Tackle(int level)
        {
            return Tuple.Create(70, "Fire Tackle");
        }

        public Tuple<int, string> TailWhip(int level)
        {
            return Tuple.Create(70, "Firing whip tail!");
        }

        public Tuple<int, string> Growl(int level)
        {
            return Tuple.Create(70, "I am a scary fire pokemon grrrr!");
        }
    }
}
