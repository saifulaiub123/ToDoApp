using System;
using ToDo.Domain.DBModel;
using ToDo.Domain.Model;
using ToDo.Domain.ViewModel;

namespace ToDo.Application.IService
{
    public interface ITODOService
    {
        Task Add(TODOModel toDoModel);
        Task<List<TODOViewModel>> GetAll();
        Task<TODOViewModel> GetById(int id);
        Task Update(TODOModel toDoModel);
        Task Delete(int id);
    }
}
