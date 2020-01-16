using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBasic.Core.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            IsActive = true;
            IsHome = false;
        }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
    }
}
