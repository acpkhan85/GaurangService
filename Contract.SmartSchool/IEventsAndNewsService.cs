using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IEventsAndNewsService
    {
        #region Events
        [OperationContract]
        MessageDTO addUpdateEvents(Events events);
        [OperationContract]
        List<EventsDto> getEvents(int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion

        #region News
        [OperationContract]
        Message addUpdateNews(News news);
        [OperationContract]
        List<NewsDto> getNews(int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion
    }
}
