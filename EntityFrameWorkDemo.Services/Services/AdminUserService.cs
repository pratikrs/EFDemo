using EntityFrameWorkDemo.Entities;
using EntityFrameWorkDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.Services.Services
{
    /// <summary>
    /// Class BackOfficeService.
    /// </summary>
    public partial class BackOfficeService : IBackOfficeService
    {
        public List<AdminUser> GetUserInfos()
        {
            return dbIEFDemoEntities.AdminUsers.ToList();
        }
    }
}
