using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Persistence.Data;
using Persistence.Entities;

namespace Application.Repositories
{
    public class BreedRepository : GenericRepository<Breed>, IBreed
    {
        private readonly dbVeterinariaContext _context;

        public BreedRepository(dbVeterinariaContext context) : base(context)
        {
            _context = context;
        }
    }
}