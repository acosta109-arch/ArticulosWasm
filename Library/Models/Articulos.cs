﻿using System.ComponentModel.DataAnnotations;

namespace Ap1_P1_JairoCamilo.Models;

public class Articulos
{
    //costo por % de ganancia entre 100 mas costo
 
    [Key]
    public int ArticuloId { get; set; }

    [Required(ErrorMessage = "Favor de digitar una descripción.")]
    public string Descripcion { get; set; }

    [Range(1,200000, ErrorMessage = "Favor de digitar el costo del articulo.")]
    public decimal Costo { get; set; }

    [Range(1, 200000, ErrorMessage = "Favor de digitar la ganancia del articulo.")]
    public decimal Ganancia { get; set; }

    public decimal Precio { get; set; }

}
