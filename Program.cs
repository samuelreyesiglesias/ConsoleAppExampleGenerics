using System;
using System.Collections.Generic;

namespace ConsoleAppExampleGenerics
{
    public interface INumeros
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
    }
    public class Numeros : INumeros
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
    }
    public class OperacionesMatematicas<T> where T : INumeros
    {
        
        public static T Numeros { get; set; }
        public static void SetNumeros(T Numeros_)
        {
            Numeros = Numeros_;
        }
        public static int Sumar()
        {
            return Numeros.N1 + Numeros.N2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Usando generics class.
            //first we instance the class
            Numeros N = new Numeros();
            N.N1 = 1;
            N.N2 = 2;
           OperacionesMatematicas<Numeros>.SetNumeros(N);
            int ResultadoSumar = OperacionesMatematicas<Numeros>.Sumar() ;
            Console.WriteLine($"El resultado de la suma es:{ResultadoSumar}"); 
            
            //Primer Ejemplo de meotodo utilizando Generic.
            MostrarMensaje<string>("Mi mensaje a mostrar");

            //Segundo ejemplo de llaamda a metodo utilizando generic. en este caso no es necesario utilizar 
            //o especificar el tipo de dat.. se realiza una asignacion implicita del tipo de dato enviado en los parametros del metodo al invocarlo.
            int Parametro1=100;
            int Parametro2=333;
            int ValorSuma = Sumatoria(Parametro1, Parametro2);
            Console.WriteLine("El valor de la sumatoria de un metodo utilizando generics es:" + ValorSuma);
            
        }

        public static void MostrarMensaje<T>(T MiMensajeAMostrar){
            if (MiMensajeAMostrar.GetType() == typeof(string)) { 
                Console.WriteLine("Mi mensaje a Mostrar es:"+MiMensajeAMostrar);
            }else{
                Console.WriteLine("Tipo de dato no soportado.-");
            }
        }

        public static int Sumatoria<Type>(Type Numero1,Type Numero2)
        {
            if(Numero1.GetType()==typeof(int) && Numero2.GetType() == typeof(int))
            {
                try
                {
                    int n1 = Convert.ToInt32(Numero1);
                    int n2 = Convert.ToInt32(Numero2);
                    return n1 + n2;
                }catch(Exception E)
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

    }

}
