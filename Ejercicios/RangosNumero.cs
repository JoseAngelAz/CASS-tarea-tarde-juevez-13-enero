using static System.Console;

namespace Jueves13.Ejercicios
{
    public class RangosNumero
    {
        //variables
        double cantidad;

        //controlador de la clase
        public void ControlladorClaseRango(){
            pedirvalores();
            validar_rango();
        }

        //pedir valor al usuario
        public void pedirvalores(){
            cantidad = double.Parse(ReadLine());
        }

        //validadores de logica        
        public void validar_rango(){            
            switch (cantidad)
            {
                case 1:
                WriteLine("UNO");
                break;
                case 2:
                WriteLine("DOS");
                break;
                case 3:
                WriteLine("TRES");
                break;
                case 4:
                WriteLine("CUATRO");
                break;
                case 5:
                WriteLine("CINCO");
                break;
                case 6:
                WriteLine("SEIS");
                break;
                case 7:
                WriteLine("SIETE");
                break;
                case 8:
                WriteLine("OCHO");
                break;
                case 9:
                WriteLine("NUEVE");
                break;
                case 10:
                WriteLine("DIEZ");
                break;
            }
        }
    }
}