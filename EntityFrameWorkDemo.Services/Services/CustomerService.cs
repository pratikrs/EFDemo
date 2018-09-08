using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWorkDemo.Entities;
using EntityFrameWorkDemo.Services.Interfaces;

namespace EntityFrameWorkDemo.Services.Services
{
    /// <summary>
    /// Class BackOfficeService.
    /// </summary>
    public partial class BackOfficeService : IBackOfficeService
    {
        public List<Customer> GetCustomers()
        {
            return dbIEFDemoEntities.Customers.ToList();
        }
    }
}
