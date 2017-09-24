using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Contract.SmartSchool;
using Entity.SmartSchool;

namespace Service.SmartSchool
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AttendenceService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AttendenceService.svc or AttendenceService.svc.cs at the Solution Explorer and start debugging.
    public class AttendenceService : IAttendenceService
    {      
        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
