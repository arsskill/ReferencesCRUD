using Application.DTO_s.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReferencesRepository
    {
        Task<IEnumerable<ReferencesDTO>> GetReferencesAsync();
        Task<IEnumerable<ReferencesDTO>> GetByNameAsync(string name);
        Task<IEnumerable<ReferencesDTO>> GetByOrderAsync();

    }
}

