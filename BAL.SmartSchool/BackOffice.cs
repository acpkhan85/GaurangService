using BAL.SmartSchool.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;
using DAL.SmartSchool.Interface;

namespace BAL.SmartSchool
{
    public class BackOffice : IBackOffice
    {
        IBackOfficeRepository _backOfficeRepository;

        public BackOffice(IBackOfficeRepository backOfficeRepository)
        {
            _backOfficeRepository = backOfficeRepository;
        }

        public Message addUpdateProcessDocument(ProcessDocument processDocument)
        {
            return _backOfficeRepository.addUpdateProcessDocument(processDocument);
        }

        public List<ProcessDocument> getProcessDocument(int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            throw new NotImplementedException();
        }
    }
}
