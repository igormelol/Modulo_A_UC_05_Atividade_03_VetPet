using System;

namespace ClinicaVetPet.Models
{
    public class Mensagem
    {
        public string mensagem {get; set;}  // Propriedades...
        public string nome {get; set;}       // Propriedades...
        public string email {get; set;}
        public string telefone {get; set;}     // Propriedades...
        public string animal {get; set;}
        public int tipoMensagem {get; set;}
        public DateTime data {get; set;}
        public string dataString { get; set; }   // Propriedades...
    }
}