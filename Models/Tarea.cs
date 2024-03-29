namespace proyectoef.Models;

public class Tarea{
    public Guid TareaId {get;set;}
    public Guid Categoria {get;set;}
    public string Titulo {get;set;}
    public string Descripcion {get;set;}
    public Prioridad PrioridadTarea {get;set;}
    public DateTime FechaCreacion {get;set;}

    public virtual Categoria categoria{get;set;}
}

public enum Prioridad{
    Baja,
    Media,
    Alta
}