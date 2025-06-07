//Ejercicio 3 Calculadora 3

Console.WriteLine("Ingrese un numero: ");
float numero2 = float.Parse(Console.ReadLine());
Console.WriteLine("\n\tEl valor absoluto del numero es: " + float.Abs(numero2));
Console.WriteLine("\n\tEl cuadrado del numero es: " + float.Pow(numero2, 2));
if (numero2 > 0)
{
    Console.WriteLine("\n\tLa raiz cuadrada del numero es: " + float.Sqrt(numero2));
}
else
{
    Console.WriteLine("\n\t" + float.Sqrt(numero2) + " no posee raiz cuadrada");
}

if (float.IsEvenInteger(float.Sin(numero2)))
{
    Console.WriteLine("\n\tEl seno del numero es: " + float.Sin(numero2));
}
else
{
    Console.WriteLine("\n\t" + numero2 + " no posee seno");
}

if (float.IsEvenInteger(float.Cos(numero2)))
{
    Console.WriteLine("\n\tEl coseno del numero es: " + float.Cos(numero2));
}
else
{
    Console.WriteLine("\n\t" + numero2 + " no posee coseno");
}
Console.WriteLine("\n\tla parte entera del numero " + numero2 + " es " + (int)numero2);

List<float> lista = [];

Console.WriteLine("Ingrese un numero: ");

lista.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("Ingrese otro numero: ");

lista.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("El numero maximo es: " + lista.Max());

Console.WriteLine("El numero minimo es: " + lista.Min());