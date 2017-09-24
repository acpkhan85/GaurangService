using System;
using System.Collections.Generic;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;
using System.Data.SqlClient;
using System.Data;
using Common.SmartSchool;


namespace DAL.SmartSchool
{  
    public class AttendenceRepository : DBHelper, IAttendenceRepository
    {
        #region Divion Setup       
        public List<Student> getStudents(int classId, DateTime attendenceDate)
        {
            List<Student> students = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetAttendence, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ClassId", classId);
                command.Parameters.AddWithValue("@AttendenceDate", attendenceDate);
                objReader = command.ExecuteReader();
                if (objReader.HasRows)
                {
                    students = new List<Student>();
                    while (objReader.Read())
                    {                       
                        Student student = new Student();
                        student.StudentId= (int)objReader["StudentId"];
                        student.ClassId = (int)objReader["ClassId"];
                        student.RollNumber = (int)objReader["RollNumber"];
                        student.FirstName = Convert.ToString(objReader["FirstName"]);
                        student.MiddleName = Convert.ToString(objReader["MiddleName"]);
                        student.LastName = Convert.ToString(objReader["LastName"]);
                        student.IsPlaneedLeave =Convert.ToBoolean(objReader["IsPlaneedLeave"]);
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        public Message saveAttendence(DataTable attedence,int classId,string attendenceJson,int createdBy)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_SaveAttendence, connection);
                command.CommandType = CommandType.StoredProcedure;
             
                SqlParameter parameter = new SqlParameter();                
                parameter.ParameterName = "@Attendence";
                parameter.SqlDbType = System.Data.SqlDbType.Structured;
                parameter.Value = attedence;
                command.Parameters.Add(parameter);
                command.Parameters.AddWithValue("@ClassId", classId);
                command.Parameters.AddWithValue("@AttendenceJson", attendenceJson);
                command.Parameters.AddWithValue("@CreatedBy", createdBy);
                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }

        #endregion

    }
}
