using Contract.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity.SmartSchool;
using BAL.SmartSchool.Interface;

namespace Service.SmartSchool
{
    public class AboutService : IAboutService
    {
        IAbout _about;

        public AboutService(IAbout about)
        {
            _about = about;
        }

        public Message addUpdateStaff(Staff staff)
        {
            return _about.addUpdateSchoolStaff(staff);
        }

        public List<Staff> getSchoolStaff(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _about.getSchoolStaff(schoolId, pagination, out totalNoOfRecords);
        }
    }
}
