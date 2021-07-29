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
    public class AdminController : ControllerBase
    {
        private readonly AdminRepo adminRepo = new AdminRepo();

        [HttpPost("api/admin/add")]
        public IActionResult Add([FromBody] Admin admin)
        {
            return Ok(adminRepo.Add(admin));
        }

        [HttpDelete("api/admin/delete")]
        public IActionResult Delete(String username)
        {
            return Ok(adminRepo.Delete(username));
        }



        [HttpPost("api/admin/edit")]
        public IActionResult Edit([FromBody] Admin admin)
        {
            return Ok(adminRepo.Edit(admin));
        }

        [HttpPost("api/admin/check")]
        public IActionResult Check([FromBody] Admin admin)
        {
            return Ok(adminRepo.CheckInfo(admin));
        }

        [HttpPost("api/admin/get")]
        public IActionResult Get([FromBody]int id)
        {
            return Ok(adminRepo.GetByID(id));
        }

        [HttpPost("api/admin/get")]
        public IActionResult Get([FromBody] String username)
        {
            return Ok(adminRepo.GetByName(username));
        }

        [HttpGet("api/admin/getAll")]
        public IActionResult GetAll()
        {
            return Ok(adminRepo.GetAll());
        }
    }
}
