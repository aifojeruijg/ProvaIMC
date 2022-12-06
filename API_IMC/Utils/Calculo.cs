namespace API.Utils
{
    public class Calculos
    {
        public static double CalcularIMC(int Peso, double Altura)
         => Peso / (Altura * Altura);

        public static string CalcularCategoria(double CalcularIMC)
         {
            if (CalcularIMC <= 18.5 ) return "Magreza";
            if (CalcularIMC <= 24.9) return "Normal";
            if (CalcularIMC <= 29.9) return "Sobrepeso";
            if (CalcularIMC <= 39.9) return "Obesidade";

            return("Obesidade Grave");
         }

         
        
    }
}