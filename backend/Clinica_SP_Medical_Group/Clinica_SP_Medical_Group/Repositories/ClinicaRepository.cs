using Clinica_SP_Medical_Group.Contexts;
using Clinica_SP_Medical_Group.Domains;
using Clinica_SP_Medical_Group.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_SP_Medical_Group.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private SP_Medical_GroupContext ctx = new SP_Medical_GroupContext();
        public void Atualizar(int id, Clinica clinicaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Clinica BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Clinica novaClinica)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
