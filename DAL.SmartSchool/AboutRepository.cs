using DAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;
using System.Data.SqlClient;
using System.Data;
using Common.SmartSchool;

namespace DAL.SmartSchool
{
    public class AboutRepository : DBHelper, IAboutRepository
    {
        public Message addUpdateSchoolStaff(Staff staff)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateSchoolStaff, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", staff.Id);
                command.Parameters.AddWithValue("@FirstName", staff.FirstName);
                command.Parameters.AddWithValue("@MiddleName", staff.MiddleName);
                command.Parameters.AddWithValue("@LastName", staff.LastName);
                command.Parameters.AddWithValue("@SchoolId", staff.SchoolId);
                command.Parameters.AddWithValue("@Address", staff.Address);
                command.Parameters.AddWithValue("@Phone", staff.Phone);
                command.Parameters.AddWithValue("@Designation", staff.Designation);
                command.Parameters.AddWithValue("@ImagePath", staff.ImagePath);
                command.Parameters.AddWithValue("@CreatedBy", staff.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", staff.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", staff.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", staff.UpdatedDate);

                msg.status = command.ExecuteNonQuery();
            }

            return msg;
        }

        public List<Staff> getSchoolStaff(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            List<Staff> lstStaff = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                totalNoOfRecords = 0;
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetSchoolStaff, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PageNbr", pagination.PageNumber);
                command.Parameters.AddWithValue("@PageSize", pagination.PageSize);
                command.Parameters.AddWithValue("@SortCol", pagination.SortColumn);
                command.Parameters.AddWithValue("@SchoolId", schoolId);
                objReader = command.ExecuteReader();
                if (objReader.HasRows)
                {
                    lstStaff = new List<Staff>();
                    while (objReader.Read())
                    {
                        totalNoOfRecords = (int)objReader["TotalCount"];
                        Staff objStaff = new Staff();
                        objStaff.Id = (int)objReader["Id"];
                        objStaff.FirstName = objReader["FirstName"].ToString();
                        objStaff.MiddleName = objReader["MiddleName"].ToString();
                        objStaff.LastName = objReader["LastName"].ToString();
                        objStaff.SchoolId = (int)objReader["SchoolId"];
                        objStaff.Address = objReader["Address"].ToString();
                        objStaff.Phone = objReader["Phone"].ToString();
                        objStaff.Designation = objReader["Designation"].ToString();
                        objStaff.ImagePath = objReader["ImagePath"].ToString();
                        objStaff.CreateBy = (int)objReader["CreatedBy"];
                        objStaff.UpdatedBy = (int)objReader["UpdatedBy"];
                        objStaff.CreatedDate = objReader["CreatedDate"].ToString();
                        objStaff.UpdatedDate = objReader["UpdatedDate"].ToString();
                        lstStaff.Add(objStaff);
                    }
                }
            }
            return lstStaff;
        }
    }
}
