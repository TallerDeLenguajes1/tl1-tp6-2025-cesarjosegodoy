// Ejercicio 2 CalculadoraV1

Console.WriteLine("\n\t\tCalculadora");
string opcion = "";

while (opcion != "no")
{
    Console.WriteLine("\n\t1. Sumar\n\t2. Restar\n\t3. Multiplicar\n\t4. Dividir\n\tIngresa un operacion a realizar:");

    string operacion = Console.ReadLine();
    Console.WriteLine("Ingrese el primer numero: ");
    float n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    float n2 = int.Parse(Console.ReadLine());
    switch (operacion)
    {
        case "1":
            Console.WriteLine("\n\tLa suma de " + n1 + " con " + n2 + "  es: " + (n1 + n2).ToString());
            break;
        case "2":
            Console.WriteLine("\n\tLa resta de " + n1 + " con " + n2 + "  es: " + (n1 - n2).ToString());
            break;
        case "3":
            Console.WriteLine("\n\tLa multiplicacion de " + n1 + " con " + n2 + "  es: " + (n1 * n2).ToString());
            break;
        case "4":
            Console.WriteLine("\n\tLa division de " + n1 + " con " + n2 + "  es: " + (n1 / n2).ToString());
            break;
        default:
            Console.WriteLine("\n\tOPcion invalida..");
            break;
    }
    Console.WriteLine("\n\tDesea realizar otro Calculo (si/no):");
    opcion = Console.ReadLine();
}