using Baza.Shared;
using Microsoft.EntityFrameworkCore;

namespace Baza.Server
{
    public class Bazaa : DbContext
    {
        public DbSet<Osoba> Osobas { get; set; }
    }
}
