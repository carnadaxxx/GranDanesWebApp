namespace GranDanesWebApp.Models.Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Visible { get; set; }
        public string Contraseña { get; set; }
        public DateTime? UltimoAcceso { get; set; }

        public ICollection<ClienteRol> ClienteRoles { get; set; }
    }

    public class ClienteRol
    {
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public int RolID { get; set; }
        public Rol Rol { get; set; }

        public DateTime? FechaAsignacion { get; set; }
    }

    public class Rol
    {
        public int RolID { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }

        public ICollection<ClienteRol> ClienteRoles { get; set; }
    }

}
