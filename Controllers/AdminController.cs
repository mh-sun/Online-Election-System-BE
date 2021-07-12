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
            var addedAdmin = adminRepo.Add(admin);
            return Ok(addedAdmin);
        }

        [HttpPost("api/admin/delete/")]
        public IActionResult Delete([FromBody] int id)
        {
            return Ok(adminRepo.Delete(id));
        }

        [HttpPost("api/admin/deleteAll/")]
        public IActionResult DeleteAll([FromBody] String name)
        {
            return Ok(adminRepo.DeleteAll(name));
        }

        [HttpPost("api/admin/edit")]
        public IActionResult Edit([FromBody] Admin admin)
        {
            var editedAdmin = adminRepo.Edit(admin);
            return Ok(editedAdmin);
        }
    }
}
