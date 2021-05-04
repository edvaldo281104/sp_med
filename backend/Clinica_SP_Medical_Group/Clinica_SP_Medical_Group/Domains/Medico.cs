using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdMedico { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdClinica { get; set; }
        public int? IdEspecialidade { get; set; }

        [Required(ErrorMessage = "o campo  crm e obrigatorio")]
        [StringLength(8,  ErrorMessage= "crm teve ter 8 caracteres")]
        public string Crm { get; set; }

        [Required(ErrorMessage = " o campo nome e obrigatorio")]
        public string Nome { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
