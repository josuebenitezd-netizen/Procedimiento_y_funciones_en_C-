using System;


class Program
{




    static string GenerarUsuario(string Nombre, string Apellido)
    {


        string usuario = Nombre.ToLower();

        string p = Apellido.ToLower();

        return usuario;
    }
    static bool validar(string clave, string Usuario)
    {
        string Contraseña = clave;

        return Contraseña.Length >= 8 && !Contraseña.ToLower().Contains(Usuario.ToLower());

    }
    static void mostrarCuenta(string cuenta, bool validar)
    {
        Console.WriteLine($"Usuario: {cuenta}");
        Console.WriteLine($"Clave Válida: {validar}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Crear un Usuario y Validar la clave");
        Console.WriteLine("===================================");
        Console.WriteLine("");

        Console.Write("Ingresar Usuario: ");

        string usuario = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Ingresar Apellido: ");

        string Apellido = Console.ReadLine();

        string Crear = GenerarUsuario(usuario, Apellido);

        Console.WriteLine();

        Console.Write("Ingresar Clave: ");

        string Clave = Console.ReadLine();

        Console.WriteLine();

        bool cValidar = validar(Clave, Crear);

        mostrarCuenta(Crear, cValidar);

        Console.ReadKey();
    }




}
