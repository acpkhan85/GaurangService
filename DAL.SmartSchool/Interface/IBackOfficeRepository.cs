using Entity.SmartSchool;
using System.Collections.Generic;

namespace DAL.SmartSchool.Interface
{
    public interface IBackOfficeRepository
    {
        Message addUpdateProcessDocument(ProcessDocument processDocument);
        List<ProcessDocument> getProcessDocument(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}
