using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWorkDemo.Entities;

namespace EntityFrameWorkDemo.Services.Interfaces
{
    public partial interface IBackOfficeService
    {
        List<Customer> GetCustomers();
    }
}
