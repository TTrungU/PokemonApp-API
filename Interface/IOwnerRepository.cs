using PokemonApp.Model;

namespace PokemonApp.Interface
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwnersOfAPokemon(int pokeId);
        ICollection<Owner> GetOwners();

        Owner GetOwner(int ownerId);
        ICollection<Pokemon> GetPokemonOfOwner(int ownerId);
        bool OwnerExists(int ownerId);
        bool UpdateOwner(Owner owner);
        bool CreateOwner(Owner owner);
        bool DeleteOwner(Owner owner);
        bool Save();

    }
}
