using BlazorPersonalWebsite.Models;
using BlazorPersonalWebsite.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPersonalWebsite.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoftwareProjectController : ControllerBase
    {
        private ISoftwareProjectRepository _repo;

        public SoftwareProjectController(ISoftwareProjectRepository softwareProjectRepository)
        {
            _repo = softwareProjectRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<SoftwareProject>> Get() 
        {
            return await _repo.ListSoftwareProjectsAsync();
        }
    }
}
