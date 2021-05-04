using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "o campo email e obrigatorio ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Object campo senha e obrigatorio ")]
        [StringLength(50, MinimumLength =5,ErrorMessage = "o campo senha deve ter entre 5 e 50 caracteres ")]
        public string Senha { get; set; }

        public virtual TiposUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
