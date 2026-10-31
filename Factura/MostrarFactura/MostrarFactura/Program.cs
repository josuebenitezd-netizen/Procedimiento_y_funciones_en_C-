using System;

class Program
{
    static decimal calcularToatal(decimal subtotal, bool esfrecuente)
    {
        decimal itibs = 0.18m;
        decimal descuento = 0.10m;

        subtotal = (subtotal * itibs);

        if (esfrecuente == true)
        {
            subtotal = subtotal - descuento;
        }


        return subtotal;
    }

    static void mostrarfactura(string clientes, decimal total)
    {
        Console.WriteLine($"Clientes: {clientes} ");
        Console.WriteLine($"Total a Pagar: {total}");
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Calcular el total y Mostrar la factura");
        Console.WriteLine("=======================================");
        Console.WriteLine();
        Console.Write("Ingresa Subtotal: ");
        decimal subtotal = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("El cliente es Frecuente: ");
        bool frecuencia = bool.Parse(Console.ReadLine());
        decimal total = calcularToatal(subtotal, frecuencia);
        Console.WriteLine();
        Console.Write("Ingresar Cliente: ");
        string cliente = Console.ReadLine();
        Console.WriteLine();
        mostrarfactura(cliente, total);
        Console.ReadKey();

    }

   
}

