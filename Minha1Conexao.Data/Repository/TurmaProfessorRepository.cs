using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Data.Interface;
using Minha1Conexao.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Minha1Conexao.Data.Repository
{
    public class TurmaProfessorRepository : BaseRepository<TurmaProfessor>, ITurmaProfessorRepository
    {
        public TurmaProfessorRepository(Contexto contexto) : base(contexto)
        {

        }
        public List<TurmaProfessor> SelecionarTudoCompleto()
        {
            return _contexto.TurmaProfessor
                .Include(x => x.Professor)
                .Include(x => x.Turma)
                .ToList();
        }

        public override void Incluir(TurmaProfessor entity)
        {
            // colocar regras para inclusao


            base.Incluir(entity);
        }
    }
}
