using System;
// Espacio de nombres
namespace CS4._1
{
    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Bloque de instrucciones
            // Sesión 8: Estructuras selectivas: dobles y múltiples
            // 1. Estructura selectiva doble (instrucción if-else)
            // Declaración e inicialziación
            bool foco = false; // A la variable "foco", se le asigna, inicialmente, false.
            if (foco == true) // Si el valor de la variable "foco" es true, entonces...
            {
                Console.WriteLine("El foco está encendido."); // ...impresión del estado del foco: encendido.
            }
            else // En caso contrario, entoces...
            {
                Console.WriteLine("El foco está apagado."); // ...impresión del estado del foco: apagado.
            }
            // 2. Estructura selectiva múltiple (instrucción if-else if-else)
            // Declaración e inicialización
            int salón = 333; // A la variable "salón, se le asigna, inicialmente, 331.
            if (salón == 331) // Si el valor de la variable "salón" es 331, entonces...
            {
                Console.WriteLine("Exactas"); // ...impresión de especialidad: "Exactas".
            }
            else if (salón == 332 || salón == 333) // Si no es igual a 331, pero sí a 332, entonces...
            {
                Console.WriteLine("Administrativas"); // ...impresión de especialidad: "Administrativas".
            }
            
            else if (salón == 334) // Si no es igual a 331, 332 o 333, pero sí a 334, entonces...
            {
                Console.WriteLine("Humanidades"); // ...impresión de especialidad: "Humanidades".
            }
            else if (salón == 335) // Si no es igual a 331, 332, 333, 333 o 334, pero sí a 335, entonces...
            {
                Console.WriteLine("Biológicas"); // ...impresión de especialidad: "Biológicas".
            }
            else // En cualquier otro caso, entocnes...
            {
                Console.WriteLine("¡Salón no registrado!"); // ...impresión: "¡Salón no registrado!".
            }
        } // Término de la función principal
    } // Término de la clase principal
} // Término espacio de nombres