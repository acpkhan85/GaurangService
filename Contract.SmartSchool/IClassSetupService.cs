
using System.Collections.Generic;
using System.ServiceModel;
using Entity.SmartSchool;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IClassSetupService
    {

        #region Division
        [OperationContract]
        Message addUpdateStandrdDivision(ClassRoom classRoomDetail);
        [OperationContract]
        List<ClassRoom> getStandardDivision(int schoolId, int standard, int division);

        #endregion

        #region StudentSetup
        [OperationContract]
        List<Student> getStudentDetail(int schoolId, string fname, string lname, int division);
        [OperationContract]
        Message addUpdateStudentDetail(Student student);
        [OperationContract]
        Message uploadStudentDetail(List<Student> lstStudent);
        #endregion

        #region TimeTable
        // void addUpdateTimeTable(TimeTable );
        [OperationContract]
        Message uploadTimeTable(List<TimeTable> lstTimeTable);
        [OperationContract]
        List<TimeTable> getTimeTableByDivsion();
        #endregion

        #region Exam

        [OperationContract]
        List<ExamTimeTable> getExamDetailByStandard(int schoolId, int division);
        //void addUpdateTimetable();
        [OperationContract]
        Message uploadTimeTableByStandard(List<TimeTable> timeTable);
        #endregion

        #region Holiday
        [OperationContract]
        Message addUpdateHolidayDetail(Holidays holiday);
        [OperationContract]
        List<Holidays> getHolidayDetail(int shcoolId);
        [OperationContract]
        Message uploadHoliday(List<Holidays> lstHoliday);
        #endregion

    }
}
