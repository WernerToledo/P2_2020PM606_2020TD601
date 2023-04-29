using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace P2_2020PM606_2020TD601.Models
{
    public class generos
    {
        [Key]
        public int id_genero { get; set; }

        public string genero { get; set; }
    }
}
