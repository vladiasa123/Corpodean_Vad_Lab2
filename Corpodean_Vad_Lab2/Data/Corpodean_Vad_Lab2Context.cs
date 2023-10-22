using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Corpodean_Vad_Lab2.Models;

namespace Corpodean_Vad_Lab2.Data
{
    public class Corpodean_Vad_Lab2Context : DbContext
    {
        public Corpodean_Vad_Lab2Context (DbContextOptions<Corpodean_Vad_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Corpodean_Vad_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Corpodean_Vad_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Corpodean_Vad_Lab2.Models.Authors>? Authors { get; set; }
    }
}
