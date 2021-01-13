using System;
using static System.Console;
using Jueves13.Ejercicios;

namespace Jueves13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione que numero de programa desea ejecutar:\n"
            + "1-VALOR MINIMO ENTRE 2 NUMEROS\n"+
            "2-VALIDADOR DE EXAMEN\n"+
            "3-CONVERSOR DE Kg a Lb\n"+
            "4-VALIDADOR DE 3 NUMEROS\n"
            );
            int resp = int.Parse(ReadLine());

            switch (resp)
            {
                case 1:
                //llamando clase
                var vm = new Valor_minimo();
                vm.valor_m();
                break;
                case 2:
                //llamando clase examen
                var c_exam = new ValidadorExamen();
                c_exam.ControladorExamen();
                break;
                case 3:
                //llamando conversor kg to lb
                var c_Kg = new Kilos_a_Libras();
                c_Kg.ControladorConversorKg();
                break;
                case 4:
                //validador 3 numeros
                var v3n = new Validador_tres_numeros();
                v3n.ControladorVal3numero();
                break;
                case 5:
                //rangos numeros
                var rangoN = new RangosNumero();
                rangoN.ControlladorClaseRango();
                break;
                
                default:
                break;
            }
        }
    }
}
