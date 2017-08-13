using Entity.SmartSchool;
using System.Collections.Generic;

namespace DAL.SmartSchool.Interface
{
    public interface INoticeBoardRepository
    {
        Message addUpdateNoticeBoard(NoticeDashBoard noticeBoard);
        List<NoticeDashBoard> getNoticeBoard(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}
