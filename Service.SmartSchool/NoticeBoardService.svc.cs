using Contract.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity.SmartSchool;
using BAL.SmartSchool.Interface;

namespace Service.SmartSchool
{
    public class NoticeBoardService : INoticeBoardService
    {
        INoticeBoard _noticeBoard;

        public NoticeBoardService(INoticeBoard noticeBoard)
        {
            _noticeBoard = noticeBoard;
        }

        public Message addUpdateNoticeBoard(NoticeDashBoard noticeBoard)
        {
            return _noticeBoard.addUpdateNoticeBoard(noticeBoard);
        }

        public List<NoticeDashBoard> getNoticeBoard(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            throw new NotImplementedException();
        }
    }
}
