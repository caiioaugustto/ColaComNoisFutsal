using ColaComNois.Context;
using ColaComNois.Context.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColaComNois.Repository
{
    public class RateiosRepository : RepositoryBase<CCN_Rateios>
    {
        public RateiosRepository(ColaComNoisContext context)
            : base(context)
        {

        }
    }
}