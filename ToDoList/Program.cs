using System;
using clases;

namespace todolist
{

    class ToDoList
    {
        static void Main(string[] args)
        {

            List<Tarea> listaDeTareas = new List<Tarea>{};

            Console.WriteLine(
                """

                Presione el numero de la funcion a realizar
                1) Crear nueva tarea
                2) Marcar tarea como completada
                3) Mostrar todas las tareas
                4) Eliminar una tarea
                5) Salir del sistema

                """
                );
                
            string decision = Console.ReadLine();

            while (decision != "5")
            {
                switch (decision)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre de la tarea:");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripción de la tarea:");
                        string Descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese la fecha límite (opcional):");
                        string FechaLimite = Console.ReadLine();

                        if (Nombre != null && Descripcion != null)
                        {
                            Tarea nuevaTarea = new Tarea(Nombre, Descripcion, FechaLimite);
                            listaDeTareas.Add(nuevaTarea);
                            Console.WriteLine("Tarea creada con exito");
                        }
                        else
                        {
                            Console.WriteLine("Hubo un error al crear la tarea vuelva a intentarlo");
                        }
                        break;

                    case "2":

                        Console.WriteLine("Las tareas sin completar son:");

                        foreach (var tarea in listaDeTareas)
                        {
                            if (tarea.Completada == false)
                                if (tarea.FechaLimite == null)
                                {
                                    Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} y su descripcion es {tarea.Descripcion}");
                                }
                                else
                                {
                                    Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} Su descripcion es {tarea.Descripcion} y su fecha limite es para {tarea.FechaLimite}");
                                }
                        }

                        Console.WriteLine("Ingrese el numero de la tarea a marcar como completada:");
                        int idTarea = int.Parse(Console.ReadLine());

                        Tarea tareaACompletar = listaDeTareas.Find(tarea => tarea.id == idTarea);

                        if (tareaACompletar != null)
                        {
                            tareaACompletar.DeclararCompletada();
                            Console.WriteLine("La tarea ha sido marcada como completada.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ninguna tarea con ese numero.");
                        }

                        break;

                    case "3":

                        Console.WriteLine("Tus tareas son");
                        Console.WriteLine("-Sin completar:");

                        foreach (var tarea in listaDeTareas)
                        {
                            if (tarea.Completada == false){
                                if (tarea.FechaLimite == null)
                                {
                                    Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} y su descripcion es {tarea.Descripcion}");
                                }
                                else
                                {
                                    Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} Su descripcion es {tarea.Descripcion} y su fecha limite es para {tarea.FechaLimite}");
                                }
                            }
                        }

                        Console.WriteLine("-Completadas:");

                        foreach (var tarea in listaDeTareas)
                        {
                            if (tarea.Completada == true)
                                Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} y su descripcion es {tarea.Descripcion} ");
                        }

                        break;
                    
                    case "4":
                        Console.WriteLine("Tus tareas son");
                        Console.WriteLine("-Sin completar:");

                        foreach (var tarea in listaDeTareas)
                        {
                            if (tarea.Completada == false){
                                if (tarea.FechaLimite == null)
                                {
                                    Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} y su descripcion es {tarea.Descripcion}");
                                }
                                else
                                {
                                    Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} Su descripcion es {tarea.Descripcion} y su fecha limite es para {tarea.FechaLimite}");
                                }
                            }
                        }

                        Console.WriteLine("-Completadas:");

                        foreach (var tarea in listaDeTareas)
                        {
                            if (tarea.Completada == true)
                                Console.WriteLine($"{tarea.id}) La tarea se llama {tarea.Nombre} y su descripcion es {tarea.Descripcion} ");
                        }

                        Console.WriteLine("Ingrese el numero de la tarea a borrar:");
                        idTarea = int.Parse(Console.ReadLine());

                        Tarea tareaABorrar = listaDeTareas.Find(tarea => tarea.id == idTarea);

                        if (tareaABorrar != null)
                        {
                            listaDeTareas.Remove(tareaABorrar);
                            Console.WriteLine("La tarea ha sido borrada con exito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ninguna tarea con ese numero.");
                        }

                        break;
                    
                    default:
                        Console.WriteLine("Funcion no reconocida");
                        break;

                }
                
                Console.WriteLine(
                    """

                    Presione el numero de la funcion que desea realizar ahora
                    1) Crear nueva tarea
                    2) Marcar tarea como completada
                    3) Mostrar todas las tareas
                    4) Eliminar una tarea
                    5) Salir del sistema

                    """
                );
                
                decision = Console.ReadLine();
            
            }
        }
    }
}