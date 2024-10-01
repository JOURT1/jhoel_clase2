using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace jhoel_clase2.Models
{
    [Authorize]//todos los metodos y atrivutos tienen authorize
    public class EstudianteUDLA
    {
        [Required]// siempre va a ser requerido
        public string IDBaner {  get; set; }

        [AllowNull]//permite que el campo sea nulo  -- anotaciones
        [EmailAddress]//valida que sea correo
        public string? Correo { get; set; }

        [MaxLength(50)]//longitud maxima de 50
        public string Nombre { get; set; }

        //public List<Carrera> Carreras { get; set; } listado de carreras
        public Carrera Carrera { get; set; }
    }
}
