using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Abstraction.Entities
{
    public interface IEntityBase<ID>
    {
        ID Id { get; set; }
    }
}
