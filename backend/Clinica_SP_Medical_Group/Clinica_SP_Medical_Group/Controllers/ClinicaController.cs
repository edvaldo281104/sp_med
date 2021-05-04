using Clinica_SP_Medical_Group.Interfaces;
using Clinica_SP_Medical_Group.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_SP_Medical_Group.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _ClinicaRepository { get; set; }
        public ClinicaController()
        {
            _ClinicaRepository = new ClinicaRepository();


        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ClinicaRepository.ListarTodos());
        }
    }
}
