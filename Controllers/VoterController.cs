using ElectionSys.Models;
using ElectionSys.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Controllers
{
    public class VoterController : Controller
    {
        private readonly VoterRepo voterRepo = new VoterRepo();

        [HttpPost("api/voter/add")]
        public IActionResult Add([FromBody] Voter voter)
        {
            var addedVoter = voterRepo.Add(voter);
            return Ok(addedVoter);
        }

    }
}
