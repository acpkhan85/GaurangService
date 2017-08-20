using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
  public  interface IClassRepository
    {
        #region Divion Setup
        Message createUpdateDivision(ClassRoom division);
        List<ClassRoom> getDivision(int? standard, int? division,int schoolId, Pagination pagination, out int totalNoOfRecords);

        #endregion

        #region Set up studnet
        Message createUpdateStudent(Student student);
        List<Student> getStudent(int studentId, int classId, Pagination pagination, out int totalNoOfRecords);
        #endregion

        #region TimeTable
        Message createUpdateTimeTable(TimeTable timeTable);
        List<TimeTable> getTimeTable(int classId);
        #endregion

        #region ExamTimeTable
        Message createUpdateExamTimeTable(ExamTimeTable timeTable);
        List<ExamTimeTable> getExamTimeTable(int classId);
        #endregion

        #region Holidays
        Message createUpdateHolidays(Holidays holiday);
        List<Holidays> getHolidaysDetail(int schoolId);
        #endregion
    }
}
