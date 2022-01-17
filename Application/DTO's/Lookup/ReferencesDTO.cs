using Application.DTO_s.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Lookup
{
    public class ReferencesDTO : BaseLookupDTO
    {
        [Key]
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
