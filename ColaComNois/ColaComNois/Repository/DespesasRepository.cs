using ColaComNois.Context;
using ColaComNois.Context.DB;

namespace ColaComNois.Repository
{
    public class DespesasRepository : RepositoryBase<CCN_Despesas>
    {
        public DespesasRepository(ColaComNoisContext context)
            : base(context)
        {

        }
    }
}