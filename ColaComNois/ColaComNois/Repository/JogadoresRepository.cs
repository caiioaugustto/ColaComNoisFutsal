using ColaComNois.Context;
using ColaComNois.Context.DB;
using ColaComNois.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace ColaComNois.Repository
{
    public class JogadoresRepository : RepositoryBase<CCN_Jogadores>, IJogadoresRepository
    {
        public JogadoresRepository(ColaComNoisContext context)
            : base(context)
        {

        }
        
        public IList<CCN_Jogadores> ObterComissao()
        {
            return ObterTodos().Where(c => c.Comissao).ToList();
        }
    }
}