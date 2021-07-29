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
            return Ok(candidateRepo.Add(candidate));
        }

        [HttpPost("api/candidate/edit")]
        public IActionResult Edit([FromBody] Candidate candidate)
        {
            return Ok(candidateRepo.Edit(candidate));
        }

        [HttpDelete("api/candidate/delete")]
        public IActionResult Delete( int id)
        {
            return Ok(candidateRepo.Delete(id));
        }
        [HttpDelete("api/candidate/deleteall")]
        public IActionResult DeleteAllByEId(int id)
        {
            return Ok(candidateRepo.DeleteByEId(id));
        }


        [HttpGet("api/candidate/getall")]
        public IActionResult GetAll()
        {
            return Ok(candidateRepo.GetAll());
        }

        [HttpPost("api/candidate/getbyeid")]
        public IActionResult Get([FromBody] int eid)
        {
            return Ok(candidateRepo.GetByEId(eid));
        }

        [HttpPost("api/candidate/vote")]
        public IActionResult Vote([FromBody] int[] ids)
        {
            return Ok(candidateRepo.Vote(ids));
        }

    }
}
