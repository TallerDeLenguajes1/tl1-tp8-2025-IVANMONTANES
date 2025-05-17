using System.Runtime.Intrinsics.Arm;
using EspacioTareas;
/*
// generamos el numero random para la cantidad de tareas //
Random numeroRandom = new Random();
int n = numeroRandom.Next(1,25);
Console.WriteLine(n);
// creamos la lista //
List<Tarea> tareasPendientes = new List<Tarea>();
// cargamos las tareas //
Console.WriteLine($"Tareas que se cargaran : {n} tareas");
for(int i = 0; i < n; i++){
    // id de la tarea //
    int tareaId = i + 1;

    Console.WriteLine($"==================== TAREA {i + 1} ====================");
    // cargamos la descripcion //
    bool descripcionCargada = false;
    string descripcion = string.Empty;
    do{
        Console.WriteLine("ingrese la descripcion de la tarea:");
        descripcion = Console.ReadLine();
        if(string.IsNullOrEmpty(descripcion)){
            Console.WriteLine("Ingrese una descripcion valida");
        }else{
            descripcionCargada = true;
        }
    }while(!descripcionCargada);

    // cargamos la duracion //
    bool duracionCargada = false;
    int duracion = default;
    do{
        Console.WriteLine("ingrese la duracion de la tarea [10-100]");
        duracionCargada = int.TryParse(Console.ReadLine(), out duracion);
        if(!duracionCargada){
            Console.WriteLine("No se ingreso un numero");
        }else if(!(duracion >= 10 && duracion <= 100)){
            Console.WriteLine("Ingrese una duracion valida");
            duracionCargada = false;
        }
    }while(!duracionCargada);
    
    // creamos la tarea //
    Tarea tareaCargada = new Tarea(tareaId,descripcion,duracion);

    // añadimos la tarea a la lista //
    tareasPendientes.Add(tareaCargada);
}
*/

// interfaz //
bool seguir = true;
while(seguir){
    Console.WriteLine("1: MARCAR TAREA COMO REALIZADA");
    Console.WriteLine("2: BUSCAR TAREA PENDIENTE POR DESCRIPCION");
    Console.WriteLine("3: MOSTRAR TODAS LAS TAREAS");
    Console.WriteLine("eliga una opcion:");
    int opcionElegida = default;
    bool conversionExitosa = int.TryParse(Console.ReadLine(), out opcionElegida);
    if(conversionExitosa && opcionElegida >= 1 && opcionElegida <= 3){
        Console.WriteLine("bien");
    }else{
        if(!conversionExitosa){
            Console.WriteLine("no se cargo un numero");
        }else{
            Console.WriteLine("opcion no valida");
        }
    }
    Console.WriteLine("Presione 1 si desea salir, otro si no");
    string salir = Console.ReadLine();
    if(salir == "1"){
        seguir = false;
    }
}
Console.WriteLine("saliendo...");


/*
// mostramos las tareas pendientes //
Console.WriteLine("============================= TAREAS PENDIENTES ============================");
for(int i = 0; i < tareasPendientes.Count; i++){
    tareasPendientes[i].MostrarTarea();
}
Console.WriteLine("ingrese el id de la tarea:");
int tareaElegida = default;
*/