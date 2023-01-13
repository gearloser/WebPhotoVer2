using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPhotosVer2.Controllers;

namespace WebPhotosVer2.Controllers
{
    [Route("main")]
    public class MainController:Controller
    {
        [HttpGet]
        [Route("test")]
        public void Test()
        {
            int i = 0;
            i++;
        }
    }
}
