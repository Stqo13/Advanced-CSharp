using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
			this.Name = name;
			this.NumberOfBadges = 0;
			this.Pokemons = new List<Pokemon>();
        }
        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int numberOfBadges;

		public int NumberOfBadges
        {
			get { return numberOfBadges; }
			set { numberOfBadges = value; }
		}
		private List<Pokemon> pokemons;

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
			set { pokemons = value; }
		}

	}
}
