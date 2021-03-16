using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using KeepEverything.RaysaDutra.Presentation.Models;

namespace KeepEverything.RaysaDutra.Presentation.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Categorys
        public ActionResult Index()
        {
            var categories = _categoryService.GetAll();
            var categoryViewModel = AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return View(categoryViewModel);
        }

        // GET: Categorys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = _categoryService.GetById(id);
            var categoryViewModel = AutoMapper.Mapper.Map<CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryViewModel);
        }

        // GET: Categorys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCategory,NameCategory,DescriptionCategory")] CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = AutoMapper.Mapper.Map<Category>(categoryViewModel);
                _categoryService.Add(category);
                return RedirectToAction("Index");
            }

            return View(categoryViewModel);
        }

        // GET: Categorys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = _categoryService.GetById(id);
            var categoryViewModel = AutoMapper.Mapper.Map<CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryViewModel);
        }

        // POST: Categorys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCategory,NameCategory,DescriptionCategory")] CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = AutoMapper.Mapper.Map<Category>(categoryViewModel);
                _categoryService.Update(category);
                return RedirectToAction("Index");
            }
            return View(categoryViewModel);
        }

        // GET: Categorys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = _categoryService.GetById(id);
            var categoryViewModel = AutoMapper.Mapper.Map<CategoryViewModel>(category);
            if (categoryViewModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryViewModel);
        }

        // POST: Categorys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = _categoryService.GetById(id);
            _categoryService.Remove(category);
            return RedirectToAction("Index");
        }
    }
}
