using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Colas");
            Queue<String> Cola = new Queue<String>();
            _ = new Queue<int>();
            // Agregar elementos
            Cola.Enqueue("0 - N001, JOSE, PEREZ");
            Cola.Enqueue("1 - N002, JUAN, GONZALES");
            Cola.Enqueue("2 - N003, PEDRO, RAMIREZ");
            Cola.Enqueue("3 - N004, CARLOS, LOPEZ");
            Cola.Enqueue("4 - N005, LUIS, YARLEQUE");

            //Recorrer elementos 
            foreach (var ele in Cola)
            {
                Console.WriteLine(ele);
            }
Console.WriteLine("");

//Eliminar elemento del inicio:
Console.WriteLine("Eliminando el primer elemento");
Cola.Dequeue();
Console.WriteLine("");

//Recorrer elementos 
foreach (var ele in Cola)
{
    Console.WriteLine(ele);
}
Console.WriteLine("");


//Contar total de elementos:
Console.WriteLine("Total de elementos en la cola: " + Cola.Count);
Console.WriteLine("");

Console.WriteLine("Primer elemento de la cola... " + Cola.Peek());
Console.WriteLine("");

Console.Read();

        }
    }
}
