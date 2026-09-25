using System;
namespace SE1
{
    class Program
    {
        static void Main(string[]args); 
        {
            // 1. Proyecto en C#
            // 2. Sintaxis para declarar variables 
            // tipo_de_dato identificador_variable;
            bool a;
            int numero;
            // 3. Que es interpolacion? 2 ejemplos 
            //Combinacion de datos dentro de una cadena 
            a = true;
            numero = 10;
            Console.WriteLine($"Booleano: {a}"); 
            Console.WriteLine($"Numero: {numero}");
            //4. Incrementos y decrementos 
            int m = 0;
            int n = -1;
            m += 1;
            n -= 3;
            m -= 5; 
            n += 9;
            // 5. Operador resto 
            int residuo = 40 % 16; 
            Console.WriteLine($"Residuo: {}"); 
            // 6. OPERADORES ARITMETICOS
            double operacion = 0;
            operacion = ( (30 + 8 - 2) / 2 ) * -1;
            Console.WriteLine($"Operacion: {operacion}"); 
        }
    }
}