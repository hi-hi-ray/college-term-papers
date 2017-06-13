using AutoMapper;
using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepEverything.RaysaDutra.Presentation.App_Start
{
    public static class MapperConfig
    {
        public static void CreateAutoMapperMappings()
        {

            Mapper.Initialize(config =>
            {
                config.CreateMap<Category, CategoryViewModel>();
                config.CreateMap<CategoryViewModel, Category>();

                config.CreateMap<Tag, TagViewModel>();
                config.CreateMap<TagViewModel, Tag>();

                config.CreateMap<Task, TaskViewModel>();
                config.CreateMap<TaskViewModel, Task>();

            });
        }
    }
}