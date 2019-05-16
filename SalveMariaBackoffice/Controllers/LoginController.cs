using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalveMariaBackoffice.Data;
using SalveMariaBackoffice.Models;

namespace SalveMariaBackoffice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private ApplicationDbContext _context;


        public LoginController(ApplicationDbContext context)
        {
            _context = context;

        }


        // GET: api/<controller>
        [HttpPost]
        public Usuario Logar(Models.Login login)
        {
            return _context.Usuario.Where(x => x.Login.ToUpper().Trim() == login.Usuario.ToUpper().Trim() && x.Senha.ToUpper().Trim() == login.Senha.ToUpper().Trim()).FirstOrDefault();
        }

    }
}