MODULO 3
hile (true)
{
    Console.WriteLine("Por Favor Seleccione que Conversion Desea Realizar:\n");
Console.WriteLine("1. Imprimir una Cadena de Texto en MAYUSCULAS");
Console.WriteLine("2. Imprimir una Cadena de Texto en minisculas");
Console.WriteLine("3. Imprimir una Cadena de Texto Al Reves");
Console.WriteLine("4. Leer una Cadena de Texto y Buscar una palabra en Ella");
Console.WriteLine("5. Contar el Numero de Vocales que Tiene una Cadena ");
Console.WriteLine("6. Salir\n");

int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

switch (opcion)
{
    case 1: // Texto MAYUSCULAS
        Ejercicio1();
        break;
    case 2: // Texto minusculas
        Ejercicio2();
        break;
    case 3: // Texto Al Reves
        Ejercicio3();
        break;
    case 4: // Buscar Palabra en Cadena
        Ejercicio4();
        break;
    case 5: // Vocales en Cadena
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
    Console.WriteLine("Por Favor Introduce Tu Texto");
    string texto = Console.ReadLine();

    string textoMAYUSCULAS = texto.ToUpper();

    Console.WriteLine("\nSu Texto en MAYUSCULAS Es:");
    Console.WriteLine(textoMAYUSCULAS);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio2()
{
    Console.WriteLine("Por Favor Introduce Tu Texto");
    string texto = Console.ReadLine();

    string textominisculas = texto.ToLower();

    Console.WriteLine("\nSu Texto en minisculas Es:");
    Console.WriteLine(textominisculas);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio3()
{
    Console.WriteLine("Por Favor Introduce Tu Texto");
    string texto = Console.ReadLine();

    char[] textoreves = texto.ToCharArray();
    Array.Reverse(textoreves);

    Console.WriteLine("\nSu Texto al Reves Es:");
    Console.WriteLine(textoreves);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}

static void Ejercicio4()
{
    Console.WriteLine("Por Favor Introduce Tu Texto");
    string texto = Console.ReadLine();

    Console.WriteLine("Que Palabra Desea Buscar:");
    string txtbuscar = Console.ReadLine();

    bool palabra = texto.Contains(txtbuscar);

    if (palabra)
    {
        Console.WriteLine("\nLa Palabra " + palabra + "Fue Encontrada en el Texto.");
    }
    else
    {
        Console.WriteLine("\nLa Palabra " + palabra + "No Fue Encontrada en el Texto.");
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio5()
{
    Console.WriteLine("Por Favor Introduce Tu Texto");
    string texto = Console.ReadLine();

    texto = texto.ToLower();

    int contadorA = 0, contadorE = 0, contadorI = 0, contadorO = 0, contadorU = 0;

    foreach (char caracter in texto)
    {
        switch (caracter)
        {
            case 'a':
                contadorA++;
                break;
            case 'e':
                contadorE++;
                break;
            case 'i':
                contadorI++;
                break;
            case 'o':
                contadorO++;
                break;
            case 'u':
                contadorU++;
                break;
        }
    }
    int resultado = contadorA + contadorE + contadorI + contadorO + contadorU;

    Console.WriteLine("\nEl Numero de Vocales que contiene el Texto Es: " + resultado);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
