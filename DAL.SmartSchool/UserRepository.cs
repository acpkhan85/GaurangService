
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;
using Common.SmartSchool;

namespace DAL.SmartSchool
{
    public class UserRepository : DBHelper, IUserRepository
    {  
        public Message createUser(Employee user)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();      
                SqlCommand command = new SqlCommand(Helper.sp_CreateUser, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", user.EmployeeID);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@RoleId", user.RoleId);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);
                command.Parameters.AddWithValue("@SchoolId", user.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", user.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", user.UpdatedBy);
                msg.status = objCommand.ExecuteNonQuery();
            }

            return msg;
        }      

        public List<Employee> getUser(int schoolId)
        {            
            List<Employee> lstemp = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetUser, connection);
                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@schoolId", schoolId);
                objReader = objCommand.ExecuteReader();
                if (objReader.HasRows)
                {
                    lstemp = new List<Employee>();
                    while (objReader.Read())
                    {
                        Employee objEmployee = new Employee();
                        objEmployee.EmployeeID = (int)objReader["EmployeeID"];
                        objEmployee.FirstName = objReader["FirstName"].ToString();
                        objEmployee.LastName = objReader["LastName"].ToString();
                        objEmployee.UserName = objReader["UserName"].ToString();
                        objEmployee.Password = objReader["Password"].ToString();
                        objEmployee.Email = objReader["Email"].ToString();
                        objEmployee.RoleId = (int)objReader["RoleId"];
                        objEmployee.IsActive = (bool)objReader["IsActive"];
                        objEmployee.SchoolId = (int)objReader["SchoolId"];
                        lstemp.Add(objEmployee);
                    }
                }
            }
            return lstemp;
        }
    }
}

