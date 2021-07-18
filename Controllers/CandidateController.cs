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
    public class CandidateController : ControllerBase
    {
        private readonly CandidateRepo candidateRepo = new CandidateRepo();

        [HttpPost("api/candidate/add")]
        public IActionResult Add([FromBody] Candidate candidate)
        {
            var addedCandidate = candidateRepo.Add(candidate);
            return Ok(candidate);
        }

        [HttpPost("api/candidate/edit")]
        public IActionResult Edit([FromBody] Candidate candidate)
        {
            var editedCandidate = candidateRepo.Edit(candidate);
            return Ok(editedCandidate);
        }

        [HttpPost("api/candidate/delete/")]
        public IActionResult Delete([FromBody] int id)
        {
            return Ok(candidateRepo.Delete(id));
        }

        [HttpPost("api/candidate/deleteall/")]
        public IActionResult DeleteAll([FromBody] String name)
        {
            return Ok(candidateRepo.DeleteAll(name));
        }

        [HttpPost("api/candidate/getall/")]
        public IActionResult GetAll()
        {
            return Ok(candidateRepo.GetAll());
        }

    }
}
