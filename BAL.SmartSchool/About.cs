using BAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;
using DAL.SmartSchool.Interface;

namespace BAL.SmartSchool
{
    public class About : IAbout
    {
        IAboutRepository _aboutRepository;

        public About(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public Message addUpdateSchoolStaff(Staff staff)
        {
            return _aboutRepository.addUpdateSchoolStaff(staff);
        }

        public List<Staff> getSchoolStaff(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _aboutRepository.getSchoolStaff(schoolId, pagination, out totalNoOfRecords);
        }
    }
}
