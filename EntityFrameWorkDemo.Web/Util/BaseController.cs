using EntityFrameWorkDemo.Services.Interfaces;
using EntityFrameWorkDemo.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWorkDemo.Web.Util
{
    public class BaseController : Controller
    {
        IBackOfficeService _client;

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public IBackOfficeService Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new BackOfficeService();
                }
                return _client;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        public BaseController()
        {
            //_client = new BackOfficeService();
        }
	}
}