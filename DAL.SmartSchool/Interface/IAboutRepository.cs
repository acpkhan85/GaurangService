using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SmartSchool.Interface
{
    public interface IAboutRepository
    {
        #region Events
        Message addUpdateSchoolStaff(Staff staff);
        List<Staff> getSchoolStaff(int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion
    }
}
