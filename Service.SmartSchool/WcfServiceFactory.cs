using BAL.SmartSchool;
using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using DAL.SmartSchool;
using DAL.SmartSchool.Interface;
using Microsoft.Practices.Unity;
using Unity.Wcf;

namespace Service.SmartSchool
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {            
            container.RegisterType<IUser, User>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();

            container.RegisterType<IClass, ClassSetup>();
            container.RegisterType<IClassRepository, ClassRepository>();
            container.RegisterType<IClassSetupService, ClassSetupService>();

            container.RegisterType<IEventsAndNews, EventsAndNews>();
            container.RegisterType<IEventsAndNewsRepository, EventsAndNewsRepository>();
            container.RegisterType<IEventsAndNewsService, EventsAndNewsService>();

            container.RegisterType<IAbout, About>();
            container.RegisterType<IAboutRepository, AboutRepository>();
            container.RegisterType<IAboutService, AboutService>();

            container.RegisterType<INoticeBoard, NoticeBoard>();
            container.RegisterType<INoticeBoardRepository, NoticeBoardRepository>();
            container.RegisterType<INoticeBoardService, NoticeBoardService>();

            container.RegisterType<IBackOffice, BackOffice>();
            container.RegisterType<IBackOfficeRepository, BackOfficeRepository>();
            container.RegisterType<IBackOfficeService, BackOfficeService>();

            container.RegisterType<IDashboard, Dashboard>();
            container.RegisterType<IDashboardRepository, DashboardRepository>();
            container.RegisterType<IDashboardService, DashboardService>();

            container.RegisterType<IAttendance, Attendance>();
            container.RegisterType<IAttendanceRepository, AttendanceRepository>();
            container.RegisterType<IAttendanceService, AttendanceService>();
        }
    }    
}