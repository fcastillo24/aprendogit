while (true)
{
    Console.WriteLine("Por Favor Seleccione que Conversion Desea Realizar:\n");
    Console.WriteLine("1. Numero Entero a Decimal");
    Console.WriteLine("2. Numero Decimal a Flotante");
    Console.WriteLine("3. Numero Flotante a Entero");
    Console.WriteLine("4. Un Caracter en un Numero Entero");
    Console.WriteLine("5. Un Numero Entero en un Caracter");
    Console.WriteLine("6. Salir\n");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcion)
    {
        case 1: // Numero Entero a Decimal
            Ejercicio1();
            break;
        case 2: // Numero Decimal a Flotante
            Ejercicio2();
            break;
        case 3: // Numero Flotante a Entero
            Ejercicio3();
            break;
        case 4: // Un Caracter en un Numero Entero
            Ejercicio4();
            break;
        case 5: // Un Numero Entero en un Caracter
            Ejercicio5();
            break;
        case 6:
            return;
        default: // Opción Invalida
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
            break;
    }
}
static void Ejercicio1()
{
    Console.WriteLine("Por Favor Ingrese un Numero:");
    String Numero = Console.ReadLine();

    if (decimal.TryParse(Numero, out decimal NumeroDecimal))
    {
        Console.WriteLine("\nEl Número Decimal Es: " + NumeroDecimal.ToString("0.00"));
    }
    else
    {
        Console.WriteLine("No Se Introdujo un Dato Valido");
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio2()
{
    Console.WriteLine("Por Favor Introduce un Número Decimal:");
    string Numero = Console.ReadLine();

    if (decimal.TryParse(Numero, out decimal NumeroDecimal))
    {
        float NumeroFlotante = (float)NumeroDecimal;
        Console.WriteLine("\nEl Numero Ingresado en Dato Flotante Es: " + NumeroFlotante);
    }
    else
    {
        Console.WriteLine("El Dato Ingresado es Incorrecto");
    }

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio3()
{
    Console.WriteLine("Por Favor Escribe Un Numero Flotante: ");
    string Numero = Console.ReadLine();

    if (float.TryParse(Numero, out float NumeroFlotante))
    {
        int NumeroEntero = (int)NumeroFlotante;
        Console.WriteLine("\nEl Numero Ingresado en Dato Entero Es: " + NumeroEntero);
    }
    else
    {
        Console.WriteLine("El Dato Ingresado es Incorrecto");
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}

static void Ejercicio4()
{
    Console.WriteLine("Por Favor Ingrese un Caracter: ");
    char caracter = Console.ReadKey().KeyChar;
    Console.ReadLine();

    int NumeroEntero = (int)caracter;

    Console.WriteLine("\nEl Valor del Caracter " + caracter + " Es: " + NumeroEntero);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio5()
{
    Console.WriteLine("Escriba Un Numero:");
    string Numero = Console.ReadLine();

    if (int.TryParse(Numero, out int NumeroEntero))
    {
        // El if verificara si esta en la lista de caracteres que puede imprimir
        if (NumeroEntero >= 0 && NumeroEntero <= 127)
        {
            char Caracter = (char)NumeroEntero;
            Console.WriteLine("\nEl Caracter Correspondiente al Número Indroducido Es: " + Caracter);
        }
        else
        {
            Console.WriteLine("El Numero que Usted Ingreso no puede Imprimir un Caracter");
        }
    }
    else
    {
        Console.WriteLine("Los Datos que Ingreso son Invalidos");
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
