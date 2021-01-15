using static System.Console;

namespace Jueves13.Ejercicios
{
    public class Tablas15
    {
        //variables
        int numero;
        //controlador de la clase
        public void ControladorTablas()
        {
            PedirNumeroTabla();
            CrearTablas();
        }
        //pedir valor al usuario
        public void PedirNumeroTabla()
        {
            WriteLine("Ingresa un numero\n");
            numero = int.Parse(ReadLine());
        }
        //validar logica de negocio
        public void CrearTablas()
        {WriteLine("TABLA RESULTANTE\n");
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 0; j <1; j++)
                {
                    WriteLine(numero +" X "+ i +" = "+  (numero * i) );
                }
            }
        }
    }
}