﻿using Microsoft.EntityFrameworkCore.Diagnostics;
using PokemonApp.Data;
using PokemonApp.Interface;
using PokemonApp.Model;

namespace PokemonApp.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context; 
        public OwnerRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Owner> GetOwners()
        {
            return _context.Owners.ToList();
        }

        public Owner GetOwner(int ownerId) {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersOfAPokemon(int pokeId)
        {
            return _context.PokemonOwners.Where(p => p.PokemonId == pokeId)
                .Select(o => o.Owner)
                .ToList();
        }

        public ICollection<Pokemon> GetPokemonOfOwner(int ownerId)
        {
            return _context.PokemonOwners.Where(o => o.Owner.Id == ownerId)
                 .Select(p => p.Pokemon)
                 .ToList();
        }

        public bool OwnerExists(int ownerId)
        {
            return _context.Owners.Any(o => o.Id == ownerId);
        }

        public bool CreateOwner(Owner owner) {
            _context.Owners.Add(owner);
              return Save();
        }

        public bool UpdateOwner(Owner owner) {
            _context.Update(owner);
            return Save();
        }
        public bool Save() {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool DeleteOwner(Owner owner)
        {
            _context.Remove(owner);
            return Save();
        }
    }
}
