using Minha1Conexao.Data.Interface;
using Minha1Conexao.Domain;

namespace Minha1Conexao.Data.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
