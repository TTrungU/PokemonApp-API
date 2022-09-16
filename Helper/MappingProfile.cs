using AutoMapper;
using PokemonApp.Dto;
using PokemonApp.Model;

namespace PokemonApp.Helper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {

            CreateMap<Pokemon, PokemonDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Owner, OwnerDto>().ReverseMap();
            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<Reviewer, ReviewerDto>().ReverseMap();
        }
    }
}
