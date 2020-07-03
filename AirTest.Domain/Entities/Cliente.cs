using System;
using System.ComponentModel.DataAnnotations;

namespace AirTest.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
