using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
  public  interface IClassRepository
    {
        #region Divion Setup
        Message createUpdateDivision(ClassRoom division);
        //ClassRoom getDivision(int standard, int division);

        #endregion

        #region Set up studnet
        Message createUpdateStudent(Student student);
        //Student getStudent(int studentId);
        #endregion

        #region TimeTable
        Message createUpdateTimeTable(TimeTable timeTable);
        //List<TimeTable> getTimeTableDetail(int divisionId);
        #endregion

        #region ExamTimeTable
        Message createUpdateExamTimeTable(ExamTimeTable timeTable);
        //List<ExamTimeTable> getExamTimeTableDetail(int standard);
        #endregion

        #region Holidays
        Message createUpdateHolidays(Holidays holiday);
        //List<Holidays> getHolidaysDetail(int schoolId);
        #endregion
    }
}
