using Microsoft.EntityFrameworkCore;

namespace SorteioAPI.Models
{
    public class ParticipanteContext : DbContext
    {
        public DbSet<Participante> Participantes { get; set; }

        public ParticipanteContext(DbContextOptions<ParticipanteContext> options) : base(options) { }
    }
}
