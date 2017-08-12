﻿using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity.SmartSchool;

namespace Service.SmartSchool
{
    public class EventsAndNewsService : IEventsAndNewsService
    {
        IEventsAndNews _eventsAndNews;

        public EventsAndNewsService(IEventsAndNews EventsAndNews)
        {
            _eventsAndNews = EventsAndNews;
        }

        public Message addUpdateEvents(Events events)
        {
            return _eventsAndNews.addUpdateEvents(events);
        }

        public Message addUpdateNews(News news)
        {
            return _eventsAndNews.addUpdateNews(news);
        }

        public List<Events> getEvents(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _eventsAndNews.getEvents(schoolId, pagination, out totalNoOfRecords);
        }

        public List<News> getNews(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _eventsAndNews.getNews(schoolId, pagination, out totalNoOfRecords);
        }
    }
}