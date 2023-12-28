using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos
        {
        get; set; }
    }
}
