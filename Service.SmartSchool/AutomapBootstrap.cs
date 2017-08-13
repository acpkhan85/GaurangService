using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Entity.SmartSchool;

namespace Service.SmartSchool
{
    public class AutomapBootstrap
    {
        public static void InitializeMap()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap< Message, MessageDTO>();
                cfg.CreateMap<ClassRoomDto, ClassRoom>();
            });
        }
    }
}