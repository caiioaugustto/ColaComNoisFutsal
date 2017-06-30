using ColaComNois.Context;
using ColaComNois.Context.DB;

namespace ColaComNois.Repository
{
    public class JogosRepository : RepositoryBase<CCN_Jogos>
    {
        public JogosRepository(ColaComNoisContext context) : base(context)
        {
        }
    }
}