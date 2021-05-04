using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Consultum
    {
        public Consultum()
        {
            Situacaos = new HashSet<Situacao>();
        }

        public int IdConsulta { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdMedico { get; set; }

        [Required(ErrorMessage ="o campo data consulta e obrigatorio")]
        public DateTime DataConsulta { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }

        [Required(ErrorMessage =  "O campo situaçao e obrigatorio" )]

        public virtual ICollection<Situacao> Situacaos { get; set; }
    }
}
