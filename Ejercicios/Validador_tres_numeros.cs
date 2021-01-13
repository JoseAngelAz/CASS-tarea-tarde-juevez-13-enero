using static System.Console;

namespace Jueves13.Ejercicios
{
    public class Validador_tres_numeros
    {
        //variables
        double n_1,n_2,n_3;

        //controlador de la clase
        public void ControladorVal3numero(){
            PedirNumeros();
            Validando3Numeros();
        }
        //pidiendo datos
        public void PedirNumeros(){
            WriteLine("Ingrese el primer valor:\n");
            n_1 = double.Parse(ReadLine());
            WriteLine("Ingrese el segundo valor:\n");
            n_2 = double.Parse(ReadLine());
            WriteLine("Ingrese el tercer valor:\n");
            n_3 = double.Parse(ReadLine());
        }

        //validando datos
        public void Validando3Numeros(){
            if (n_1 > n_2 && n_1 > n_3)
            {
                WriteLine("El primer numero ("+n_1+") es el mayor.");
            }else if (n_2 > n_1 && n_2 >n_3)
            {
                WriteLine("El segundo numero ("+n_2+") es el mayor.");
            }else if (n_3 > n_1 && n_3 > n_2)
            {
                WriteLine("El tercer numero ("+n_3+") es el mayor.");
            }else if (
                n_1 == n_2 || n_1 == n_3||
                n_2 == n_1 || n_2 == n_1||
                n_3 == n_1 || n_3 == n_2
                )
            {
                WriteLine("Los numeros:\n"
                +"VALOR UNO: "+n_1+"\n"+
                "VALOR DOS: "+n_2+"\n"+
                "VALOR TRES: "+n_3+"\nSon iguales."
                );
            }
        }
    }
}