using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.IEntity;

namespace ToDo.Domain.Model
{
    public class BaseViewModel<TId> : IBaseEntity<TId>
    {
        public TId? Id { get; set; }
    }
}
