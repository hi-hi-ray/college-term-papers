using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Presentation.Models;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;

namespace KeepEverything.RaysaDutra.Presentation.Controllers
{
    public class TagsController : Controller
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        // GET: Tags
        public ActionResult Index()
        {
            var tags = _tagService.GetAll();
            var tagsViewModel = AutoMapper.Mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tags);

            return View(tagsViewModel);
        }

        // GET: Tags/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var tag = _tagService.GetById(id);
            var tagViewModel = AutoMapper.Mapper.Map<TagViewModel>(tag);
            if (tagViewModel == null)
            {
                return HttpNotFound();
            }
            return View(tagViewModel);
        }

        // GET: Tags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTag,NameTag")] TagViewModel tagViewModel)
        {
            if (ModelState.IsValid)
            {
                var tag = AutoMapper.Mapper.Map<Tag>(tagViewModel);
                _tagService.Add(tag);
                return RedirectToAction("Index");
            }

            return View(tagViewModel);
        }

        // GET: Tags/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = _tagService.GetById(id);
            var tagViewModel = AutoMapper.Mapper.Map<TagViewModel>(tag);
            if (tagViewModel == null)
            {
                return HttpNotFound();
            }
            return View(tagViewModel);
        }

        // POST: Tags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTag,NameTag")] TagViewModel tagViewModel)
        {
            if (ModelState.IsValid)
            {
                Tag tag = AutoMapper.Mapper.Map<Tag>(tagViewModel);
                _tagService.Update(tag);
                return RedirectToAction("Index");
            }
            return View(tagViewModel);
        }

        // GET: Tags/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = _tagService.GetById(id);
            var tagViewModel = AutoMapper.Mapper.Map<TagViewModel>(tag);
            if (tagViewModel == null)
            {
                return HttpNotFound();
            }
            return View(tagViewModel);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var tag = _tagService.GetById(id);
            _tagService.Remove(tag);
            return RedirectToAction("Index");
        }
    }
}
