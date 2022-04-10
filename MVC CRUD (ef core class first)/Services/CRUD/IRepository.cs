using MVC_CRUD__ef_core_class_first_.Entities;

namespace MVC_CRUD__ef_core_class_first_.Services.CRUD
{
    public interface IRepository
    {

        public void Add(Worker worker);

        public void Delete(int id);

        public void Update(Worker worker);

        public Worker Get(int? id);

        IEnumerable<Worker> GetAll();
    }
}
