using static System.Console;

namespace Jueves13.Ejercicios
{
    public class Kilos_a_Libras
    {
        double kg;
        double lb;

        //controlador de la clase
        public void ControladorConversorKg(){
            PedirCantidad();
            ConvertirKgToLibras();
        }

        //pedir la cantidad de kg
        public void PedirCantidad()
        {   WriteLine("Ingrese la cantidad de kilos");
            kg = double.Parse(ReadLine());
        }

        //convertir kg a lb    
        public void ConvertirKgToLibras(){
            double conversion = kg * 2.20462;
            WriteLine("El resultado de convertir "+ kg +"Kg a Libras es: "+ conversion);
        }

    }

}