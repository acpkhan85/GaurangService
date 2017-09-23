using DAL.SmartSchool.Interface;
using System.Collections.Generic;
using Entity.SmartSchool;
using System.Data.SqlClient;
using System.Data;

namespace DAL.SmartSchool
{
    public class DashboardRepository : DBHelper, IDashboardRepository
    {
        public Dashboard getDashboard()
        {
            Dashboard dashboard = new Dashboard();
            //List<Division> divisions = null;
            //List<Events> events = null;
            //List<News> newsList = null;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(, connection);
            //    command.CommandType = CommandType.StoredProcedure;
            //    objReader = objCommand.ExecuteReader();
            //    if (objReader.HasRows)
            //    {
            //        divisions = new List<Division>();
            //        events = new List<Events>();
            //        newsList = new List<News>();

            //        #region Divisions
            //        while (objReader.Read())
            //        {
            //            Division division = new Division();
            //            division.Divison = objReader["Divison"].ToString();
            //            division.TotalStudent = (int)objReader["TotalStudent"];
            //            division.PresentStudent = (int)objReader["PresentStudent"];
            //            divisions.Add(division);
            //        }
            //        dashboard.Divisions = divisions;
            //        #endregion

            //        #region Events
            //        objReader.NextResult();
            //        while (objReader.Read())
            //        {
            //            Events eventObject = new Events();
            //            eventObject.Header = objReader["Header"].ToString();
            //            eventObject.EventDescription = objReader["EventDescription"].ToString();
            //            eventObject.CreateBy = (int)objReader["CreateBy"];
            //            eventObject.CreatedDate = objReader["CreatedDate"].ToString();
            //            events.Add(eventObject);
            //        }
            //        dashboard.Events = events;
            //        #endregion

            //        #region News
            //        objReader.NextResult();
            //        while (objReader.Read())
            //        {
            //            News news = new News();
            //            news.Header = objReader["Header"].ToString();
            //            news.NewsDescription = objReader["NewsDescription"].ToString();
            //            news.CreateBy = (int)objReader["CreateBy"];
            //            news.CreatedDate = objReader["CreatedDate"].ToString();
            //            newsList.Add(news);
            //        }
            //        dashboard.News = newsList; 
            //        #endregion
            //    }
            //}

            dashboard.TotalAbsentStudents = 50;
            dashboard.TotalBackOfficeApplications = 37;
            dashboard.TotalStaff = 25;
            dashboard.TotalStudents = 500;
            dashboard.Divisions = new List<Division>();
            dashboard.Divisions.Add(new Division { Divison = "A", Standard = "1", PresentStudent = 50, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "B", Standard = "1", PresentStudent = 60, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "C", Standard = "2", PresentStudent = 60, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "D", Standard = "2", PresentStudent = 0, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "E", Standard = "3", PresentStudent = 1, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "F", Standard = "3", PresentStudent = 37, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "G", Standard = "4", PresentStudent = 42, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "H", Standard = "4", PresentStudent = 55, TotalStudent = 60 });
            dashboard.Divisions.Add(new Division { Divison = "I", Standard = "4", PresentStudent = 55, TotalStudent = 60 });

            dashboard.Events = new List<Events>();
            dashboard.Events.Add(new Events { Header = "Event 1", EventDescription = "This is test event description", CreateBy = 1, CreatedDate = "13 Hours ago"});
            dashboard.Events.Add(new Events { Header = "Event 2", EventDescription = "This is test event description", CreateBy = 1, CreatedDate = "13 Hours ago" });
            dashboard.Events.Add(new Events { Header = "Event 3", EventDescription = "This is test event description", CreateBy = 1, CreatedDate = "13 Hours ago" });

            dashboard.News = new List<News>();
            dashboard.News.Add(new News { Header = "News 2", NewsDescription = "This is test news description", CreateBy = 1, CreatedDate = "12 Hours ago" });
            dashboard.News.Add(new News { Header = "News 3", NewsDescription = "This is test news description", CreateBy = 1, CreatedDate = "12 Hours ago" });
            dashboard.News.Add(new News { Header = "News 1", NewsDescription = "This is test news description", CreateBy = 1, CreatedDate = "12 Hours ago" });


            return dashboard;
        }
    }
}
