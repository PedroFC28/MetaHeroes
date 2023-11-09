
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAPI
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        [Column]
        public  string Name { get; set; }
        [Column]
        public string AlterEgo { get; set; }
        [Column]
        public string Power { get; set; }

    }

}
