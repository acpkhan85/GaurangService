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
    public interface INoticeBoardService
    {
        [OperationContract]
        Message addUpdateNoticeBoard(NoticeDashBoard noticeBoard);
        [OperationContract]
        List<NoticeDashBoard> getNoticeBoard(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}
