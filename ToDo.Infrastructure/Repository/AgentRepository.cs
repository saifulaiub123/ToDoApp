using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.DBModel;
using ToDo.Domain.IRepository;
using ToDo.Infrastructure.DBContext;

namespace ToDo.Infrastructure.Repository
{
    public class AgentRepository : Repository<Agent,int>, IAgentRepository
    {
        public AgentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
