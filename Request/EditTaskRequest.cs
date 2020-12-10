using System;

namespace Planner.Request
{
    public class EditTaskRequest
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