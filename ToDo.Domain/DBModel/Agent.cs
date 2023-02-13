

using ToDo.Domain.Model;

namespace ToDo.Domain.DBModel
{
    public class Agent : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
