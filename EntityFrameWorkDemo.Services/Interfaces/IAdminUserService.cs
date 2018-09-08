using EntityFrameWorkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.Services.Interfaces
{
    public partial interface IBackOfficeService
    {
        List<AdminUser> GetUserInfos();
    }
}
