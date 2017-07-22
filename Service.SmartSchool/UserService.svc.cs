using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using Entity.SmartSchool;

namespace Service.SmartSchool
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        IUser _user;
        public UserService(IUser user)
        {
            _user = user;            
        }

        public Message createUpdateUser(Employee user)
        {
           return  _user.createUser(user);
        }

        public List<Employee> getUser(int id)
        {
           return _user.getUser(1);
        }
    }
}
