using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int IdBodega { get; set; }
        [Required(ErrorMessage = "El nombre de la bodega es requerido")]
        [MaxLength(60, ErrorMessage = "El nombre debe ser de máximo 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción de la bodega es requerido")]
        [MaxLength(60, ErrorMessage = "La descripción debe ser de máximo 100 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Estado es requerido")]
        public bool Estado { get; set; }

    }
}
