using Microsoft.EntityFrameworkCore;
using MultiBazaar.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiBazaar.WebApi.Data
{
    public class CommanderContext:DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options): base(options)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
