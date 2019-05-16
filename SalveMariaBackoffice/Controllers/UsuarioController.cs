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
    public class UsuarioController : ControllerBase
    {

        private ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;

        }

        [HttpPost]
        public Usuario Cadastrar(Models.Usuario usuario)
        {
            
            var usuarioBanco = _context.Usuario.Where(x => x.Login.Trim().ToUpper() == usuario.Login.Trim().ToUpper()
                       ||
                       x.Email.Trim().ToUpper() == usuario.Email.Trim().ToUpper()
                       ||
                       x.CPF.Trim().ToUpper() == usuario.CPF.Trim().ToUpper()
                        ).FirstOrDefault();

            if (usuarioBanco != null)
                return null;

            _context.Usuario.Add(usuario);
            _context.SaveChanges();

            return usuario;
        }
    }
}