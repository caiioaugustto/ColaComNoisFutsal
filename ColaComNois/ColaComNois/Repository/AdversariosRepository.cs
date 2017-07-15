using System.Collections.Generic;
using ColaComNois.Context;
using ColaComNois.Context.DB;
using System.Linq;

namespace ColaComNois.Repository
{
    public class AdversariosRepository : RepositoryBase<CCN_Adversario>
    {
        public AdversariosRepository(ColaComNoisContext context) : base(context)
        {
        }

        public override IList<CCN_Adversario> ObterTodos()
        {
            return _context.Adversarios.OrderBy(a => a.Nome)
                .ThenBy(a => a.Nota)
                .ToList();
        }
    }
}