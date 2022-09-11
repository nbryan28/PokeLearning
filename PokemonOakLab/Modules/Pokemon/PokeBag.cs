using PokemonOakLab.Modules.PokemonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Pokemon
{
    public class PokeBag
    {

        private List<Pokemon> myPokemons;

        public List<Pokemon> MyPokemons
        {
            get { return myPokemons; }
            set { myPokemons = value; }
        }

        public PokeBag()
        {
            myPokemons = new List<Pokemon>();
            myPokemons.Add(new Pokemon("Bulbasaur", "2' 3''", "pokemon that has a leaf on its back", new List<string> { "vine whip"}, new List<string> { "Grass" }, "", "Ivysaur"));
            myPokemons.Add(new Pokemon("Pikachu", "2' 3''", "pokemon mouse", new List<string> { "thudnerbolt" }, new List<string> { "Electric" }, "", "Raichu"));
            myPokemons.Add(new FirePokemon("Charmander", "2' 3''", "pokemon fire tail", new List<string> { "vine whip" }, new List<string> { "Bug" }, "", "Metapod"));
            myPokemons.Add(new Pokemon("Squirtle", "2' 3''", "pokemon turtle", new List<string> { "vine whip" }, new List<string> { "Grass" }, "", "Ivysaur"));
            myPokemons.Add(new FirePokemon("Charizard", "2' 3''", "pokemon fire awesome", new List<string> { "vine whip" }, new List<string> { "Grass" }, "", "Ivysaur"));
            myPokemons.Add(new FirePokemon("Charmeleon", "2' 3''", "pokemon mid level", new List<string> { "vine whip" }, new List<string> { "Grass" }, "", "Ivysaur"));
        }

        public dynamic IChooseYou(string? pokeName)
        {
            if (pokeName != null)
            {
                var poke = myPokemons.FirstOrDefault(p => p.Name == pokeName);         
                if (poke != null)
                    return poke;
            }
           
            return null;
        }
    }
}
