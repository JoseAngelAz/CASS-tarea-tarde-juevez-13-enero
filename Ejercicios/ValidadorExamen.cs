using static System.Console;

namespace Jueves13.Ejercicios
{
    public class ValidadorExamen
    {
        double nota;
        public void ControladorExamen(){
            ConseguirNotaExamen();
            ValidarNotaExamen();
        }
        
        //Conseguir la nota
        public void ConseguirNotaExamen(){
            WriteLine("Ingrese su nota de examen: ");
            nota = double.Parse(ReadLine());
        }
        
        
        //validar nota del examen
        public void ValidarNotaExamen(){
            if (nota == 6 || nota > 6)
            {
                WriteLine("Usted aprobo su examen");
            }
            else if (nota < 6)
            {
                WriteLine("Usted reprobo su examen");
            }
        }
    }
}