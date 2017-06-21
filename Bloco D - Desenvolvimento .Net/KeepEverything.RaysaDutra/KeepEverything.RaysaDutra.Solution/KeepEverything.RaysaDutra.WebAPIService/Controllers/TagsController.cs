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
    public class TagsController : ApiController
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        // GET: api/Tags
        public IEnumerable<TagDTO> GetTags()
        {
            var tag = _tagService.GetAll();
            var tagDTO = AutoMapper.Mapper.Map<IEnumerable<Tag>, IEnumerable<TagDTO>>(tag);
            return tagDTO;
        }

        // GET: api/Tags/5
        [ResponseType(typeof(TagDTO))]
        public IHttpActionResult GetTag(int id)
        {
            var tag = _tagService.GetById(id);
            if (tag == null)
            {
                return NotFound();
            }
            var tagDTO = AutoMapper.Mapper.Map<Tag, TagDTO>(tag);
            return Ok(tagDTO);
        }

        // PUT: api/Tags/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTag(int id, TagDTO tagDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != tagDTO.IdTag)
            {
                return BadRequest();
            }
            try
            {
                var tag = AutoMapper.Mapper.Map<Tag>(tagDTO);
                _tagService.Update(tag);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tags
        [ResponseType(typeof(TagDTO))]
        public IHttpActionResult PostTag(TagDTO tagDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var tag = AutoMapper.Mapper.Map<Tag>(tagDTO);
            _tagService.Add(tag);
            return CreatedAtRoute("DefaultApi", new { id = tag.IdTag }, tag);
        }

        // DELETE: api/Tags/5
        [ResponseType(typeof(TagDTO))]
        public IHttpActionResult DeleteTag(int id)
        {
            var tag = _tagService.GetById(id);
            if (tag == null)
            {
                return NotFound();
            }
            var tagDTO = AutoMapper.Mapper.Map<TagDTO>(tag);
            _tagService.Remove(tag);
            return Ok(tagDTO);
        }
    }
}
