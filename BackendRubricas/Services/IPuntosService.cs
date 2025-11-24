using BackendReciclarsipaga.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendReciclarsipaga.Services
{
    public interface IPuntosService
    {
        Task<IEnumerable<Puntos>> GetAllAsync();

    }
}
