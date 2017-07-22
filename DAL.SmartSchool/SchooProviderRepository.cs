
using System;
using System.Collections.Generic;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;
using Common.SmartSchool;
using System.Data.SqlClient;
using System.Data;

namespace DAL.SmartSchool
{
    public class SchooProviderRepository : DBHelper, ISchoolProviderRepository
    {
        public Message createSchoolProvider(School school)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                 msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateSchool, connection);
                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@SchoolId", school.SchoolId);
                command.Parameters.AddWithValue("@SchoolName", school.SchoolName);
                command.Parameters.AddWithValue("@PortalUrl", school.PortalUrl);
                command.Parameters.AddWithValue("@IsActive", school.IsActive);
                msg.status = objCommand.ExecuteNonQuery();
            }

            return msg;
        }

        public Message editSchoolProvider(int id)
        {
            throw new NotImplementedException();
        }

        public List<School> getSchoolProvider(int schoolId)
        {
            List<School> lstSchool = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetSchool, connection);

                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@schoolId", schoolId);
                objReader = objCommand.ExecuteReader();
                if (objReader.HasRows)
                {
                    lstSchool = new List<School>();
                    while (objReader.Read())
                    {
                        School objSchool = new School();
                        objSchool.SchoolId = (int)objReader["SchoolId"];
                        objSchool.SchoolName = objReader["SchoolName"].ToString();
                        objSchool.PortalUrl = objReader["PortalUrl"].ToString();
                        objSchool.IsActive = (bool)objReader["IsActive"];
                        lstSchool.Add(objSchool);
                    }
                }
            }
            return lstSchool;
        }
    }
}
