using Entity.SmartSchool;
using System.Collections.Generic;

namespace BAL.SmartSchool.Interface
{
    public interface IBackOffice
    {
        Message addUpdateProcessDocument(ProcessDocument processDocument);
        List<ProcessDocument> getProcessDocument(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}
