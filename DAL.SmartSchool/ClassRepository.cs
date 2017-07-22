using System;
using System.Collections.Generic;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;
using System.Data.SqlClient;
using System.Data;
using Common.SmartSchool;

namespace DAL.SmartSchool
{
    public class ClassRepository : DBHelper, IClassRepository
    {
        #region Divion Setup
        public Message createUpdateDivision(ClassRoom division)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateClassRoom, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ClassId", division.ClassId);
                command.Parameters.AddWithValue("@Standard", division.Standard);
                command.Parameters.AddWithValue("@Division", division.Division);
                command.Parameters.AddWithValue("@SchoolId", division.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", division.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", division.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", division.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", division.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }
        public List<ClassRoom> getDivision(int standard, int division, Pagination pagination, out int totalNoOfRecords)
        {
            List<ClassRoom> lstclassroom = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetDivision, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PageNbr", pagination.PageNumber);
                command.Parameters.AddWithValue("@PageSize", pagination.PageSize);
                command.Parameters.AddWithValue("@SortCol", pagination.SortColumn);
                command.Parameters.AddWithValue("@SchoolId", pagination.SchoolId);
                command.Parameters.AddWithValue("@Division", division);
                command.Parameters.AddWithValue("@Standard", standard);
                objReader = command.ExecuteReader();
                if (objReader.HasRows)
                {
                    lstclassroom = new List<ClassRoom>();
                    while (objReader.Read())
                    {
                        ClassRoom objClassRoom = new ClassRoom();
                        objClassRoom.ClassId = (int)objReader["ClassId"];
                        objClassRoom.Standard = objReader["Standard"].ToString();
                        objClassRoom.Division = objReader["Division"].ToString();
                        lstclassroom.Add(objClassRoom);
                    }
                }
                totalNoOfRecords = lstclassroom.Count;
            }
            return lstclassroom;
        }

        #endregion

        #region Set up studnet
        public Message createUpdateStudent(Student student)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateStudents, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@ClassId", student.ClassId);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                command.Parameters.AddWithValue("@LastName", student.CreateBy);
                command.Parameters.AddWithValue("@BloodGroup", student.UpdatedBy);
                command.Parameters.AddWithValue("@CreateBy", student.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", student.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", student.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", student.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }
        //public Student getStudent(int studentId) { throw new NotImplementedException(); }
        #endregion

        #region TimeTable
        public Message createUpdateTimeTable(TimeTable timeTable)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateTimeTables, connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddWithValue("@TimeTableID", timeTable.TimeTableID);
                command.Parameters.AddWithValue("@ClassId", timeTable.ClassId);
                command.Parameters.AddWithValue("@Mon", timeTable.Mon);
                command.Parameters.AddWithValue("@Tue", timeTable.Tue);
                command.Parameters.AddWithValue("@Wed", timeTable.Wed);
                command.Parameters.AddWithValue("@Thu", timeTable.Thu);
                command.Parameters.AddWithValue("@Fri", timeTable.Fri);
                command.Parameters.AddWithValue("@Sat", timeTable.Sat);
                command.Parameters.AddWithValue("@Sun", timeTable.Sun);
                command.Parameters.AddWithValue("@CreateBy", timeTable.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", timeTable.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", timeTable.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", timeTable.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }
        //public List<TimeTable> getTimeTableDetail(int divisionId) { throw new NotImplementedException(); }
        #endregion

        #region ExamTimeTable
        public Message createUpdateExamTimeTable(ExamTimeTable timeTable)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateExamTimeTables, connection);
                command.CommandType = CommandType.StoredProcedure;                
                command.Parameters.AddWithValue("@ExamTimeTableID", timeTable.ExamTimeTableID);
                command.Parameters.AddWithValue("@ClassId", timeTable.ClassId);
                command.Parameters.AddWithValue("@Subject", timeTable.Subject);
                command.Parameters.AddWithValue("@FromDate", timeTable.FromDate);
                command.Parameters.AddWithValue("@FromTime", timeTable.FromTime);
                command.Parameters.AddWithValue("@ToTime", timeTable.ToTime);
                command.Parameters.AddWithValue("@Location", timeTable.Location);
                command.Parameters.AddWithValue("@Batch", timeTable.Batch);
                command.Parameters.AddWithValue("@CreateBy", timeTable.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", timeTable.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", timeTable.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", timeTable.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }
        //public List<ExamTimeTable> getExamTimeTableDetail(int standard) { throw new NotImplementedException(); }
        #endregion

        #region Holidays
        public Message createUpdateHolidays(Holidays holiday)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateHolidays, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HolidaysId", holiday.HolidaysId);
                command.Parameters.AddWithValue("@FromDate", holiday.FromDate);
                command.Parameters.AddWithValue("@ToDate", holiday.ToDate);
                command.Parameters.AddWithValue("@Fest", holiday.Festival);
                command.Parameters.AddWithValue("@Notes", holiday.Notes);
                command.Parameters.AddWithValue("@SchoolId", holiday.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", holiday.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", holiday.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", holiday.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", holiday.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }
        //public List<Holidays> getHolidaysDetail(int schoolId) { throw new NotImplementedException(); }
        #endregion
    }
}
