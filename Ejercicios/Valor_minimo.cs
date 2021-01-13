using static System.Console;

namespace Jueves13.Ejercicios
{
    public class Valor_minimo
    {
        double n_1, n_2;

        //metodo conseguir valor minimo
        public void valor_m(){
            WriteLine("Digite el primer valor: \n");
            n_1 = double.Parse(ReadLine());
            WriteLine("Digite el primer valor: \n");
            n_2 = double.Parse(ReadLine());

            if (n_1 < n_2)
            {
                WriteLine("El primer valor: "+n_1+" es el valor minimo");
            }else if(n_2 < n_1){
                WriteLine("El primer valor: "+n_1+" es el valor minimo");
            }
        }
    }
}