﻿namespace IntuitChallenge.DTOs.Response
{
    public record ClienteResponse
    {
        
        public ClienteResponse()
        {
                
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CUIT { get; set; }
        public string Domicilio { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public string NombreApellido => $"{this.Nombre} {this.Apellido}";
    }
}
