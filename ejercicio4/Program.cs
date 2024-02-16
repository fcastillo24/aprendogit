while (true)
{
    Console.WriteLine("Por Favor Seleccione que Conversion Desea Realizar:\n");
    Console.WriteLine("1. Calcular el área de un Triangulo");
    Console.WriteLine("2. Calcular el Volumen de una Esfera");
    Console.WriteLine("3. Calcular la Distancia de Dos Puntos");
    Console.WriteLine("4. Convertir Grados Celsius en Fahrenheit");
    Console.WriteLine("5. Convertir Grados Fahrenheit en Celsius");
    Console.WriteLine("6. Salir\n");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcion)
    {
        case 1: // Triangulo
            Ejercicio1();
            break;
        case 2: // Esfera
            Ejercicio2();
            break;
        case 3: // Puntos
            Ejercicio3();
            break;
        case 4: // C a F
            Ejercicio4();
            break;
        case 5: // F a C
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
    Console.WriteLine("Por favor ingresa la base el Triangulo");
    double tbase = double.Parse(Console.ReadLine());

    Console.WriteLine("Por favor ingresa la altura el Triangulo");
    double altura = double.Parse(Console.ReadLine());

    double area = 0.5 * tbase * altura;

    Console.WriteLine("\nEl Area del Tringulo Es: " + area);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio2()
{
    Console.WriteLine("Por favor el Radio de la Esfera");
    double radio = double.Parse(Console.ReadLine());

    double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);

    Console.WriteLine("\nEl volumen de la esfera es: " + volumen);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio3()
{
    Console.WriteLine("Por Favor Ingrese la Ubicacion del Punto A");
    Console.Write("Ingrese la ubicacion en el eje X: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la ubicacion en el eje Y: ");
    double y1 = double.Parse(Console.ReadLine());

    Console.WriteLine("\nPor Favor Ingrese la Ubicacion del Punto B");
    Console.Write("Ingrese la ubicacion en el eje X: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese la ubicacion en el eje Y: ");
    double y2 = double.Parse(Console.ReadLine());

    double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine("\nLa distancia entre el Punto A y Punto B Es: " + distancia);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio4()
{
    Console.WriteLine("Por Favor ingrese la temperatura en Grados Fahrenheit");
    double grados = double.Parse(Console.ReadLine());

    double celsius = ((grados - 32) * 5) / 9;

    Console.WriteLine("La Temperatura en Grados Celsius Es: " + celsius);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
static void Ejercicio5()
{
    Console.WriteLine("Por Favor ingrese la temperatura en Grados Celsius");
    double grados = double.Parse(Console.ReadLine());

    double fahrenheit = (grados * 9 / 5) + 32;

    Console.WriteLine("\nLa Temperatura en Grados Fahrenheit Es: " + fahrenheit);

    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}
