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

        [HttpPost("api/voter/delete/")]
        public IActionResult Delete(int id)
        {
            return Ok(voterRepo.Delete(id));
        }

        [HttpPost("api/voter/deleteAll/")]
        public IActionResult DeleteAll(String name)
        {
            return Ok(voterRepo.DeleteAll(name));
        }

        [HttpPost("api/voter/edit")]
        public IActionResult Edit([FromBody] Voter voter)
        {
            var editedVoter = voterRepo.Edit(voter);
            return Ok(editedVoter);
        }

        [HttpGet("api/voter/getAll")]
        public IActionResult getAll()
        {
            return Ok(voterRepo.getAll());
        }
       

    }
}
