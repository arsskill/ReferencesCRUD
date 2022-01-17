using Application.DTO_s.Lookup;
using Application.UseCases.Reference;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly GetReferencesUC _getReferencesUC;
        private readonly GetByOrderReferencesUC _getByOrderReferencesUC;
        private readonly GetByNameUC _getByNameUC;
        public ReferencesController(
            IMapper mapper,
            GetReferencesUC getReferencesUC,
            GetByOrderReferencesUC getByOrderReferencesUC,
            GetByNameUC getByNameUC)
        {
            _mapper = mapper;
            _getReferencesUC = getReferencesUC;
            _getByOrderReferencesUC = getByOrderReferencesUC;
            _getByNameUC = getByNameUC;
        }
        /// <summary>
        /// Получение списка справочников
        /// </summary>
        /// <returns></returns>
        [HttpGet("All")]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(IEnumerable<ReferencesDTO>), 200)]
        public async Task<IActionResult> GetReferencesAsync()
        {
            var references = await _getReferencesUC.ExecuteAsync();
            var result = _mapper.Map<IEnumerable<ReferencesDTO>>(references);
            return Ok(result);
        }
        /// <summary>
        /// Получение справочника по имени 
        /// </summary>
        /// <returns></returns>
        [HttpGet("ByName")]
        [ProducesResponseType(typeof(ReferencesDTO), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByNameAsync(string name)
        {
            var reference = await GetByNameAsync(name);
            if (reference == null)
                return NotFound("Reference not found");
            var referenceVM = _mapper.Map<ReferencesDTO>(reference);
            return Ok(referenceVM);
        }
        /// <summary>
        /// Получение сортированного списка по имени Справочника А-Я 
        /// </summary>
        /// <returns></returns>
        [HttpGet("AllByOrder")]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(IEnumerable<ReferencesDTO>), 200)]
        public async Task<IActionResult> GetByOrderAsync()
        {
            var references = await _getReferencesUC.ExecuteAsync();
            var result = _mapper.Map<IEnumerable<ReferencesDTO>>(references);
            return Ok(result);
        }
    }
}
