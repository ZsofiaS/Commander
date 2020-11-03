using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data

{
    // creating a class that will implement the repo interface
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & pan"},
                new Command{Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Chopping board"},
                new Command{Id = 2, HowTo = "Make coffee", Line = "Add coffee", Platform = "Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            //return new Command(Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan");
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & pan" };
        }
    }
}