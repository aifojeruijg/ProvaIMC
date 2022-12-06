using System;

namespace API_IMC.Models
{
    public class Imc
    {
        public Imc() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public double Altura { get; set; }
        public int Peso { get; set; }
        public double ImcFinal { get; set; }

        public string Categoria { get; set; }

        //relacionamento
        public int UsuarioId { get; set;}
        public Usuario Usuario { get; set;}

        public DateTime CriadoEm { get; set;}
    }
}
