using DAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;
using System.Data.SqlClient;
using System.Data;
using Common.SmartSchool;

namespace DAL.SmartSchool
{
    public class EventsAndNewsRepository : DBHelper, IEventsAndNewsRepository
    {
        public Message addUpdateEvents(Events events)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateEvents, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EventId", events.EventId);
                command.Parameters.AddWithValue("@Header", events.Header);
                command.Parameters.AddWithValue("@LocationImage", events.LocationImage);
                command.Parameters.AddWithValue("@EventDescription", events.EventDescription);
                command.Parameters.AddWithValue("@Location", events.Location);
                command.Parameters.AddWithValue("@StartDate", events.StartDate);
                command.Parameters.AddWithValue("@EndDate", events.EndDate);
                command.Parameters.AddWithValue("@SchoolId", events.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", events.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", events.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", events.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", events.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
                msg.message = msg.status == 1 ? Constants.savedSuccessfully : Constants.saveUnuccessfull;
            }

            return msg;
        }

        public Message addUpdateNews(News news)
        {
            Message msg = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                msg = new Message();
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateNews, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@newsId", news.newsId);
                command.Parameters.AddWithValue("@Image", news.Image);
                command.Parameters.AddWithValue("@Header", news.Header);
                command.Parameters.AddWithValue("@NewsDescription", news.NewsDescription);
                command.Parameters.AddWithValue("@SchoolId", news.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", news.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", news.UpdatedBy);
                command.Parameters.AddWithValue("@CreatedDate", news.CreatedDate);
                command.Parameters.AddWithValue("@UpdatedDate", news.UpdatedDate);
                msg.status = command.ExecuteNonQuery();
                msg.message = msg.status == 1 ? Constants.savedSuccessfully : Constants.saveUnuccessfull;
            }

            return msg;
        }

        public List<Events> getEvents(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            List<Events> lstEvents = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                totalNoOfRecords = 0;
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetEvents, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PageNbr", pagination.PageNumber);
                command.Parameters.AddWithValue("@PageSize", pagination.PageSize);
                command.Parameters.AddWithValue("@SortCol", pagination.SortColumn);
                command.Parameters.AddWithValue("@SchoolId", schoolId);
                objReader = command.ExecuteReader();
                if (objReader.HasRows)
                {
                    lstEvents = new List<Events>();
                    while (objReader.Read())
                    {
                        totalNoOfRecords = (int)objReader["TotalCount"];
                        Events objEvents = new Events();
                        objEvents.Header = objReader["Header"].ToString();
                        objEvents.LocationImage = objReader["LocationImage"].ToString();
                        objEvents.EventDescription = objReader["EventDescription"].ToString();
                        objEvents.Location = objReader["Location"].ToString();
                        objEvents.LocationImage = objReader["LocationImage"].ToString();
                        lstEvents.Add(objEvents);
                    }
                }
            }
            return lstEvents;
        }

        public List<News> getNews(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            List<News> lstNews = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                totalNoOfRecords = 0;
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_GetNews, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PageNbr", pagination.PageNumber);
                command.Parameters.AddWithValue("@PageSize", pagination.PageSize);
                command.Parameters.AddWithValue("@SortCol", pagination.SortColumn);
                command.Parameters.AddWithValue("@SchoolId", schoolId);
                objReader = command.ExecuteReader();
                if (objReader.HasRows)
                {
                    lstNews = new List<News>();
                    while (objReader.Read())
                    {
                        totalNoOfRecords = (int)objReader["TotalCount"];
                        News objNews = new News();
                        objNews.Image = objReader["Image"].ToString();
                        objNews.Header = objReader["Header"].ToString();
                        objNews.NewsDescription = objReader["NewsDescription"].ToString();
                        lstNews.Add(objNews);
                    }
                }
            }
            return lstNews;
        }
    }
}
