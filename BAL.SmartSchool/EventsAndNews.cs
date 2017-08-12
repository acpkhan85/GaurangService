using BAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;
using DAL.SmartSchool.Interface;

namespace BAL.SmartSchool
{
    public class EventsAndNews : IEventsAndNews
    {
        IEventsAndNewsRepository _eventsAndNewsRepository;

        public EventsAndNews(IEventsAndNewsRepository eventsAndNewsRepository)
        {
            _eventsAndNewsRepository = eventsAndNewsRepository;
        }

        public Message addUpdateEvents(Events events)
        {
            return _eventsAndNewsRepository.addUpdateEvents(events);
        }

        public Message addUpdateNews(News news)
        {
            return _eventsAndNewsRepository.addUpdateNews(news);
        }

        public List<Events> getEvents(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _eventsAndNewsRepository.getEvents(schoolId, pagination, out totalNoOfRecords);
        }

        public List<News> getNews(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _eventsAndNewsRepository.getNews(schoolId, pagination, out totalNoOfRecords);
        }
    }
}
