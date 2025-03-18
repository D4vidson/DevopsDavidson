using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevopsDavidson.Models;

namespace DevopsDavidson.Data
{
    public class DevopsDavidsonContext : DbContext
    {
        public DevopsDavidsonContext (DbContextOptions<DevopsDavidsonContext> options)
            : base(options)
        {
        }

        public DbSet<DevopsDavidson.Models.Aluno> Aluno { get; set; } = default!;
    }
}
