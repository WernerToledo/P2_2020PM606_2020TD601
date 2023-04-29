using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P2_2020PM606_2020TD601.Models
{
    public class departamentos
    {

        [Key]
        public int id_departamento { get; set; }

        public string nombre { get; set; }
    }
}
