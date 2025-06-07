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

// Ejercicio 4

Console.WriteLine("Ingresa una oracion: ");
string oracion = Console.ReadLine();
Console.WriteLine("La longuitud de la oracion es: " + oracion.Length);
Console.WriteLine("\nIngresa otra oracion: ");
string oracion1 = Console.ReadLine();
Console.WriteLine("\nLa oracion concatenada es:" + oracion + oracion1);
Console.WriteLine("\nLa posicion de 'a' en la oracion es: " + (oracion.IndexOf('a') + 1));
Console.WriteLine("\nArmo otra oracion sin la primera letra  : " + oracion[1..]);

Console.WriteLine($"Los caracteres de {oracion} son: ");
foreach (char c in oracion)
{
    Console.WriteLine(c);
}
Console.WriteLine($"\nLa oracion en mayusculas es '{oracion.ToUpper()}' y en minusculas es '{oracion.ToLower()}'");
Console.WriteLine($"\nIngresa una cadena con la letra 'k' para separarla:");
string cadena = Console.ReadLine();
string[] partes = cadena.Split('k');
Console.WriteLine("\nPartes de la cadena separadas por 'k':");
foreach (string s in partes)
{
    Console.WriteLine(@$">{s}");
}
Console.WriteLine($"\nIngresa una operacion a realizar: ");
int.TryParse(Console.ReadLine(), out int resultado);
Console.WriteLine($"\nEl resultado de la operacion es {resultado}");