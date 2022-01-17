using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
        }
    }
}
