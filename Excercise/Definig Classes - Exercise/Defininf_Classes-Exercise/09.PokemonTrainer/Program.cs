namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Trainer >trainers = new Dictionary<string, Trainer>();
            while (command!= "Tournament")
            {
                string[] commandInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = commandInfo[0];
                Pokemon pokemon = new Pokemon
                    (commandInfo[1], 
                    commandInfo[2],
                    int.Parse(commandInfo[3]));
                if (!trainers.ContainsKey(name))
                {
                    trainers[name] = new Trainer(name);
                }
                trainers[name].Pokemons.Add(pokemon);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command!="End")
            {
                string[] commandInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in trainers.Values)
                {
                    if (item.Pokemons.Any(elemnt => elemnt.Element == commandInfo[0]))
                    {
                        item.NumberOfBadges++;
                    }
                    else
                    {
                        item.Pokemons.ForEach(pokemon => pokemon.Health -= 10);
                        item.Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
                command = Console.ReadLine();
            }
            List<Trainer> sortedTrainers = trainers.Values.OrderByDescending(badges => badges.NumberOfBadges).ToList();
            foreach (var item in sortedTrainers)
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBadges} {item.Pokemons.Count}");
            }
        }
    }
}