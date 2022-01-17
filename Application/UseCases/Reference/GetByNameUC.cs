using Application.DTO_s.Lookup;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Reference
{
    public class GetByNameUC
    {
        private readonly IReferencesRepository _referencesRepository;

        public GetByNameUC(IReferencesRepository referencesRepository)
        {
            _referencesRepository = referencesRepository;
        }

        public async Task<IEnumerable<ReferencesDTO>> GetByNameAsync(string name)
        {
            var references = await _referencesRepository.GetByNameAsync(name);
            return references;
        }
    }
}
