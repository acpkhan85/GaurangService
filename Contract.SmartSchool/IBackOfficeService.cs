using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IBackOfficeService
    {
        [OperationContract]
        Message addUpdateProcessDocument(ProcessDocument processDocument);
        [OperationContract]
        List<ProcessDocument> getProcessDocument(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}