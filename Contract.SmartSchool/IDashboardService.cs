using Entity.SmartSchool;
using System.ServiceModel;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IDashboardService 
    {
        [OperationContract]
        DashboardDto getDashboard();
    }
}
