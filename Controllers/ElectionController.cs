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
    public class ElectionController : ControllerBase
    {
        private readonly ElectionRepo electionRepo = new ElectionRepo();

        [HttpPost("api/election/add")]
        public IActionResult Add([FromBody] Election election)
        {
            return Ok(electionRepo.Add(election));
        }

        [HttpPost("api/election/edit")]
        public IActionResult Edit([FromBody] Election election)
        {
            return Ok(electionRepo.Edit(election));
        }

        [HttpDelete("api/election/delete")]
        public IActionResult Delete(int id)
        {
            return Ok(electionRepo.Delete(id));
        }

        [HttpGet("api/election/getall")]
        public IActionResult GetAll()
        {
            return Ok(electionRepo.GetAll());
        }

        [HttpPost("api/election/get")]
        public IActionResult Get([FromBody] int id)
        {
            return Ok(electionRepo.Get(id));
        }

        [HttpPost("api/election/freeze")]
        public IActionResult Freeze([FromBody] int id)
        {
            return Ok(electionRepo.changeFreezeState(id));
        }

        [HttpPost("api/election/publish")]
        public IActionResult Publish([FromBody] int id)
        {
            return Ok(electionRepo.changePublishState(id));
        }
    }
}
