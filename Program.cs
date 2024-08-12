using System;  // Incluye el espacio de nombres System, que contiene clases y tipos básicos

class Program  // Define una clase llamada Program
{
    static void Main()  // Define el método principal de la aplicación, que es el punto de entrada
    {
        // Mostrar un título en la consola
        Console.WriteLine("Bienvenido a mi primera aplicación C#!");  // Imprime en la consola 
        //"Bienvenido a mi primera aplicación C#!"
        // Solicitar al usuario su nombre
        Console.Write("Por favor, ingrese su nombre: ");  // Imprime "Por favor, ingrese su nombre:" 
        //sin un salto de línea al final
        
        // Leer el nombre ingresado por el usuario
        string nombre = Console.ReadLine();  // Lee la línea de texto ingresada 
        //por el usuario y la almacena en la variable 'nombre'
        
        // Mostrar un saludo personalizado
        Console.WriteLine($"Hola, {nombre}! Gracias por usar la aplicación.");  // Imprime un saludo 
        //personalizado con el nombre del usuario
        
        // Esperar a que el usuario presione una tecla para cerrar la aplicación
        Console.WriteLine("Presione cualquier tecla para salir.");  // Imprime "Presione cualquier 
        //tecla para salir." para que el usuario sepa cómo salir
        
    }
}
class Program  // Define una clase llamada Program
{
    {
        Console.ReadKey();  // Espera a que el usuario presione una 
        //tecla antes de finalizar la aplicación   
        // Mostrar un título en la consola
        Console.WriteLine("Bienvenido a mi primera aplicación C#!");  // Imprime en la consola 
        //"Bienvenido a mi primera aplicación C#!"
        // Solicitar al usuario su nombre
        Console.Write("Por favor, ingrese su nombre: ");  // Imprime "Por favor, ingrese su nombre:" 
        //sin un salto de línea al final
        
        // Leer el nombre ingresado por el usuario
        string nombre = Console.ReadLine();  // Lee la línea de texto ingresada 
        //por el usuario y la almacena en la variable 'nombre'
        
        // Mostrar un saludo personalizado
        Console.WriteLine($"Hola, {nombre}! Gracias por usar la aplicación.");  // Imprime un saludo 
        //personalizado con el nombre del usuario
    }
}