using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdEspecialidade { get; set; }
        [Required (ErrorMessage = "o  campo  Nome da Especialidadee obrigatorio")]
        public string NomeEspecialidade { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
