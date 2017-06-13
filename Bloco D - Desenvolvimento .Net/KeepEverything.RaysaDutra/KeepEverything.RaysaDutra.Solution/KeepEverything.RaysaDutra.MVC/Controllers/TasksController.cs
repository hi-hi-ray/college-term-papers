using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Infra.Contexts;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using KeepEverything.RaysaDutra.Presentation.Models;

namespace KeepEverything.RaysaDutra.Presentation.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITagService _tagService;
        private readonly ITaskService _taskService;
        private readonly ICategoryService _categoryService;

        public TasksController(ITagService tagService, ITaskService taskService, ICategoryService categoryService)
        {
            _tagService = tagService;
            _categoryService = categoryService;
            _taskService = taskService;
        }


        // GET: Tasks
        public ActionResult Index()
        {
            var tasks = _taskService.GetAll();
            var tarefasViewModel = AutoMapper.Mapper.Map<IEnumerable<Task>, IEnumerable<TaskViewModel>>(tasks);
            return View(tarefasViewModel);
        }

        // GET: Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var task = _taskService.GetById(id);
            var taskViewModel = AutoMapper.Mapper.Map<TaskViewModel>(task);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(taskViewModel);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            var categories = _categoryService.GetAll();
            ViewBag.IdCategory = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories), "IdCategory", "NameCategory");

            var tags = _tagService.GetAll();
            ViewBag.Tags = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tags), "IdTag", "NameTag");
            return View();
        }

        // POST: Tasks/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTask,NameTask,DescriptionTask,EndedDateTask,IdCategory,IdTags")] TaskViewModel taskViewModel)
        {
            if (ModelState.IsValid)
            {
                var task = AutoMapper.Mapper.Map<Task>(taskViewModel);
                task.Tags = _tagService.GetAll().Where(m => taskViewModel.IdTags.Contains(m.IdTag)).ToList();
                task.CreatedDateTask = DateTime.Now;
                task.CurrentSituationTask = task.SeeTheSituationByDate(task.CreatedDateTask, task.EndedDateTask);
                _taskService.Add(task);

                return RedirectToAction("Index");
            }
            var categories = _categoryService.GetAll();
            ViewBag.IdCategory = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories), "IdCategory", "NameCategory");

            var tags = _tagService.GetAll();
            ViewBag.Tags = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tags), "IdTag", "NameTag");

            return View(taskViewModel);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var task = _taskService.GetById(id);
            var taskViewModel = AutoMapper.Mapper.Map<TaskViewModel>(task);
            if (task == null)
            {
                return HttpNotFound();
            }
            var categories = _categoryService.GetAll();
            ViewBag.IdCategory = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories), "IdCategory", "NameCategory");

            var tags = _tagService.GetAll();
            ViewBag.Tags = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tags), "IdTag", "NameTag");

            return View(taskViewModel);
        }

        // POST: Tasks/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTask,NameTask,DescriptionTask,EndedDateTask,IdCategory,IdTags")] TaskViewModel taskViewModel)
        {
            if (ModelState.IsValid)
            {
                var task = AutoMapper.Mapper.Map<Task>(taskViewModel);
                task.Tags = _tagService.GetAll().Where(m => taskViewModel.IdTags.Contains(m.IdTag)).ToList();
                task.CreatedDateTask = DateTime.Now;
                task.CurrentSituationTask = task.SeeTheSituationByDate(task.CreatedDateTask, task.EndedDateTask);
                _taskService.Update(task);

                return RedirectToAction("Index");
            }
            var categories = _categoryService.GetAll();
            ViewBag.IdCategory = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories), "IdCategory", "NameCategory");

            var tags = _tagService.GetAll();
            ViewBag.Tags = new SelectList(AutoMapper.Mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tags), "IdTag", "NameTag");

            return View(taskViewModel);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var task = _taskService.GetById(id);
            var taskViewModel = AutoMapper.Mapper.Map<TaskViewModel>(task);
            if (taskViewModel == null)
            {
                return HttpNotFound();
            }
            return View(taskViewModel);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _taskService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
