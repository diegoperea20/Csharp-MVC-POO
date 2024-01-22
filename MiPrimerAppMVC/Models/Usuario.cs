namespace MiPrimerAppMVC.Models
{
    public class Usuario{
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Correo { get; set; }

        public byte[] PasswordHash { get; set; }

        public Byte[] PasswordSalt { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}