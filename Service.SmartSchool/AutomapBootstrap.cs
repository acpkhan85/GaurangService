using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Entity.SmartSchool;
using Service.SmartSchool.CustomMapper;

namespace Service.SmartSchool
{
    public class AutomapBootstrap
    {
        public static void InitializeMap()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Message, MessageDTO>();

                #region Class
                cfg.CreateMap<ClassRoomDto, ClassRoom>().ReverseMap();
                cfg.CreateMap<StudentDto, Student>().ReverseMap();
                cfg.CreateMap<TimeTableDto, TimeTable>().ReverseMap();
                cfg.CreateMap<ExamTimeTableDto, ExamTimeTable>().ReverseMap();
                cfg.CreateMap<HolidaysDto, Holidays>().ReverseMap();
                cfg.CreateMap<ProcessDocumentDto, ProcessDocument>().ReverseMap();
                cfg.CreateMap<EventsDto, Events>().ReverseMap();
                cfg.CreateMap<Events, EventsDto>().ReverseMap();
                cfg.CreateMap<NewsDto, News>();
                cfg.CreateMap<News, NewsDto>();                
                #endregion
            });
        }
    }
}