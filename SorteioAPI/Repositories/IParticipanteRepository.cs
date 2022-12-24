using SorteioAPI.Models;

namespace SorteioAPI.Repositories
{
    public interface IParticipanteRepository
    {
        Task<Participante> Create(Participante participante);
        Task<IEnumerable<Participante>> GetAll();
        Task<Participante> GetCpf(string cpf);
        Task<Participante> GetEmail(string email);
    }
}
