﻿using System.Collections.Generic;
using System.ServiceModel;
using Entity.SmartSchool;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IUserService
    {       
        [OperationContract]
        MessageDTO createUpdateUser(Employee user);

        [OperationContract]
        List<Employee> getUser(int schoolId);       

    }
}
