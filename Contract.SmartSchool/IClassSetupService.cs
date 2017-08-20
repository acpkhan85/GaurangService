
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
        List<ClassRoomDto> getStandardDivision(int? standard, int? division, int schoolId, Pagination pagination, out int totalNoOfRecords);
        #endregion

        #region StudentSetup
        [OperationContract]
        List<Student> getStudent(int studentId, int classId, Pagination pagination, out int totalNoOfRecords);
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
        List<TimeTable> getTimeTable(int classId);
        #endregion

        #region Exam

        [OperationContract]
        List<ExamTimeTable> getExamTimeTable(int classId);
        [OperationContract]
        Message addUpdateExamTimeTable(ExamTimeTable examTimeTable);
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
