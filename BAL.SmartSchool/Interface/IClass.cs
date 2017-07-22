using System.Collections.Generic;
using Entity.SmartSchool;

namespace BAL.SmartSchool.Interface
{
    public interface IClass
    {
        #region Divion Setup
        Message createUpdateDivision(ClassRoom division);
        List<ClassRoom> getDivision(int standard, int division);

        #endregion

        #region Set up studnet
        Message addUpdateStudentDetail(Student student);
        List<Student> getStudent(int studentId);
        Message uploadStudentDetail(List<Student> lstStudent);
        #endregion

        #region TimeTable
        Message addUpdateTimeTable(TimeTable timeTable);
        Message uploadTimeTable(TimeTable timeTable);
        List<TimeTable> getTimeTableDetail(int divisionId);
        #endregion

        #region ExamTimeTable
        Message addUpdateExamTimeTable(ExamTimeTable examTimeTable);
        Message uploadTimeTableByStandard(ExamTimeTable timeTable);
        List<ExamTimeTable> getExamDetailByStandard(int standard);
        #endregion

        #region Holidays
        Message addUpdateHolidayDetail(Holidays holiday);
        List<Holidays> getHolidaysDetail(int schoolId);
        Message uploadHoliday(List<Holidays> lstHoliday);
        #endregion
    }
}
