using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Entity
{
    public class Task
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsDone { get; set; }
        public DateTime WhenDone { get; set; }

    }
}
