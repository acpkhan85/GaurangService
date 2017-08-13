using Contract.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity.SmartSchool;
using BAL.SmartSchool.Interface;

namespace Service.SmartSchool
{
    public class BackOfficeService : IBackOfficeService
    {
        IBackOffice _backOffice;

        public BackOfficeService(IBackOffice backOffice)
        {
            _backOffice = backOffice;
        }

        public Message addUpdateProcessDocument(ProcessDocument processDocument)
        {
            return _backOffice.addUpdateProcessDocument(processDocument);
        }
        
        public List<ProcessDocument> getProcessDocument(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            throw new NotImplementedException();
        }
    }
}
 