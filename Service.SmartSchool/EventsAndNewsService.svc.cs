using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity.SmartSchool;
using AutoMapper;

namespace Service.SmartSchool
{
    [AutomapServiceBehavior]
    public class EventsAndNewsService : IEventsAndNewsService
    {
        IEventsAndNews _eventsAndNews;

        public EventsAndNewsService(IEventsAndNews EventsAndNews)
        {
            _eventsAndNews = EventsAndNews;
        }

        public MessageDTO addUpdateEvents(Events events)
        {
            Message msg = _eventsAndNews.addUpdateEvents(events);
            var result = Mapper.Map<Message, MessageDTO>(msg);
            return result;
        }

        public Message addUpdateNews(News news)
        {
            return _eventsAndNews.addUpdateNews(news);
        }

        public List<EventsDto> getEvents(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
             var result =_eventsAndNews.getEvents(schoolId, pagination, out totalNoOfRecords);
            List<EventsDto> list = Mapper.Map<List<Events>, List<EventsDto>>(result);
            return list;
        }

        public List<NewsDto> getNews(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            var result = _eventsAndNews.getNews(schoolId, pagination, out totalNoOfRecords);
            List<NewsDto> list = Mapper.Map<List<News>, List<NewsDto>>(result);
            return list;
        }
    }
}
