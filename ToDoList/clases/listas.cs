namespace clases;

public class Tarea{

    private static int s_idListaIncrementado = 1;
    public int id { get; }
    public string Nombre { get; }
    public string Descripcion { get; }
    public string? FechaLimite { get;}
    public bool Completada { get; set;}

    public void DeclararCompletada()
    {
        Completada = true;
    }

    public Tarea(string nombre, string descripcion, string fechaLimite)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        FechaLimite = fechaLimite;
        Completada = false;
        id = s_idListaIncrementado;
        s_idListaIncrementado++;
    }


}