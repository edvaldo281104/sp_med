using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdPaciente { get; set; }
        public int? IdUsuario { get; set; }

        [Required(ErrorMessage = "o campo nome e obrigatorio ")]
        public string Nome { get; set; }

        [Required(ErrorMessage =" o campo data nascimento e obrigatorio")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = " o campo telefone e obrigatorio " )]
        [StringLength(15, MinimumLength = 9,ErrorMessage =  "o campo telefone  teve ter entre 15 e 9 caracteres")]

        public string Telefone { get; set; }

        [Required(ErrorMessage = " o campo rg e obrigatorio")]
        [StringLength(15, MinimumLength = 10,ErrorMessage = "o campo rg teve ter entre 15 e 10 caracteres")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "  o campo  cpf e obrigatorio")]
        [StringLength(15, MinimumLength = 12,ErrorMessage = " o campo cpf teve ter entre 15 e 12 caracteres")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = " o campo endereço e obrigatorio ")]
        [StringLength(30, MinimumLength = 18,ErrorMessage = "o campo endereço teve ter entre 30 e 18 caracteres")]
        public string Endereco { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
