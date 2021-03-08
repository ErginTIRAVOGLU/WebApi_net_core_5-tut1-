using MultiBazaar.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiBazaar.WebApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command { Id = 0, HowTo = "Boil and egg 0", Line = "Boil water 0", Platform = "Kettle & Pan" },
                 new Command { Id = 1, HowTo = "Boil and egg 1", Line = "Boil water 1", Platform = "Kettle & Pan" },
                 new Command { Id = 2, HowTo = "Boil and egg 2", Line = "Boil water 2", Platform = "Kettle & Pan" }
            };
            return commands;
        }

     

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
