
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
        ClassRoomCollection getStandardDivision(int? standard, int? division, int schoolId, Pagination pagination);
        #endregion

        #region StudentSetup
        [OperationContract]
        StudentCollection getStudent(int studentId, int classId, Pagination pagination);
        [OperationContract]
        Message addUpdateStudentDetail(Student student);
        [OperationContract]
        Message uploadStudentDetail(List<Student> lstStudent);
        #endregion

        #region TimeTable
        [OperationContract]
        Message addUpdateTimeTable(TimeTable timeTable);
        [OperationContract]
        Message uploadTimeTable(List<TimeTable> lstTimeTable);
        [OperationContract]
        List<TimeTableDto> getTimeTable(int classId);
        #endregion

        #region Exam

        [OperationContract]
        List<ExamTimeTableDto> getExamTimeTable(int classId);
        [OperationContract]
        Message addUpdateExamTimeTable(ExamTimeTable examTimeTable);
        [OperationContract]
        Message uploadTimeTableByStandard(List<TimeTable> timeTable);
        #endregion

        #region Holiday
        [OperationContract]
        Message addUpdateHolidayDetail(Holidays holiday);
        [OperationContract]
        List<HolidaysDto> getHolidayDetail(int shcoolId);
        [OperationContract]
        Message uploadHoliday(List<Holidays> lstHoliday);
        #endregion

    }
}
