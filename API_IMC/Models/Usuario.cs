using System;

namespace API_IMC.Models
{
    public class Usuario
    {
        public Usuario() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
