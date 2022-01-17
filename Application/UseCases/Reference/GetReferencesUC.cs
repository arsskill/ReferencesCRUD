using Application.DTO_s.Lookup;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Reference
{
    public class GetReferencesUC
    {
        private readonly IReferencesRepository _referencesRepository;

        public GetReferencesUC(IReferencesRepository referencesRepository)
        {
            _referencesRepository = referencesRepository;
        }

        public async Task<IEnumerable<ReferencesDTO>> ExecuteAsync()
        {
            var references = await _referencesRepository.GetReferencesAsync();
            return references;
        }
    }
}
