using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD__ef_core_class_first_.Entities
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long Age { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }

        public Worker()
        {

        }
    }
}
