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
            "4-VALIDADOR DE 3 NUMEROS\n"+
            "5-VALIDADOR RANGO\n"+
            "6-LETRA LOWER UPPER\n"+
            "7-LETRA A \n"+
            "8-TABLAS 15 \n"
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
                //creando obj de clase
                var c_exam = new ValidadorExamen();
                c_exam.ControladorExamen();
                break;
                case 3:
                //creando obj de clase
                var c_Kg = new Kilos_a_Libras();
                c_Kg.ControladorConversorKg();
                break;
                case 4:
                //creando obj de clase
                var v3n = new Validador_tres_numeros();
                v3n.ControladorVal3numero();
                break;
                case 5:
                //creando obj de clase
                var rangoN = new RangosNumero();
                rangoN.ControlladorClaseRango();
                break;
                case 6:
                //Creando obj de clase
                var letra = new LetraLoweUpper();
                letra.controllerLoweUpper();
                break;
                case 7:
                //Creando obj de clase
                var Am = new Amayuscula();
                Am.ControladorLetra();
                break;
                case 8:
                //crando obj de la clase
                var T15 = new Tablas15();
                T15.ControladorTablas();
                break;
                default:WriteLine("La opcion ingresada no existe");
                break;
            }
        }
    }
}
