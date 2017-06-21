using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using KeepEverything.RaysaDutra.WebAPIService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace KeepEverything.RaysaDutra.WebAPIService.Controllers
{
    public class TasksController : ApiController
    {
        private readonly ITaskService _tarefaService;
        private readonly ITagService _tagServie;

        public TasksController(ITaskService tarefaService, ITagService tagServie)
        {
            _tarefaService = tarefaService;
            _tagServie = tagServie;
        }

        // GET: api/Tasks
        public IEnumerable<TaskDTO> GetTasks()
        {
            var task = _tarefaService.GetAll();
            var taskDTO = AutoMapper.Mapper.Map<IEnumerable<Task>, IEnumerable<TaskDTO>>(task);
            return taskDTO;
        }

        // GET: api/Tasks/ByCategory/{id}
        [HttpGet]
        [Route("api/TasksByCategory/{id}")]
        public IEnumerable<TaskDTO> ByCategory(int id)
        {
            var task = _tarefaService.GetByCategory(id);
            if (task != null)
            {
                return AutoMapper.Mapper.Map<IEnumerable<Task>, IEnumerable<TaskDTO>>(task);
            }
            return null;
        }

        // GET: api/Tasks/ByTag/{id}
        [HttpGet]
        [Route("api/TasksByTag/{id}")]
        public IEnumerable<TaskDTO> ByTag(int id)
        {
            var tag = _tagServie.GetById(id);
            if (tag != null)
            {
                IEnumerable<Task> tarefas = tag.Tasks;
                return AutoMapper.Mapper.Map<IEnumerable<Task>, IEnumerable<TaskDTO>>(tarefas);
            }
            return null;
        }

        // GET: api/Tasks/5
        [ResponseType(typeof(TaskDTO))]
        public IHttpActionResult GetTask(int id)
        {
            var task = _tarefaService.GetById(id);
            if (task == null)
            {
                return NotFound();
            }
            var taskDTO = AutoMapper.Mapper.Map<Task, TaskDTO>(task);
            return Ok(taskDTO);
        }

        // PUT: api/Tasks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTask(int id, TaskDTO taskDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != taskDTO.IdTask)
            {
                return BadRequest();
            }
            try
            {
                var task = AutoMapper.Mapper.Map<Task>(taskDTO);
                _tarefaService.Update(task);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tasks
        [ResponseType(typeof(TaskDTO))]
        public IHttpActionResult PostTask(TaskDTO taskDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var task = AutoMapper.Mapper.Map<Task>(taskDTO);
            _tarefaService.Add(task);
            return CreatedAtRoute("DefaultApi", new { id = task.IdTask }, task);
        }

        // DELETE: api/Tasks/5
        [ResponseType(typeof(TaskDTO))]
        public IHttpActionResult DeleteTask(int id)
        {
            var task = _tarefaService.GetById(id);
            if (task == null)
            {
                return NotFound();
            }
            var taskDTO = AutoMapper.Mapper.Map<TaskDTO>(task);
            _tarefaService.Remove(task);
            return Ok(taskDTO);
        }
    }
}
