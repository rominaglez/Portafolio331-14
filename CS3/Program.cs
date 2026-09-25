using System ;
//espacio de nombres
namespace CS3
{
    //clase principal
    class Program
    {
        //funcion principal 
        static void Main(string[] args)
        {
            //SESION 6: Operadores 
            //Declaracion e inicializacion de variables
            double a = 1;
            double b = 2;
            double resultado = 0;
            //1. Operadores aritmeticos 
            //a. Suma: +
            resultado = a + b;
            Console.WriteLine($"Suma: {resultado}"); 
            //b. Resta: -
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            //c. Multiplicacion: * 
            resultado = a * b; 
            Console.WriteLine($"Multiplicacion: {resultado}");
            //d. Division: /
            resultado = a / b;
            Console.WriteLine($"Division: {resultado}"); 
            //e. Resto (modulo): % ;es el residuo de la division 
            resultado = a % b;
            Console.WriteLine($"Residuo: {resultado}"); 
            //Incrementos y decrementos 
            //resultado = resultado + 9;
            resultado += 9; 
            resultado -= 5;
            Console.WriteLine($"Resultado: {resultado}"); 

              
            
          
            /*

            2.Operadores comparativos 
            a. Igualdad: ==
            b. Diferencia: !=
            c. Menor que: <
            d. Mayor que: >
            e. Menor o igual que: <=
            f. Mayor o igual que: >=

            */
            //Sesion 7: Operadores comparativos 
            bool m = false; 
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
            m = 5 != 1;
            Console.WriteLine($"Diferencia: {m}");
            m = 5 > 4;
            Console.WriteLine($"Mayor que: {m}"); 
            m = 4 < 5;
            Console.WriteLine($"Menor que: {m}");
            //Menor o igual que 
            //2. Escribir una expresion que de true 
            m = 3 <= 5;
            Console.WriteLine($"Menor o igual que: {m}"); 
            //Mayor o igual que
            //Escribir una expresion que de false
            m = 4 >= 5;
            Console.WriteLine($"Mayor o igual que: {m}");

        //3. Operadores logicos 
        // a. Y (and): &&
        // b. O (or): ||  
        bool e = false; //Entrada 1
        bool f = true; // Entrada 2
        bool d = false; //Resultado 
        d = e && f; //false con true= false porque es AND 
        Console.WriteLine($"Y: {d}");
        d = e || f; //false con true= true porque es OR 
        Console.WriteLine($"O: {d}");


        } //termino de la funcion principal 
         
    } //termino de la clase principal
} //termino de espacio de nombres 
