using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.SmartSchool.Interface
{
    public interface IEventsAndNews
    {
        #region Events
        Message addUpdateEvents(Events events);
        List<Events> getEvents(int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion

        #region News
        Message addUpdateNews(News news);
        List<News> getNews(int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion
    }
}
