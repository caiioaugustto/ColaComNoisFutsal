using AutoMapper;
using ColaComNois.Context.DB;
using ColaComNois.Entidades;

namespace ColaComNois.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.CreateMap<CCN_Jogadores, Jogadores>().ReverseMap();
            base.CreateMap<CCN_Despesas, Despesas>().ReverseMap();
            base.CreateMap<CCN_Rateios, Rateio>().ReverseMap();
            base.CreateMap<CCN_Logins, Login>().ReverseMap();
            base.CreateMap<CCN_Jogos, Jogos>().ReverseMap();
            base.CreateMap<CCN_Adversario, Adversarios>().ReverseMap();
        }
    }
}