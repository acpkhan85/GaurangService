using Contract.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity.SmartSchool;
using BAL.SmartSchool.Interface;
using AutoMapper;

namespace Service.SmartSchool
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DashboardService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DashboardService.svc or DashboardService.svc.cs at the Solution Explorer and start debugging.
    public class DashboardService : IDashboardService
    {
        IDashboard _idashboard;

        public DashboardService(IDashboard iDashboard)
        {
            _idashboard = iDashboard;
        }

        public DashboardDto getDashboard()
        {
            //var result = _idashboard.getDashboard();


           // DashboardDto dashboard = AutoMapper.Mapper.Map<Dashboard, DashboardDto>(result);
            DashboardDto dashboard = new DashboardDto();

            //dashboard.News = AutoMapper.Mapper.Map<List<News>, List<NewsDto>>(result.News);
            dashboard.TotalAbsentStudents = 50;
            dashboard.TotalBackOfficeApplications = 37;
            dashboard.TotalStaff = 25;
            dashboard.TotalStudents = 500;
            dashboard.Divisions = new List<DivisionDto>();
            dashboard.Divisions.Add(new DivisionDto { Divison = "A", Standard = "1",Percentage=70, PresentStudent = 50, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "B", Standard = "1", Percentage = 70, PresentStudent = 60, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "C", Standard = "2", Percentage = 70, PresentStudent = 60, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "D", Standard = "2", Percentage = 50, PresentStudent = 0, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "E", Standard = "3",Percentage=70,  PresentStudent = 1, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "F", Standard = "3",Percentage=70,  PresentStudent = 37, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "G", Standard = "4",Percentage=70,  PresentStudent = 42, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "H", Standard = "4",Percentage=20,  PresentStudent = 55, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "I", Standard = "4",Percentage=40,  PresentStudent = 55, TotalStudent = 60 });
            dashboard.Divisions.Add(new DivisionDto { Divison = "J", Standard = "5", Percentage = 70, PresentStudent = 55, TotalStudent = 60 });

            dashboard.Events = new List<EventsDto>();
            dashboard.Events.Add(new EventsDto { Header = "Event 1", EventDescription = "This is test event description", CreateBy = 1, CreatedDate = "13 Hours ago" });
            dashboard.Events.Add(new EventsDto { Header = "Event 2", EventDescription = "This is test event description", CreateBy = 1, CreatedDate = "13 Hours ago" });
            dashboard.Events.Add(new EventsDto { Header = "Event 3", EventDescription = "This is test event description", CreateBy = 1, CreatedDate = "13 Hours ago" });

            dashboard.News = new List<NewsDto>();
            dashboard.News.Add(new NewsDto { Header = "News 2", NewsDescription = "This is test news description", CreateBy = 1, CreatedDate = "12 Hours ago" });
            dashboard.News.Add(new NewsDto { Header = "News 3", NewsDescription = "This is test news description", CreateBy = 1, CreatedDate = "12 Hours ago" });
            dashboard.News.Add(new NewsDto { Header = "News 1", NewsDescription = "This is test news description", CreateBy = 1, CreatedDate = "12 Hours ago" });

            return dashboard;
        }
    }
}
