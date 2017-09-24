using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
   public interface IAttendenceRepository
    {
        List<Student> getStudents(int classId, DateTime attendenceDate);
        Message saveAttendence(DataTable attedence, int classId, string attendenceJson, int createdBy);
    }
}
