using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace P2_2020PM606_2020TD601.Models
{
    public class casosReportados
    {

        [Key]

        public int id_caso { get; set; }

        public int id_departamento { get; set; }

        public int id_genero { get; set; }

        public int confirmados { get; set; }
        public int recuperados { get; set; }
        public int fallecidos { get; set; }
    }
}
