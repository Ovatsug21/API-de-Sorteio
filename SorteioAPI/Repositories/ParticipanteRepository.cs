using Microsoft.EntityFrameworkCore;
using SorteioAPI.Models;
using SorteioAPI.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;

namespace SorteioAPI.Repositories
{
    public class ParticipanteRepository : IParticipanteRepository
    {
        public readonly ParticipanteContext _participanteContext;

        public ParticipanteRepository( ParticipanteContext participanteContext)
        {
            _participanteContext = participanteContext;
        } 

        public async Task<Participante> Create(Participante participante)
        {
            _participanteContext.Participantes.Add(participante);
            await _participanteContext.SaveChangesAsync();
            
            return participante;
        }

        public async Task<IEnumerable<Participante>> GetAll()
        {
            return await _participanteContext.Participantes.ToListAsync();
        }

        public async Task<Participante> GetCpf(string cpf)
        {
            return await _participanteContext.Participantes.Where(c => c.Cpf== cpf).FirstOrDefaultAsync();
        }

        public async Task<Participante> GetEmail(string email)
        {
            return await _participanteContext.Participantes.Where(e => e.Email == email).FirstOrDefaultAsync();
        }
    }
}
