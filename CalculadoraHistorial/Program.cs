using EspacioCalculadora;
// instaciamos la calculadora //
Calculadora calculadora = new Calculadora();
// interfaz de usuario //
bool seguir;
do
{
    Console.WriteLine("=================== OPERACIONES ===================");
    Console.WriteLine("1: Sumar");
    Console.WriteLine("2: Restar");
    Console.WriteLine("3: Multiplicar");
    Console.WriteLine("4: Dividir");
    Console.WriteLine("5: Mostrar Historial");
    Console.WriteLine("6: Limpiar");
    Console.WriteLine("eliga una opcion:");
    int operacionElegida = default;
    int.TryParse(Console.ReadLine(), out operacionElegida);
    Console.WriteLine("========== OPERACION ==========");
    if (operacionElegida >= 1 && operacionElegida <= 4)
    {
        // leemos el numero con el que vamos a operar //
        double termino = default;
        bool terminoCargado = false;
        while (!terminoCargado)
        {
            Console.WriteLine("ingrese un numero:");
            terminoCargado = double.TryParse(Console.ReadLine(), out termino);
            if (!terminoCargado)
            {
                Console.WriteLine("no se ingreso un numero");
            }
        }

        // llamamos a los distintos metodos //

        switch (operacionElegida)
        {
            case 1: calculadora.Sumar(termino); break;
            case 2: calculadora.Restar(termino); break;
            case 3: calculadora.Multiplicar(termino); break;
            case 4: calculadora.Dividir(termino); break;
        }
    }
    else if (operacionElegida == 5)
    {
        calculadora.MostrarHistorial();
    }
    else if (operacionElegida == 6){
        calculadora.Limpiar();
    }
    else
    {
        Console.WriteLine("Opcion no disponible");
    }
    // mostramos el valor // 
    Console.WriteLine($"Valor Actual: {calculadora.Resultado}");
    Console.WriteLine("===============================");
    // preguntamos al usuario si desea seguir //
    Console.WriteLine("1 PARA SEGUIR");
    int seguirInt = default;
    int.TryParse(Console.ReadLine(), out seguirInt);
    if (seguirInt == 1)
    {
        seguir = true;
    }
    else
    {
        seguir = false;
    }
} while (seguir);
Console.WriteLine("Saliendo...");