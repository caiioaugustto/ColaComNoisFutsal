using AutoMapper;
using ColaComNois.Context.DB;
using ColaComNois.Entidades;

namespace ColaComNois.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.CreateMap<Jogadores, CCN_Jogadores>().ReverseMap();
        }
    }
}