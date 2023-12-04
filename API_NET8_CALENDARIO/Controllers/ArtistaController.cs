
using API_net_core_calendario.Models;
using API_NET8_CALENDARIO.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API_net_core_calendario.Controllers
{
    [ApiController]
    [Route("artista")]
    public class ArtistaController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarArtista()
        {
            //tod el codigo que necesite, pero necesito un return de algo 
            List<Artista> artistas = new List<Artista> {

                new Artista{
                    id="1",
                    correo="artista1@artista.com",
                    edad="21",
                    nombre="ALejandro Peralta"
                },
                new Artista{
                    id="2",
                    correo="artist2@artista.com",
                    edad="22",
                    nombre="Alezander el peruano"
                }

            };
            /*
            return new
            {
                nombre = "Mateo",
                Edad = "21"

            };*/
            return artistas;

        }


        [HttpGet]
        [Route("listar_ID")]
        public dynamic listarArtistaID(string codigo)
        {
            // se obtiene el cleine de la db

            return new Artista
            {
                id = codigo.ToString(),
                correo = "artist2@artista.com",
                edad = "22",
                nombre = "Alezander el peruano"
            };

        }


        [HttpPost]
        [Route("guardar")]
        public dynamic guardarArtista(Artista artista)
        {
            artista.id = "3";
            return new
            {
                success = true,
                message = "artista registro",
                result = artista
            };
        }


        [HttpPost]
        [Route("Eliminar")]
        [Authorize]
        public dynamic eliminarArtista(Artista artista)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            var rToken = Jwt.validarToken(identity);

            if (!rToken.success) return rToken;

            Usuario usuario = rToken.result;
            if (usuario.rol != "administrador") {
                return new
                {
                    success=false,
                    message="no tinee oermiso par eliminar clientes",
                    result=""
                };
            }

            return new
            {
                success = true,
                message = "artista eliminado",
                result = artista
            };
        }
    }
}

