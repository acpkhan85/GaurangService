using Entity.SmartSchool;
using System.Collections.Generic;

namespace BAL.SmartSchool.Interface
{
    public interface INoticeBoard
    {
        Message addUpdateNoticeBoard(NoticeDashBoard noticeBoard);
        List<NoticeDashBoard> getNoticeBoard(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}
