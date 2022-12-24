using Microsoft.AspNetCore.Mvc;
using SorteioAPI.Models;
using SorteioAPI.Repositories;
using System.Runtime.CompilerServices;

namespace SorteioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantesController : ControllerBase
    {
        private readonly IParticipanteRepository _iparticipanteRepository;

        public ParticipantesController(IParticipanteRepository iparticipanteRepository)
        {
            _iparticipanteRepository = iparticipanteRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Participante>> PostParticipante([FromBody] Participante participante)
        {
            var CpfCliente = await _iparticipanteRepository.GetCpf(participante.Cpf);
            var EmailCliente = await _iparticipanteRepository.GetEmail(participante.Email);

            if ( (CpfCliente != null) && (CpfCliente.Nome != participante.Nome) )
            {
                throw new Exception("Cpf já cadastrado com outro nome de cliente!");
            }
            else
            {
                await _iparticipanteRepository.Create(participante);
                return participante;
            }
        }

        [HttpGet]
        public async Task<IEnumerable<Participante>> GetParticipantes()
        {
            return await _iparticipanteRepository.GetAll();
        }
    }
}
