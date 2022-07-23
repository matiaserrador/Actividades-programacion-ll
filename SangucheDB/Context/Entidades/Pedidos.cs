using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangucheDB.Context.Entidades
{
    ///Esto define tu Index, la Primery Key
    [Index(nameof(CodigoPedido), Name = "Pedido_Codpedido", IsUnique = true)]
    public class Pedidos
    {
        ///Esto viene de la DataAnnotation que esto NO permite dejar valores nulos, por eso aplico los Required.
        [Required(ErrorMessage = "La dirección es obligatoria")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "El horario del pedido es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string Horario { get; set; }

        [Required(ErrorMessage = "El monto del pedido es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int Monto { get; set; }

        [Required(ErrorMessage = "El tipo de sanguche del pedido es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public string TipoSandwich { get; set; }

        [Required(ErrorMessage = "El codigo del pedido es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El campo tiene como máximo {1} caracteres.")]
        public int CodigoPedido { get; set; }

    }
}
