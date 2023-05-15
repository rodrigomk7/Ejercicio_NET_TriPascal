﻿using System;

namespace Curso_de_net_core
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int[1];
            //Mostramos un mensaje y capturalos el dato ingresado desde la consola
            Console.WriteLine("Ingrese el numeros de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());
            /* Declaramos el primer ciclo for que va recorrer dependiendo
            el datos ingresado que está almacenado en la variable pisos */
            for (int i = 1; i <= pisos; i++)
            {
                /*Colocamos un arreglo y colocamos la variable i del ciclo for
               que será el tamaño que tendrá el arreglo cada vez que el ciclo for
               se ejecute */
                int[] pascal = new int[i];
                //Ciclo for que se decrementa para formar el triangulo
                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }
                //Ciclo for que genera la sumas de las cifras
                for (int k = 0; k < i; k++)
                {
                    //Condición que evaluá la variable del ciclo for
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        //Sumamos los numero que están en cada poción 
                        //del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
