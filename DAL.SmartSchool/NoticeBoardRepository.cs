using DAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using Entity.SmartSchool;
using System.Data.SqlClient;
using Common.SmartSchool;
using System.Data;

namespace DAL.SmartSchool
{
    public class NoticeBoardRepository : DBHelper, INoticeBoardRepository
    {
        public Message addUpdateNoticeBoard(NoticeDashBoard noticeBoard)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateNoticeBoard, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", noticeBoard.Id);
                command.Parameters.AddWithValue("@ClassId", noticeBoard.ClassId);
                command.Parameters.AddWithValue("@DivisionId", noticeBoard.DivisionId);
                command.Parameters.AddWithValue("@Description", noticeBoard.Description);
                command.Parameters.AddWithValue("@CreatedBy", noticeBoard.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", noticeBoard.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", noticeBoard.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", noticeBoard.UpdatedDate);

                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }

        public List<NoticeDashBoard> getNoticeBoard(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            throw new NotImplementedException();
        }
    }
}
