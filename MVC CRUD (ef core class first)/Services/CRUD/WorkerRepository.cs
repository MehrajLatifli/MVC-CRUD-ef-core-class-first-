using MVC_CRUD__ef_core_class_first_.Data;
using MVC_CRUD__ef_core_class_first_.Entities;

namespace MVC_CRUD__ef_core_class_first_.Services.CRUD
{
    public class WorkerRepository : IRepository
    {
        public WorkerDbContext _workerDbContext;

        public WorkerRepository(WorkerDbContext workerDbContext)
        {

            _workerDbContext = workerDbContext;
        }

        public void Add(Worker employee)
        {
            _workerDbContext.Workers.Add(employee);
            _workerDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _workerDbContext.Workers.RemoveRange(_workerDbContext.Workers.Where(x => x.Id == id));
            _workerDbContext.SaveChanges();
        }

        public Worker Get(int? id)
        {
            return _workerDbContext.Workers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Worker> GetAll()
        {
            return _workerDbContext.Workers.ToList();
        }

        public void Update(Worker worker)
        {
            _workerDbContext.Workers.Update(worker);
            _workerDbContext.SaveChanges();
        }
    }
}
