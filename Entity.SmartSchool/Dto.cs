using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SmartSchool
{
    public class MessageDTO
    {
        public string message { get; set; }
        public int status { get; set; }
    }

    public class ClassRoomDto
    {
        public int ClassId { get; set; }
        public string Standard { get; set; }
        public string Division { get; set; }
    }
    public class StudentDto
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BloodGroup { get; set; }
        public string ParentCellNumber { get; set; }
    }
    public class TimeTableDto
    {
        public int TimeTableID { get; set; }
        public int ClassId { get; set; }
        public string Mon { get; set; }
        public string Tue { get; set; }
        public string Wed { get; set; }
        public string Thu { get; set; }
        public string Fri { get; set; }
        public string Sat { get; set; }
        public string Sun { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }
    public class ExamTimeTableDto
    {

        public string ExamTimeTableID { get; set; }
        public int ClassId { get; set; }
        public string Subject { get; set; }
        public string FromDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string Location { get; set; }
        public string Batch { get; set; }


    }
}
