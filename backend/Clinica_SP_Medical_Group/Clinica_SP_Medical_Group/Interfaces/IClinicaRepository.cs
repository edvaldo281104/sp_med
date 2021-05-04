using Clinica_SP_Medical_Group.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_SP_Medical_Group.Interfaces
{
    interface IClinicaRepository

    {

        /// <summary>
        /// metodo listar todos 
        /// </summary>
        /// <returns> ele retornar uma lista com todas clinicas cadastrada</returns>
        List<Clinica> ListarTodos();
        Clinica BuscarPorId(int id);
        void Cadastrar(Clinica novaClinica);
        void Deletar(int id);
        void Atualizar(int id, Clinica clinicaAtualizada);
    }
}
