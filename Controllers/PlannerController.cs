using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Planner.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Planner.Request;
using Task = Planner.Entity.Task;

namespace Planner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyPolicy")]
    public class PlannerController : ControllerBase
    {
        private readonly ILogger<PlannerController> _logger;

        [HttpGet]
        [Route("api/GetAllTask")]
        public IEnumerable<Task> Get()
        {
            using (PlannerContext db = new PlannerContext())
            {
                return db.Task.ToList();
            }
        }
        
        [HttpGet]
        [Route("api/GetTaskById")]
        public Task Get(int id)
        {
            using (PlannerContext db = new PlannerContext())
            {
                return db.Task.Find(id);
            }
        }

        [HttpPost]
        [Route("api/CreateTask")]
        public void CreateTask(CreateTaskRequest request)
        {
            Task task = new Task
            {
                Name = request.name,
                Description = request.description,
                DateCreation = DateTime.Now.Date,
                DeadLine = request.deadline,
                IsDone = false
            };
            using (PlannerContext db = new PlannerContext())
            {
                db.Task.Add(task);
                db.SaveChanges();
            }
        }

        [HttpPut]
        [Route("api/DoneTask")]
        public void DoneTask(int id)
        {
            using (PlannerContext db = new PlannerContext())
            {
                try
                {
                    Task task = db.Task.Find(id);
                    if (!task.IsDone)
                    {
                        task.IsDone = true;
                        task.WhenDone = DateTime.Now.Date;
                        db.Task.Update(task);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Dont find task by id = " + id);
                    throw;
                }    
            }
        }
        
        [HttpPost]
        [Route("api/EditTask")]
        public void EditTask(EditTaskRequest request)
        {
            Task task = new Task
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                DateCreation = request.DateCreation,
                DeadLine = request.DeadLine,
                WhenDone = request.WhenDone,
                IsDone = request.IsDone
            };
            using (PlannerContext db = new PlannerContext())
            {
                db.Task.Update(task);
                db.SaveChanges();
            }
        }
        
        [HttpDelete]
        [Route("api/DeleteTask")] 
        public void DeleteTask(int id)
        {
            using (PlannerContext db = new PlannerContext())
            {
                Task task = db.Task.Find(id);
                if (task != null){ db.Task.Remove(task); }
                db.SaveChanges();
            }
        }
    }
}