using BackendReciclarsipaga.Models;
using BackendRubricas.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendReciclarsipaga.Services
{
    public class PuntosService : IPuntosService
    {
        private readonly AppDbContext _context;

        public PuntosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Puntos>> GetAllAsync()
        {
            return await _context.puntos.ToListAsync();
        }

    }
}
