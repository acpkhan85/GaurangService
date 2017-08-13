using System.Collections.Generic;
using Entity.SmartSchool;

namespace BAL.SmartSchool.Interface
{
    public interface IClass
    {
        #region Divion Setup
        Message createUpdateDivision(ClassRoom division);
        List<ClassRoom> getDivision(int standard, int divisionint, int schoolId, Pagination pagination, out int totalNoOfRecords);

        #endregion

        #region Set up studnet
        Message addUpdateStudentDetail(Student student);
        List<Student> getStudent(int studentId, int classId, Pagination pagination, out int totalNoOfRecords);
        Message uploadStudentDetail(List<Student> lstStudent);
        #endregion

        #region TimeTable
        Message addUpdateTimeTable(TimeTable timeTable);
        Message uploadTimeTable(TimeTable timeTable);
        List<TimeTable> getTimeTable(int classId);
        #endregion

        #region ExamTimeTable
        Message addUpdateExamTimeTable(ExamTimeTable examTimeTable);
        Message uploadTimeTableByStandard(ExamTimeTable timeTable);
        List<ExamTimeTable> getExamTimeTable(int classId);
        #endregion

        #region Holidays
        Message addUpdateHolidayDetail(Holidays holiday);
        List<Holidays> getHolidaysDetail(int schoolId);
        Message uploadHoliday(List<Holidays> lstHoliday);
        #endregion
    }
}
