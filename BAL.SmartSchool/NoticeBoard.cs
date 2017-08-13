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
    public class NoticeBoard : INoticeBoard
    {
        INoticeBoardRepository _noticeBoardRepository;

        public NoticeBoard(INoticeBoardRepository noticeBoardRepository)
        {
            _noticeBoardRepository = noticeBoardRepository;
        }

        public Message addUpdateNoticeBoard(NoticeDashBoard noticeBoard)
        {
            return _noticeBoardRepository.addUpdateNoticeBoard(noticeBoard);
        }

        public List<NoticeDashBoard> getNoticeBoard(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            throw new NotImplementedException();
        }
    }
}
