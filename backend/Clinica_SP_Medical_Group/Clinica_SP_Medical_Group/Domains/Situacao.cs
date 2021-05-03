using System;
using System.Collections.Generic;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Situacao
    {
        public int IdSituacao { get; set; }
        public int? IdConsulta { get; set; }
        public string Situacao1 { get; set; }

        public virtual Consultum IdConsultaNavigation { get; set; }
    }
}
