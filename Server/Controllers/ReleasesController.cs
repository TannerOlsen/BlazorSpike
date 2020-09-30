using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorSpike.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSpike.Server.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ReleasesController : ControllerBase
    {
        private Release[] releases = new[]
        {
            new Release(1, "1st", "first note"),
            new Release(2, "2nd", "second note"),
            new Release(3, "3rd", "third note"),
            new Release(4, "4th", "fourth note")
        };

        //private Release[] releases = new[]
        //{
        //    new Release
        //    {
        //        Id = 1,
        //        Name = "1st",
        //        Notes = "first note"
        //    },
        //    new Release
        //    {
        //        Id = 2,
        //        Name = "2nd",
        //        Notes = "second note"
        //    },
        //    new Release
        //    {
        //        Id = 3,
        //        Name = "3rd",
        //        Notes = "third note"
        //    },
        //    new Release
        //    {
        //        Id = 4,
        //        Name = "4th",
        //        Notes = "fourth note"
        //    }
        //};

        //[Route("api/[controller]")]
        [HttpGet("api/[controller]")]
        public IEnumerable<Release> GetAllReleases()
        {
            return releases;
        }

        //[Route("api/[controller]/{id}")]
        [HttpGet("api/[controller]/{id}")]
        public Release GetReleaseById(int id)
        {
            return releases.Where(release => release.Id == id).FirstOrDefault();
        }
    }
}
