using AutoMapper;
using BAL.SmartSchool;
using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.SmartSchool.CustomMapper
{
    public class DashboardDTOMapper : ITypeConverter<Entity.SmartSchool.Dashboard, DashboardDto>
    {
        //public DashboardDto Convert(ResolutionContext context)
        //{
        //    var personData = context.SourceValue as Dashboard;
        //}

        public DashboardDto Convert(Entity.SmartSchool.Dashboard source, DashboardDto destination, ResolutionContext context)
        {
            var dashboardDTO = context.Items as Entity.SmartSchool.Dashboard;
            DashboardDto dto = new DashboardDto();

            foreach (var item in dashboardDTO.News)
            {
              
              
            }

            return dto;

        }
    }
}