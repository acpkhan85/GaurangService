using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.SmartSchool.Interface
{
    public interface IAbout
    {
        #region Events
        Message addUpdateSchoolStaff(Staff staff);
        List<Staff> getSchoolStaff(int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion
    }
}
