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

                //souce==>Destination
                cfg.CreateMap<Message, MessageDTO>();



                #region Class
                cfg.CreateMap<ClassRoomDto, ClassRoom>();
                cfg.CreateMap<List<ExamTimeTable>, List<ExamTimeTableDto>>();

                #endregion

            });
        }
    }
}