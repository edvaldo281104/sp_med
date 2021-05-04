using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Situacao
    {
        public int IdSituacao { get; set; }
        public int? IdConsulta { get; set; }
        [Required(ErrorMessage = "o campo situaçao e obrigatorio")]
        public string Situacao1 { get; set; }

        public virtual Consultum IdConsultaNavigation { get; set; }
    }
}
