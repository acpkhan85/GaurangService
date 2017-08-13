using DAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using Entity.SmartSchool;
using System.Data.SqlClient;
using Common.SmartSchool;
using System.Data;

namespace DAL.SmartSchool
{
    public class BackOfficeRepository : DBHelper, IBackOfficeRepository
    {
        public Message addUpdateProcessDocument(ProcessDocument processDocument)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateProcessDocuments, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", processDocument.Id);
                command.Parameters.AddWithValue("@StudentId", processDocument.StudentId);
                command.Parameters.AddWithValue("@Application", processDocument.Application);
                command.Parameters.AddWithValue("@Status", processDocument.Status);
                command.Parameters.AddWithValue("@Notes", processDocument.Notes);
                command.Parameters.AddWithValue("@CreatedBy", processDocument.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", processDocument.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", processDocument.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", processDocument.UpdatedDate);



                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }

        public List<ProcessDocument> getProcessDocument(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            throw new NotImplementedException();
        }
    }
}
