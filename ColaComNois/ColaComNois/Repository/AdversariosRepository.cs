using ColaComNois.Context;
using ColaComNois.Context.DB;

namespace ColaComNois.Repository
{
    public class AdversariosRepository : RepositoryBase<CCN_Adversario>
    {
        public AdversariosRepository(ColaComNoisContext context) : base(context)
        {
        }
    }
}