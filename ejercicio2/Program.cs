while (true)
{
    Console.WriteLine("Por Favor Seleccione que Conversion Desea Realizar:\n");
    Console.WriteLine("1. Suma de dos Numeros Enteros");
    Console.WriteLine("2. Resta de dos Numeros Decimales");
    Console.WriteLine("3. Multiplicacion de dos Numeros Flotantes");
    Console.WriteLine("4. Division de dos Numeros Enteros");
    Console.WriteLine("5. Modulo de dos Numeros Enteros");
    Console.WriteLine("6. Salir\n");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcion)
    {
        case 1: // Suma
            Ejercicio1();
            break;
        case 2: // Resta
            Ejercicio2();
            break;
        case 3: // Multiplicacion
            Ejercicio3();
            break;
        case 4: // Division
            Ejercicio4();
            break;
        case 5: // Modulo
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
    Console.WriteLine("Este Programa hara una Suma de 2 Numeros Enteros\n");

    Console.WriteLine("Por Favor Ingrese un Numero Entero:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Ingrese un Segundo Numero:");
    int num2 = int.Parse(Console.ReadLine());

    int Resultado = num1 + num2;

    Console.WriteLine("La Suma de los Numeros Enteros Es: " + Resultado);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio2()
{
    Console.WriteLine("Este Programa hara una Resta de 2 Numeros Decimales\n");

    Console.WriteLine("Por Favor Ingrese un Numero Decimal:");
    Decimal num1 = Decimal.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Ingrese un Segundo Decimal:");
    Decimal num2 = Decimal.Parse(Console.ReadLine());

    Decimal Resultado = num1 - num2;

    Console.WriteLine("La Resta de los Numeros Decimales Es: " + Resultado);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio3()
{
    Console.WriteLine("Este Programa hara una multiplicacion de 2 Numeros Flotantes\n");

    Console.WriteLine("Por Favor Ingrese un Numero Flotante:");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Ingrese un Segundo Flotante:");
    float num2 = float.Parse(Console.ReadLine());

    float Resultado = num1 * num2;

    Console.WriteLine("La Multiplicación de los Numeros Flotantes Es: " + Resultado);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio4()
{
    Console.WriteLine("Este Programa hara una Division de 2 Numeros Enteros\n");

    Console.WriteLine("Por Favor Ingrese un Numero Entero:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Ingrese un Segundo Numero:");
    int num2 = int.Parse(Console.ReadLine());

    int Resultado = num1 / num2;

    Console.WriteLine("La Division de los Numeros Enteros Es: " + Resultado);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio5()
{
    Console.WriteLine("Este Programa Calculara el Modulo de 2 Numeros Enteros\n");

    Console.WriteLine("Por Favor Ingrese un Numero Entero:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Ingrese un Segundo Numero:");
    int num2 = int.Parse(Console.ReadLine());

    int Resultado = num1 % num2;

    Console.WriteLine("El Modulo de los Numeros Enteros Es: " + Resultado);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
