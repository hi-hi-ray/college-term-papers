using AutoMapper;
using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.WebAPIService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepEverything.RaysaDutra.WebAPIService.App_Start
{
    public static class MapperConfig
	{
		public static void CreateAutoMapperMappings()
		{
			//AutoMapper.Mapper.CreateMap<Fonte, Destino>()

			Mapper.Initialize(config =>
			{
				config.CreateMap<Category, CategoryDTO>();
				config.CreateMap<CategoryDTO, Category>();

				config.CreateMap<Tag, TagDTO>();
				config.CreateMap<TagDTO, Tag>();

                config.CreateMap<Task, TaskDTO>();
                config.CreateMap<TaskDTO, Task>();

			});
		}
	}
}