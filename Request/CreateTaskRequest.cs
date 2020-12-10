using System;

namespace Planner.Request
{
    public class CreateTaskRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
    }
}