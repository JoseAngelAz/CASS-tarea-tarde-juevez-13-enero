using static System.Console;

namespace Jueves13.Ejercicios
{
    public class Amayuscula
    {
        //variables
        string letra;
        //controlador de la clase
        public void ControladorLetra(){
            PedirLetraA();
            ValidarLetraA();
        }
        //pidiendo datos al usuario
        public void PedirLetraA(){
            WriteLine("Ingrese una Letra\n");
            letra = ReadLine();
        }
        //logica del ejercicio
        public void ValidarLetraA(){
            WriteLine((letra.Equals("A")?"Calificacion Excelente":"Alumno Promedio"));
        }
    }
}