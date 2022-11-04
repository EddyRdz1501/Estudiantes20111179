using System.ComponentModel.DataAnnotations;

namespace Estudiantes20111179.Data.Models;

public class Estudiantes
{
    
    public int estdiantesID { get; set; }
    public string Nombres { get; set; } = null!;
    public string? Apellidos { get; set; }= null!;
    public string FechaNacimiento { get; set; }= null!;
    public string Carrera { get; set; }= null!;
    public string Matricula {get; set; }= null!;

}
