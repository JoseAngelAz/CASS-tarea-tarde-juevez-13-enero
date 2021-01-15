
using static System.Console;

namespace Jueves13.Ejercicios
{
    public class LetraLoweUpper
    {
        //variables
        string letra;

        //controlador de la case
        public void controllerLoweUpper(){
            PedirLetra();
            ConvertirLetra();
        }
        //pidiendo datos al user
        public void PedirLetra(){
            WriteLine("Ingrese una letra");
            letra = ReadLine();
        }
        //haciendo conversion lowe y upper
        public void ConvertirLetra(){
            if (letra == letra.ToLower())
            {
                WriteLine("Letra: "+letra.ToUpper());
            }else if (letra == letra.ToUpper())
            {
                WriteLine("Letra: "+letra.ToLower());
            }
        }
    }
}