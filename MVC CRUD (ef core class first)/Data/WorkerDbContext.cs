using Microsoft.EntityFrameworkCore;
using MVC_CRUD__ef_core_class_first_.Entities;

namespace MVC_CRUD__ef_core_class_first_.Data
{
    public class WorkerDbContext : DbContext
    {
        public WorkerDbContext(DbContextOptions<WorkerDbContext> options) : base(options)
        {

        }

        public DbSet<Worker> Workers { get; set; }

    }
}
