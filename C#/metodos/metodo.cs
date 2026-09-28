using System.Reflection;

int opcion;
bool dato;
do{
Console.WriteLine("Menú figuras geométricas");
Console.WriteLine("1. Área de un triángulo");
Console.WriteLine("2. Área de un rectángulo");
Console.WriteLine("3. Área de un cuadrado");
Console.WriteLine("4. Área de un círculo");
Console.WriteLine("5. Salir del menú");
Console.WriteLine("Ingrese una opcion: ");
dato = int.TryParse(Console.ReadLine()?.Trim() ?? "", out opcion);
if (dato)
{
    switch (opcion)
    {
        case 1:
        AreaTriangulo();
        break;

        case 2:
        AreaRectangulo();
        break;

        case 3:
        Console.WriteLine("Ingrese el lado del cuadrado: ");
        bool ladoC = float.TryParse(Console.ReadLine()?.Trim()?? "", out float lado);
        if (ladoC)
            {
                AreaCuadrado(lado);
        }
         else
            {
                Console.WriteLine("Solo puedes ingresar numeros");
            }
            break;
        
        case 4:
        float radio;
        Console.WriteLine("Ingrese el radio del círculo: ");
        bool radioC = float.TryParse(Console.ReadLine()?.Trim()?? "", out radio);
                if (!radioC)
                {
                    Console.WriteLine("Solo puedes ingresar numeros");
                }
        AreaCirculo(3.1416, radio);


    }

}
}while(opcion != 5);


static void AreaTriangulo()
{
    float baseT;
    Console.WriteLine("Ingresa la base del triangulo:");
    bool baseTriangulo = float.TryParse(Console.ReadLine()?.Trim()?? "", out baseT);
    if (!baseTriangulo)
    {
        Console.WriteLine("Solo puedes ingresar numeros");
    }
    float alturaT;
    Console.WriteLine("Ingrese la altura del triangulo: ");
    bool alturaTriangulo = float.TryParse(Console.ReadLine()?.Trim()?? "", out alturaT);
    if (!alturaTriangulo)
    {
        Console.WriteLine("Solo puedes ingresar numeros");
    }
    float areaTriangulo;
    areaTriangulo = (baseT*alturaT)/2;
    Console.WriteLine($"El área del triangulo es: {areaTriangulo} cm cuadrados");
}

static float AreaRectangulo()
{
    float baseR;
    Console.WriteLine("Ingrese la base del rectangulo: ");
    bool baseRectangulo = float.TryParse(Console.ReadLine()?.Trim()?? "", out baseR);
    if (!baseRectangulo)
    {
        Console.WriteLine("Solo puedes ingresar numeros");
    }
    float alturaR;
    Console.WriteLine("Ingrese la altura del rectangulo: ");
    bool alturaRectangulo = float.TryParse(Console.ReadLine()?.Trim()?? "", out alturaR);
    if (!alturaRectangulo)
    {
        Console.WriteLine("Solo puedes ingresar numeros");
    }
    float areaR = baseR * alturaR;
    return areaR;
}

static void AreaCuadrado(float l)
{
    float areaC = l*l;
    Console.WriteLine($"El área del cuadrado es: {areaC} cm cuadrados");
}


static float AreaCirculo(float pi,  float r)
{
    
}