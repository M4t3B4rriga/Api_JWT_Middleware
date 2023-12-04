namespace API_NET8_CALENDARIO.Models
{
    public class Usuario
    {
        public string idUsuario {  get; set; }
        public string usuario { get; set; }
        public string pasword {  get; set; }
        public string rol { get; set; }

        public static List<Usuario> DB() {

            var list = new List<Usuario>() {
                new Usuario()
                {
                    idUsuario="1",
                    usuario="Mateo",
                    pasword="123.",
                    rol="empleado"
                },

                  new Usuario()
                {
                    idUsuario="2",
                    usuario="Alex",
                    pasword="123.",
                    rol="empleado"
                },
                    new Usuario()
                {
                    idUsuario="3",
                    usuario="Nicole",
                    pasword="123.",
                    rol="asesor"
                },
                    new Usuario()
                {
                    idUsuario="4",
                    usuario="Anahi",
                    pasword="123.",
                    rol="administrador"
                },

            };
            return list;
        }
    }
}
