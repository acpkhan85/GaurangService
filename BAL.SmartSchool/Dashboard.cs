using BAL.SmartSchool.Interface;
using DAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.SmartSchool
{
    public class Dashboard : IDashboard
    {
        IDashboardRepository _iDashboardRepository;

        public Dashboard(IDashboardRepository uashboardRepository)
        {
            _iDashboardRepository = uashboardRepository;
        }
             

        public Entity.SmartSchool.Dashboard getDashboard()
        {
            Entity.SmartSchool.Dashboard dashboard = _iDashboardRepository.getDashboard();

            //dashboard.Divisions.ForEach(e => e.Percentage = (e.PresentStudent / e.TotalStudent) * 100);

            int divisionCount = dashboard.Divisions.Count();
            for (int d = 0; d < divisionCount; d++)
            {
                dashboard.Divisions[d].Percentage = (dashboard.Divisions[d].PresentStudent * 100) / dashboard.Divisions[d].TotalStudent;
            }

            return dashboard;
        }
    }
}
