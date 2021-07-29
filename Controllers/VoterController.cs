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

        [HttpDelete("api/voter/delete")]
        public IActionResult Delete(int id)
        {
            return Ok(voterRepo.Delete(id));
        }

        [HttpPost("api/voter/edit")]
        public IActionResult Edit([FromBody] Voter voter)
        {
            return Ok(voterRepo.Edit(voter));
        }

        [HttpGet("api/voter/getAll")]
        public IActionResult getAll()
        {
            return Ok(voterRepo.getAll());
        }

        [HttpPost("api/voter/check")]
        public IActionResult Check([FromBody] Voter voter)
        {
            return Ok(voterRepo.CheckInfo(voter));
        }

        [HttpGet("api/voter/get")]
        public IActionResult Get(int id)
        {
            return Ok(voterRepo.GetByID(id));
        }
    }
}
