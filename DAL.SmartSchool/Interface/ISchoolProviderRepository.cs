using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
    interface ISchoolProviderRepository
    {
        Message createSchoolProvider(School school);
        List<School> getSchoolProvider(int id);
        Message editSchoolProvider(int id);

    }
}
