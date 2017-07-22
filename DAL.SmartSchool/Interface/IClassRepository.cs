using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
  public  interface IClassRepository
    {
        #region Divion Setup
        Message createDivision(ClassRoom division);
        Message editDivision(ClassRoom division);
        ClassRoom getDivision(int standard, int division);

        #endregion

        #region Set up studnet
        Message createStudent(Student student);
        Student getStudent(int studentId);
        Message editStudent(Student student);
        #endregion

        #region TimeTable
        Message createTimeTable(TimeTable timeTable);
        Message editTimeTable(TimeTable timeTable);
        List<TimeTable> getTimeTableDetail(int divisionId);
        #endregion

        #region ExamTimeTable
        Message createExamTimeTable(ExamTimeTable timeTable);
        Message editExamTimeTable(ExamTimeTable timeTable);
        List<ExamTimeTable> getExamTimeTableDetail(int standard);
        #endregion

        #region Holidays
        Message createHolidays(Holidays holiday);
        Message editHolidays(Holidays holiday);
        List<Holidays> getHolidaysDetail(int schoolId);
        #endregion
    }
}
