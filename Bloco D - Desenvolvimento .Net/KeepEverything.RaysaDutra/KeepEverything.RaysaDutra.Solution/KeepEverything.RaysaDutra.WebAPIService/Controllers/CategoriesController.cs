using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using KeepEverything.RaysaDutra.WebAPIService.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace KeepEverything.RaysaDutra.WebAPIService.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Categories
        public IEnumerable<CategoryDTO> GetCategories()
        {
            var category = _categoryService.GetAll();
            var categoryDTO = AutoMapper.Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(category);
            return categoryDTO;
        }

        // GET: api/Categories/5
        [ResponseType(typeof(CategoryDTO))]
        public IHttpActionResult GetCategory(int id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryDTO = AutoMapper.Mapper.Map<Category, CategoryDTO>(category);
            return Ok(categoryDTO);
        }

        // PUT: api/Categories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategory(int id, CategoryDTO categoryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoryDTO.IdCategory)
            {
                return BadRequest();
            }

            try
            {
                var category = AutoMapper.Mapper.Map<Category>(categoryDTO);
                _categoryService.Update(category);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Categories
        [ResponseType(typeof(CategoryDTO))]
        public IHttpActionResult PostCategory(CategoryDTO categoryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = AutoMapper.Mapper.Map<Category>(categoryDTO);
            _categoryService.Add(category);
            return CreatedAtRoute("DefaultApi", new { id = category.IdCategory }, category);
        }

        // DELETE: api/Categories/5
        [ResponseType(typeof(CategoryDTO))]
        public IHttpActionResult DeleteCategory(int id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryDTO = AutoMapper.Mapper.Map<CategoryDTO>(category);
            _categoryService.Remove(category);
            return Ok(categoryDTO);
        }
    }
}
