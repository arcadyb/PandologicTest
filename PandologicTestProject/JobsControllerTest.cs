using Microsoft.Extensions.Logging;
using Moq;
using PandologicReact.Controllers;
using PandologicReact.Models;
using PandologicReact.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PandologicTestProject
{
    public class JobsControllerTest
    {
        JobsController _controller;
        IDataAccessService _service;
        ILogger<DataAccessService> _loggerDa;
        ILogger<JobsController> _loggerJc;

        public JobsControllerTest()
        {
            //or use this short equivalent 
            _loggerJc = Mock.Of<ILogger<JobsController>>();
            _loggerDa = Mock.Of<ILogger<DataAccessService>>();
            _service = new DataAccessService(_loggerDa);
            _controller = new JobsController(_service, _loggerJc);

        }
        [Fact]
        public async Task GetJobsTestAsync()
        {

            var result = await _controller.Get(1);
            //Assert

            Assert.IsType<GChartDataTable>(result);

        }
    }
}

