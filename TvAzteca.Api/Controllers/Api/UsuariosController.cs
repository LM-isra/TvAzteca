using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TvAzteca.Core.Entities;
using TvAzteca.Core.Services;

namespace TvAzteca.Api.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly IUsuarioService _UsuarioService;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuarioService UsuarioService, IMapper mapper)
        {
            _UsuarioService = UsuarioService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            var usuarios = await _UsuarioService.GetAllUsuarios();
            return Ok(usuarios);
        }

    }
}
