﻿using System.Runtime.Intrinsics.Arm;
using EspacioTareas;

// generamos el numero random para la cantidad de tareas //
Random numeroRandom = new Random();
int n = numeroRandom.Next(1,25);
Console.WriteLine(n);
// creamos las lista //
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
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


// interfaz //
bool seguir = true;
Console.WriteLine("======================== INTERFAZ ========================");
while(seguir){
    Console.WriteLine("1: MARCAR TAREA COMO REALIZADA");
    Console.WriteLine("2: BUSCAR TAREA PENDIENTE POR DESCRIPCION");
    Console.WriteLine("3: MOSTRAR TODAS LAS TAREAS");
    Console.WriteLine("eliga una opcion:");
    int opcionElegida = default;
    bool conversionExitosa = int.TryParse(Console.ReadLine(), out opcionElegida);
    if(conversionExitosa && opcionElegida >= 1 && opcionElegida <= 3){
        // usamos una declaracion switch para controlar los distintos casos //
        switch (opcionElegida){
            case 1: 
                // mostramos la lista de tareas pendientes //
                Console.WriteLine("============================= TAREAS PENDIENTES ============================");
                if(tareasPendientes.Count != 1){
                    for(int i = 0; i < tareasPendientes.Count; i++){
                    tareasPendientes[i].MostrarTarea();
                    }
                    bool idSeleccionadoValido = false;
                    do{
                        Console.WriteLine("ingrese el id de la tarea:");
                        int tareaElegidaId = default;
                        string tareaElegidaIdString = Console.ReadLine();
                        idSeleccionadoValido = int.TryParse(tareaElegidaIdString, out tareaElegidaId);
                        // si se carga un numero recorremos la lista buscando el id //
                        if(idSeleccionadoValido){
                            // variable para indicar si se encuentra la tarea con ese id //
                            bool tareaEncontrada = false;
                            for(int i = 0; i < tareasPendientes.Count; i++){
                                if(tareaElegidaId == tareasPendientes[i].TareaId){
                                    tareaEncontrada = true;
                                    // agregamos la tarea a la lista de realizadas //
                                    tareasRealizadas.Add(tareasPendientes[i]);
                                    // eliminamos la tarea de la lista de pendientes //
                                    tareasPendientes.RemoveAt(i);
                                }
                            }
                            // avisamos en caso de no encontrarse la tarea con ese id //
                            if(!tareaEncontrada){
                                Console.WriteLine("no se encontro una tarea con ese id");
                            }else{
                                Console.WriteLine("Se movio la tarea a realizadas");
                            }
                        }else{
                            Console.WriteLine("no se cargo un numero");
                        }
                    }while(!idSeleccionadoValido);
                }else{
                    Console.WriteLine("**** LA LISTA NO CONTIENE TAREAS ****");
                }
                
                
            break;

            case 2:
                // cargamos la cadena //
                bool cadenaCargada = false;
                string cadenaACargar = string.Empty;
                while(!cadenaCargada){
                    Console.WriteLine("ingrese una cadena:");
                    cadenaACargar = Console.ReadLine();
                    if(string.IsNullOrEmpty(cadenaACargar)){
                        Console.WriteLine("ingrese una cadena no vacia");
                    }else{
                        cadenaCargada = true;
                    }
                }
                // variable para indicar si se encontro alguna coincidencia //
                bool seEncontroCoincidencia = false;
                // recorremos la lista buscando la coicidencia //
                for(int i = 0; i < tareasPendientes.Count; i++){
                    if(tareasPendientes[i].Descripcion.Contains(cadenaACargar)){
                        // mostramos la tarea //
                        tareasPendientes[i].MostrarTarea();
                        seEncontroCoincidencia = true;
                    }
                }
                if(!seEncontroCoincidencia){
                    Console.WriteLine("no se encontro niguna tarea con ese descripcion");
                }
            break;

            case 3:
                // mostramos las tareas pendientes //
                Console.WriteLine("============================= TAREAS PENDIENTES ============================");
                if(tareasPendientes.Count != 0){
                    for(int i = 0; i < tareasPendientes.Count; i++){
                    tareasPendientes[i].MostrarTarea();
                    }
                }else{
                    Console.WriteLine("**** LA LISTA NO CONTIENE TAREAS ****");
                }
                

                // mostramos las tareas realizadas //
                Console.WriteLine("============================= TAREAS REALIZADAS ============================");
                if(tareasRealizadas.Count != 0){
                    for(int i = 0; i < tareasRealizadas.Count; i++){
                    tareasRealizadas[i].MostrarTarea();
                    }
                }else{
                    Console.WriteLine("**** LA LISTA NO CONTIENE TAREAS ****");
                }
            break;
    }
        }else{
            if(!conversionExitosa){
                Console.WriteLine("no se cargo un numero");
            }else{
                Console.WriteLine("opcion no valida");
            }
        }
        Console.WriteLine("================ ¿SEGUIR? =================");
        Console.WriteLine("Presione 1 si desea salir, otro si no");
        string salir = Console.ReadLine();
        if(salir == "1"){
            seguir = false;
        }
}
Console.WriteLine("saliendo...");