using EntityFrameWorkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.Services.Services
{
    public partial class BackOfficeService
    {
        /// <summary>
        /// The database ilms
        /// </summary>
        private DBIEFDemoEntities dbIEFDemoEntities;

        public BackOfficeService()
        {
            dbIEFDemoEntities = new DBIEFDemoEntities();
        }

    }
}
