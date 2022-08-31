using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BIT2.Models;

namespace BIT2.Data
{
    public class BIT2Context : DbContext
    {
        public BIT2Context (DbContextOptions<BIT2Context> options)
            : base(options)
        {
        }

        public DbSet<BIT2.Models.Students> Students { get; set; } = default!;
    }
}
