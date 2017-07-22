using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace BAL.SmartSchool
{
    public class User : IUser
    {
        IUserRepository _iuserRepository;
        public User(IUserRepository userRepository)
        {
            _iuserRepository = userRepository;
        }
        public Message createUser(Employee user)
        {
            throw new NotImplementedException();
        }

        public Message editUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> getUser(int id)
        {
            return _iuserRepository.getUser(id);
        }
    }
}
