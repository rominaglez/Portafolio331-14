using System;
using System.Data.SqlTypes;
//Espacio de nombres 
namespace CS2
{
    //Clase principal
    class Program
    {
        //Funcion principal
        static void Main(string[] args) 
        {
           // Sesion 5: Tipos de datos 
           //Sintaxis para declarar variables 
            // tipo_de_dato identificador_variable;
            // // 1. Entero 
            int a; //int es tipo de dato y a el nombre de la variable 
           // 2. Cadena de texto  
           string s; 
           // 3.1 Flotante (Precision sencilla)
           float f; 
           // 3.2 Flotante (Precision doble)
           double d; 
            // 4. Booleano (logico
            bool b; 
            // Inicializaciones 
            a = 5;
            s = "Exactas"; 
            f = 8.5F; //para flotante se pone F para que no marque error
            d = 9.5D; //si es tipo doble no necesita poner letra 
            b = true; //true y false son con minusculas siempre
            //Palabra reservada: Identificador especial predefinido para el compilador 
            //Interpolacion: combinacion de datos dentro de una cadena.
            //Impresiones 
            Console.WriteLine($"Entero: {a}"); //$ ayuda a incluir datos combinadamente, para que tenga formato 
            Console.WriteLine($"Flotante (precision sencilla): {f}");
            Console.WriteLine($"Flotante(precision doble):) {d}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"Booleano: {b}");
    

        } //Termino de la funcion principal
    } //Termino de la clase principal
} //Termino del espacio de nombres 