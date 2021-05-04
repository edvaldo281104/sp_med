using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Clinica_SP_Medical_Group.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }


        [Required(ErrorMessage =" o campo nome fantasia e obrigatorio")]
        public string NomeFantasia { get; set; }


        [Required (ErrorMessage="o campo cnpj e obrigatorio")]
        public string Cnpj { get; set; }


        [Required (ErrorMessage= "o campo RazaoSocial e obrigatoria "  )]
        public string RazaoSocial { get; set; }


        [Required(ErrorMessage= " o campo Endereço e obrigatorio ")]

        public string Endereco { get; set; }

        [Required(ErrorMessage = " o campo Dias e obrigatorio ")]

        public string Dias { get; set; }

        [Required(ErrorMessage= " o campo Horarioabertura " )]

        public TimeSpan Horarioabertura { get; set; }

        [Required(ErrorMessage = " o campo Horariofechamento ")]

        public TimeSpan Horariofechamento { get; set; }


        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
