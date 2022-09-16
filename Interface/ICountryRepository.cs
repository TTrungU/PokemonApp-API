using PokemonApp.Model;

namespace PokemonApp.Interface
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int OwnerId);
        ICollection<Owner> GetOwnersFromCountry(int CountryId);
        bool CountryExist(int id);
        bool CreateCountry(Country category);
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
        bool Save();
    }
}
