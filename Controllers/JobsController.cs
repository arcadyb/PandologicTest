
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PandologicReact.Models;
using PandologicReact.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace PandologicReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobsController : ControllerBase
    {
        private IDataAccessService _jobsRepo;
 
        private readonly ILogger<JobsController> _logger;

        public JobsController(
            IDataAccessService da,
            ILogger<JobsController> logger
            )
        {
            _jobsRepo = da;
            _logger = logger;
        }
        [HttpGet]
        public async Task<GChartDataTable> Get(int pageId)
        {
            try
            {
                var ret = await _jobsRepo.GetPageGobs(pageId);
                return ret;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                throw new HttpListenerException( );
            }
        }
 
    }
}
