using API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Todo: BaseEntity
    {
       
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsDone { get; set; }
        public void MarkAsDone()
        {
            IsDone = true;
        }
    }
}
