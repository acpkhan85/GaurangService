using System.Collections.Generic;
using Entity.SmartSchool;

namespace BAL.SmartSchool.Interface
{
    interface ISchoolProvider
    {
        Message createSchoolProvider(School school);
        List<School> getSchoolProvider();
        Message editSchoolProvider(int id);

    }
}
