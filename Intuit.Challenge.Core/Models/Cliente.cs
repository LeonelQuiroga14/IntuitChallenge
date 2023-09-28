namespace Intuit.Challenge.Core.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public Cliente(int id,string nombre, string apellido, DateTime fechaNac, string cuit = null, string domicilio = null, string tel = null, string email = null)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNac;
            this.CUIT = cuit;
            this.Domicilio = domicilio;
            this.TelefonoCelular = tel;
            this.Email = email;
        }
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string CUIT { get; set; }
        public string Domicilio { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
    }
}
